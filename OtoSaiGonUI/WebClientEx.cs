using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;

namespace OtoSaiGonUI
{
    public class WebClientEx : WebClient
    {
        public WebClientEx(CookieContainer container)
        {
            this.container = container;
            Encoding = System.Text.Encoding.UTF8;
        }

        public WebClientEx()
        {
            this.container = new CookieContainer();
            Encoding = System.Text.Encoding.UTF8;
        }

        public CookieContainer CookieContainer
        {
            get { return container; }
            set { container = value; }
        }

        private CookieContainer container = new CookieContainer();

        protected override WebRequest GetWebRequest(Uri address)
        {
            WebRequest r = base.GetWebRequest(address);
            var request = r as HttpWebRequest;
            if (request != null)
            {
                request.KeepAlive = true;
                request.CookieContainer = container;
            }
            return r;
        }

        protected override WebResponse GetWebResponse(WebRequest request, IAsyncResult result)
        {
            WebResponse response = base.GetWebResponse(request, result);
            ReadCookies(response);
            return response;
        }

        protected override WebResponse GetWebResponse(WebRequest request)
        {
            WebResponse response = base.GetWebResponse(request);
            ReadCookies(response);
            return response;
        }

        private void ReadCookies(WebResponse r)
        {
            var response = r as HttpWebResponse;
            if (response != null)
            {
                CookieCollection cookies = response.Cookies;
                container.Add(cookies);
            }
        }

        public void AddHeaders()
        {
            AddHeaders("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3987.163 Safari/537.36");
            AddHeaders("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
            AddHeaders("Accept-Language", "en-US,en;q=0.9,vi;q=0.8");
        }


        public void AddAjaxHeaders()
        {
            AddHeaders("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3987.163 Safari/537.36");
            AddHeaders("Accept", "application/json, text/javascript, */*; q=0.01");
            AddHeaders("Accept-Language", "en-US,en;q=0.9,vi;q=0.8");
            AddHeaders("X-Requested-With", "XMLHttpRequest");
            AddHeaders("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");            
        }

        public void AddHeaders(string name, string value)
        {
            if (Headers.Get(name) == null)
            {
                Headers.Add(name, value);
            }
        }

        public void RemoveHeaders(string name)
        {
            if (Headers.Get(name) != null)
            {
                Headers.Remove(name);
            }
        }        
    }
}
