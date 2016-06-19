using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBrowser
{
    public partial class TheBestBrowser : Form
    {
        string mainSite = "lenta.ru";
        string homeSite = "google.com";
        public TheBestBrowser()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate(mainSite);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(homeSite);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            webBrowser1.GoSearch();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            textURL.Text = webBrowser1.Url.ToString();
        }

        private void textURL_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(textURL.Text);
            }
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            textTitle.Text = webBrowser1.DocumentTitle;
            textHtml.Text = webBrowser1.DocumentText;
            textCookie.Text = webBrowser1.Document.Cookie;    
        }

        private void buttonLink_Click(object sender, EventArgs e)
        {
            textHtml.Text = "";
            HtmlElementCollection coll = webBrowser1.Document.Links;
            
            foreach (HtmlElement link in coll)
            {
               if (link.OuterText== "Разбившийся лайнер пытался приземлиться в течение двух часов")
                textHtml.Text += link.OuterHtml + Environment.NewLine;
                
                
            }
        }

        private void buttonPic_Click(object sender, EventArgs e)
        {
           HtmlElementCollection pics = webBrowser1.Document.Images;
           string picLink = pics[0].GetAttribute("src");
          pictureBox.ImageLocation = pics[0].GetAttribute("src");
            /*foreach (HtmlElement pic in pics)
            {
                pictureBox.Image=pic.
            }*/
        }
    }
}
