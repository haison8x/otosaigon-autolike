using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;

namespace OtoSaiGonUI
{
    public partial class Form1 : Form
    {
        private const int MaxPageOfAThread = 1;
        private WebClientEx webClient = new WebClientEx();

        private int likeId;
        private string boxUrl;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LikeTypeComboBox.SelectedItem = null;
            LikeTypeComboBox.SelectedText = "Love";
            boxUrl = BoxUrlTextBox.Text;
            likeId = 2;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var data = $"login={EmailTextBox.Text}&password={PasswordTextBox.Text}&remember=1";
            webClient.AddHeaders();
            webClient.AddHeaders("Content-Type", "application/x-www-form-urlencoded");
            webClient.UploadString("https://www.otosaigon.com/login/login", data);
            LoginButton.Enabled = false;
            LikeButton.Enabled = true;
        }

        private void LikeButton_Click(object sender, EventArgs e)
        {
            LikeButton.Enabled = false;

            Task.Run(async () =>
            {
                await LikeAllThreads();
                this.Invoke((MethodInvoker)delegate
                {
                    LikeButton.Enabled = true;
                });
            });
        }

        private async Task LikeAllThreads()
        {
            try
            {
                var threads = await GetAllThread();
                foreach (var thread in threads)
                {
                    var pageIndex = 1;
                    while (pageIndex <= MaxPageOfAThread)
                    {
                        var tuple = await GetPost(thread);
                        foreach (var likeLink in tuple.Item1)
                        {
                            await Like(likeLink, thread, tuple.Item3);
                        }

                        pageIndex++;

                        if (!tuple.Item2)
                        {
                            break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
            }

        }

        private async Task<List<string>> GetAllThread()
        {
            webClient.AddHeaders();
            var linkNodes = await QueryAll(boxUrl, ".structItem-title .unread-class");

            return linkNodes.Select(n => $"https://www.otosaigon.com{n.GetAttributeValue("href", "")}").ToList();
        }

        private async Task<Tuple<List<string>, bool, string>> GetPost(string thread)
        {
            webClient.AddHeaders();
            var text = await webClient.DownloadStringTaskAsync(thread);
            var html = new HtmlAgilityPack.HtmlDocument();
            html.LoadHtml(text);
            var document = html.DocumentNode;

            var likeLinks = document.QuerySelectorAll(".actionBar-action--reaction")
                .Where(b => !b.GetAttributeValue("class", "").Contains("has-reaction"))
                .Select(b => b.GetAttributeValue("href", ""))
                .Select(s => $"https://www.otosaigon.com{s}")
                .ToList();

            var nextPageExisted = document.QuerySelectorAll(".pageNav-jump--next").Any();

            var token = GetToken(text);

            return new Tuple<List<string>, bool, string>(likeLinks, nextPageExisted, token);
        }

        private static string GetToken(string text)
        {
            var csrfStartTag = @"csrf: '";
            var csrfStartIndex = text.IndexOf(csrfStartTag) + csrfStartTag.Length;
            var csrfEndIndex = text.IndexOf("'", csrfStartIndex);
            var token = text.Substring(csrfStartIndex, csrfEndIndex - csrfStartIndex);

            return token;
        }

        private async Task Like(string likeLink, string threadUrl, string token)
        {
            var likeUrl = likeLink.Substring(0, likeLink.LastIndexOf("=")) + "=" + likeId;

            threadUrl = threadUrl.Replace("https://www.otosaigon.com", "");
            var encodedThreadUrl = HttpUtility.UrlEncode(threadUrl);
            var formdata = $"_xfRequestUri={encodedThreadUrl}&_xfWithData=1&_xfToken={token}&_xfResponseType=json";

            webClient.AddAjaxHeaders();
            await webClient.UploadStringTaskAsync(likeUrl, formdata);
        }

        public async Task<IEnumerable<HtmlNode>> QueryAll(string url, string selector)
        {
            webClient.AddHeaders();
            var text = await webClient.DownloadStringTaskAsync(url);
            var html = new HtmlAgilityPack.HtmlDocument();
            html.LoadHtml(text);

            var document = html.DocumentNode;

            return document.QuerySelectorAll(selector);
        }

        private void BoxUrlTextBox_TextChanged(object sender, EventArgs e)
        {
            boxUrl = BoxUrlTextBox.Text;
        }

        private void LikeTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            likeId = LikeTypeComboBox.SelectedIndex + 1;
        }
    }
}
