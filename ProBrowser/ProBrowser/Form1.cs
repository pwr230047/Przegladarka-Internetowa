using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProBrowser
{
    public partial class ProBrowser : Form
    {
        String Url = string.Empty;
        public ProBrowser()
        {
            InitializeComponent();
            Url = "www.wemif.pwr.edu.pl";
            myBrowser();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pBack.Enabled = false;
            pForward.Enabled = false;
            webBrowser.Navigate("https://www.google.pl");
            webBrowser.DocumentCompleted += WebBrowser_DocumentCompleted;
        }

        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl1.SelectedTab.Text = webBrowser.DocumentTitle;
        }

        private void pGo_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl1.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
                web.Navigate(UrlText.Text);
            if (!UrlText.Items.Contains(UrlText.Text))
                UrlText.Items.Add("http://" + UrlText.Text);
        }

        WebBrowser webTab = null;
        private void NewTab_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "Nowa Zakladka";
            tabControl1.Controls.Add(tab);
            tabControl1.SelectTab(tabControl1.TabCount - 1);
            webTab = new WebBrowser() { ScriptErrorsSuppressed = true };
            webTab.Parent = tab;
            webTab.Dock = DockStyle.Fill;
            webTab.Navigate("");
            webTab.DocumentCompleted += WebTab_DocumentCompleted;
        }

        private void WebTab_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl1.SelectedTab.Text = webTab.DocumentTitle;
        }
        private void pBack_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl1.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                if (web.CanGoBack)
                    web.GoBack();
            }
        }

        private void pForward_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl1.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                if (web.CanGoForward)
                    web.GoForward();
            }
        }

        private void pHome_Click(object sender, EventArgs e)
        {
             webBrowser.GoHome();
             toolStripStatusLabel1.Text = "Strona główna";
        }

        private void UrlText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                WebBrowser web = tabControl1.SelectedTab.Controls[0] as WebBrowser;
                if (web != null)
                    web.Navigate(UrlText.Text);
                if (!UrlText.Items.Contains(UrlText.Text))
                    UrlText.Items.Add("http://" + UrlText.Text);
            }
        }

        private void pRefresh_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl1.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                web.Refresh();
                toolStripStatusLabel1.Text = "Odświeżanie";
            }
        }
        private void myBrowser()
        {
            if (UrlText.Text != "")
                Url = UrlText.Text;
            webBrowser.Navigate(Url);
            webBrowser.ProgressChanged +=
            new WebBrowserProgressChangedEventHandler(webpage_ProgressChanged);
            webBrowser.DocumentTitleChanged += new EventHandler(webpage_DocumentTitleChanged);
            webBrowser.StatusTextChanged += new EventHandler(webpage_StatusTextChanged);
            webBrowser.Navigated += new WebBrowserNavigatedEventHandler(webpage_Navigated);
            webBrowser.DocumentCompleted +=
            new WebBrowserDocumentCompletedEventHandler(webpage_DocumentCompleted);
        }

        private void webpage_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser.CanGoBack) pBack.Enabled = true;
            else pBack.Enabled = false;

            if (webBrowser.CanGoForward) pForward.Enabled = true;
            else pForward.Enabled = false;
            toolStripStatusLabel1.Text = "Gotowe";
        }
        private void webpage_DocumentTitleChanged(object sender, EventArgs e)
        {
            this.Text = webBrowser.DocumentTitle.ToString();
        }

        private void webpage_StatusTextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = webBrowser.StatusText;
        }

        private void webpage_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Maximum = (int)e.MaximumProgress;
            toolStripProgressBar1.Value = ((int)e.CurrentProgress < 0 ||
            (int)e.MaximumProgress < (int)e.CurrentProgress) ? (int)e.MaximumProgress : (int)e.CurrentProgress;
        }
        // Wyswietlanie strony
        private void webpage_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            UrlText.Text = webBrowser.Url.ToString();
        }

        private void pFind_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate("https://www.google.pl/search?source=hp&ei=ds0zWq7oJI24kwWWmaRw&q=" + FindText.Text);
        }
    }
}