namespace OtoSaiGonUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginButton = new System.Windows.Forms.Button();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.BoxUrlTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LikeButton = new System.Windows.Forms.Button();
            this.LikeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProfileUrlTextBox = new System.Windows.Forms.TextBox();
            this.LikeUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(12, 74);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(331, 23);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(75, 12);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(268, 20);
            this.EmailTextBox.TabIndex = 1;
            // 
            // BoxUrlTextBox
            // 
            this.BoxUrlTextBox.Location = new System.Drawing.Point(75, 103);
            this.BoxUrlTextBox.Name = "BoxUrlTextBox";
            this.BoxUrlTextBox.Size = new System.Drawing.Size(268, 20);
            this.BoxUrlTextBox.TabIndex = 3;
            this.BoxUrlTextBox.Text = "https://www.otosaigon.com/forums/chuyen-ngoai-le.63/";
            this.BoxUrlTextBox.TextChanged += new System.EventHandler(this.BoxUrlTextBox_TextChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(75, 48);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(268, 20);
            this.PasswordTextBox.TabIndex = 2;
            // 
            // LikeButton
            // 
            this.LikeButton.Enabled = false;
            this.LikeButton.Location = new System.Drawing.Point(12, 156);
            this.LikeButton.Name = "LikeButton";
            this.LikeButton.Size = new System.Drawing.Size(331, 23);
            this.LikeButton.TabIndex = 4;
            this.LikeButton.Text = "Thả";
            this.LikeButton.UseVisualStyleBackColor = true;
            this.LikeButton.Click += new System.EventHandler(this.LikeButton_Click);
            // 
            // LikeTypeComboBox
            // 
            this.LikeTypeComboBox.FormattingEnabled = true;
            this.LikeTypeComboBox.Items.AddRange(new object[] {
            "Like",
            "Love",
            "Haha",
            "Wow",
            "Sad",
            "Angry",
            "Random"});
            this.LikeTypeComboBox.Location = new System.Drawing.Point(75, 129);
            this.LikeTypeComboBox.Name = "LikeTypeComboBox";
            this.LikeTypeComboBox.Size = new System.Drawing.Size(268, 21);
            this.LikeTypeComboBox.TabIndex = 4;
            this.LikeTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.LikeTypeComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Box Url";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Like Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Profile Url";
            // 
            // ProfileUrlTextBox
            // 
            this.ProfileUrlTextBox.Location = new System.Drawing.Point(75, 197);
            this.ProfileUrlTextBox.Name = "ProfileUrlTextBox";
            this.ProfileUrlTextBox.Size = new System.Drawing.Size(268, 20);
            this.ProfileUrlTextBox.TabIndex = 5;
            this.ProfileUrlTextBox.Text = "https://www.otosaigon.com/members/viet-xuan.83881/";
            this.ProfileUrlTextBox.TextChanged += new System.EventHandler(this.ProfileUrlTextBox_TextChanged);
            // 
            // LikeUserButton
            // 
            this.LikeUserButton.Enabled = false;
            this.LikeUserButton.Location = new System.Drawing.Point(12, 224);
            this.LikeUserButton.Name = "LikeUserButton";
            this.LikeUserButton.Size = new System.Drawing.Size(331, 23);
            this.LikeUserButton.TabIndex = 12;
            this.LikeUserButton.Text = "Truy sát";
            this.LikeUserButton.UseVisualStyleBackColor = true;
            this.LikeUserButton.Click += new System.EventHandler(this.LikeUserButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 259);
            this.Controls.Add(this.LikeUserButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProfileUrlTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LikeTypeComboBox);
            this.Controls.Add(this.LikeButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.BoxUrlTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.LoginButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox BoxUrlTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button LikeButton;
        private System.Windows.Forms.ComboBox LikeTypeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProfileUrlTextBox;
        private System.Windows.Forms.Button LikeUserButton;
    }
}

