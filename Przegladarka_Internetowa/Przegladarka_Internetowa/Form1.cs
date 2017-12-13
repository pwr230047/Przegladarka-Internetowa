using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przegladarka_Internetowa
{
    public partial class Form1 : Form
    {
        String Url = string.Empty;
        public Form1()
        {
            InitializeComponent();
            Url = "www.wemif.pwr.edu.pl";
            myBrowser();
        }
        // Funkcja do wygenerowania strony wyszukujacej
        private void Go_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(UrlText.Text);
        }
        // Funkcja umozliwiajaca zatwierdzenie wyszukiwanej strony, przyciskiem Enter
        private void UrlText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                
            }
        }
        // Wyłączą dostęp do przycisków Następny i Poprzedni podczas uruchamiania formularza
        private void Form1_Load_1(object sender, EventArgs e)
        {
            toolStripButton1.Enabled = false;
            toolStripButton2.Enabled = false;
        }
        // Przechodzi do poprzedniej strony
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
        // Nawiguje, aby przesłać dalej stronę internetową
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
        // Przeładuje stronę internetową
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
            toolStripStatusLabel1.Text = "Odświeżanie";
        }
        // Przechodzi do strony głównej
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
            toolStripStatusLabel2.Text = "Strona główna";
        }
        private void myBrowser()
        {
            if (UrlText.Text != "")
                Url = UrlText.Text;
            webBrowser1.Navigate(Url);
            webBrowser1.ProgressChanged +=
            new WebBrowserProgressChangedEventHandler(webpage_ProgressChanged);
            webBrowser1.DocumentTitleChanged += new EventHandler(webpage_DocumentTitleChanged);
            webBrowser1.StatusTextChanged += new EventHandler(webpage_StatusTextChanged);
            webBrowser1.Navigated += new WebBrowserNavigatedEventHandler(webpage_Navigated);
            webBrowser1.DocumentCompleted +=
            new WebBrowserDocumentCompletedEventHandler(webpage_DocumentCompleted);
        }

        private void webpage_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.CanGoBack) toolStripButton1.Enabled = true;
            else toolStripButton1.Enabled = false;

            if (webBrowser1.CanGoForward) toolStripButton2.Enabled = true;
            else toolStripButton2.Enabled = false;
            toolStripStatusLabel2.Text = "Done";
        }

        private void webpage_DocumentTitleChanged(object sender, EventArgs e)
        {
            this.Text = webBrowser1.DocumentTitle.ToString();
        }

        private void webpage_StatusTextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = webBrowser1.StatusText;
        }

        private void webpage_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            toolStripProgressBar2.Maximum = (int)e.MaximumProgress;
            toolStripProgressBar2.Value = ((int)e.CurrentProgress < 0 ||
            (int)e.MaximumProgress < (int)e.CurrentProgress) ? (int)e.MaximumProgress : (int)e.CurrentProgress;
        }
        // Wyswietlanie strony
        private void webpage_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            UrlText.Text = webBrowser1.Url.ToString();
        }
    }
}
