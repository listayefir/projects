namespace MyBrowser
{
    partial class TheBestBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheBestBrowser));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.textURL = new System.Windows.Forms.TextBox();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.buttonGet = new System.Windows.Forms.Button();
            this.textHtml = new System.Windows.Forms.TextBox();
            this.textCookie = new System.Windows.Forms.TextBox();
            this.buttonLink = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonPic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(3, 67);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(654, 551);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Black;
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.Image = global::MyBrowser.Properties.Resources.search;
            this.buttonSearch.Location = new System.Drawing.Point(333, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(58, 59);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.Black;
            this.buttonHome.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.Image = global::MyBrowser.Properties.Resources.home;
            this.buttonHome.Location = new System.Drawing.Point(251, 2);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(58, 59);
            this.buttonHome.TabIndex = 4;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Black;
            this.buttonRefresh.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.Image = global::MyBrowser.Properties.Resources.refresh;
            this.buttonRefresh.Location = new System.Drawing.Point(169, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(58, 59);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.BackColor = System.Drawing.Color.Black;
            this.buttonForward.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonForward.FlatAppearance.BorderSize = 0;
            this.buttonForward.Image = global::MyBrowser.Properties.Resources.forward;
            this.buttonForward.Location = new System.Drawing.Point(89, 2);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(58, 59);
            this.buttonForward.TabIndex = 2;
            this.buttonForward.UseVisualStyleBackColor = false;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Black;
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.Image = global::MyBrowser.Properties.Resources.back;
            this.buttonBack.Location = new System.Drawing.Point(13, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(58, 59);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textURL
            // 
            this.textURL.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textURL.Location = new System.Drawing.Point(397, 12);
            this.textURL.Name = "textURL";
            this.textURL.Size = new System.Drawing.Size(748, 33);
            this.textURL.TabIndex = 6;
            this.textURL.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textURL_KeyUp);
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(678, 67);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(449, 20);
            this.textTitle.TabIndex = 7;
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(695, 577);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(75, 23);
            this.buttonGet.TabIndex = 8;
            this.buttonGet.Text = "Get data";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // textHtml
            // 
            this.textHtml.Location = new System.Drawing.Point(678, 126);
            this.textHtml.Multiline = true;
            this.textHtml.Name = "textHtml";
            this.textHtml.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textHtml.Size = new System.Drawing.Size(449, 120);
            this.textHtml.TabIndex = 9;
            // 
            // textCookie
            // 
            this.textCookie.Location = new System.Drawing.Point(678, 279);
            this.textCookie.Multiline = true;
            this.textCookie.Name = "textCookie";
            this.textCookie.Size = new System.Drawing.Size(449, 125);
            this.textCookie.TabIndex = 10;
            // 
            // buttonLink
            // 
            this.buttonLink.Location = new System.Drawing.Point(776, 577);
            this.buttonLink.Name = "buttonLink";
            this.buttonLink.Size = new System.Drawing.Size(75, 23);
            this.buttonLink.TabIndex = 11;
            this.buttonLink.Text = "Get link";
            this.buttonLink.UseVisualStyleBackColor = true;
            this.buttonLink.Click += new System.EventHandler(this.buttonLink_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(678, 410);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(263, 161);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 12;
            this.pictureBox.TabStop = false;
            // 
            // buttonPic
            // 
            this.buttonPic.Location = new System.Drawing.Point(866, 577);
            this.buttonPic.Name = "buttonPic";
            this.buttonPic.Size = new System.Drawing.Size(75, 23);
            this.buttonPic.TabIndex = 13;
            this.buttonPic.Text = "Get picture";
            this.buttonPic.UseVisualStyleBackColor = true;
            this.buttonPic.Click += new System.EventHandler(this.buttonPic_Click);
            // 
            // TheBestBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 616);
            this.Controls.Add(this.buttonPic);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonLink);
            this.Controls.Add(this.textCookie);
            this.Controls.Add(this.textHtml);
            this.Controls.Add(this.buttonGet);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.textURL);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonForward);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.webBrowser1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TheBestBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TheBestBrowser";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textURL;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.TextBox textHtml;
        private System.Windows.Forms.TextBox textCookie;
        private System.Windows.Forms.Button buttonLink;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonPic;
    }
}

