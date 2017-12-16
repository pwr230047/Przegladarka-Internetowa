namespace ProBrowser
{
    partial class ProBrowser
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProBrowser));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pBack = new System.Windows.Forms.ToolStripButton();
            this.pForward = new System.Windows.Forms.ToolStripButton();
            this.pRefresh = new System.Windows.Forms.ToolStripButton();
            this.pHome = new System.Windows.Forms.ToolStripButton();
            this.UrlText = new System.Windows.Forms.ToolStripComboBox();
            this.pGo = new System.Windows.Forms.ToolStripButton();
            this.NewTab = new System.Windows.Forms.ToolStripButton();
            this.Remove = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.FindText = new System.Windows.Forms.ToolStripComboBox();
            this.pFind = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pBack,
            this.pForward,
            this.pRefresh,
            this.pHome,
            this.UrlText,
            this.pGo,
            this.FindText,
            this.pFind,
            this.NewTab,
            this.Remove});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(894, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pBack
            // 
            this.pBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pBack.Image = global::ProBrowser.Properties.Resources.icons8_lewo_50;
            this.pBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pBack.Name = "pBack";
            this.pBack.Size = new System.Drawing.Size(23, 22);
            this.pBack.Text = "Wstecz";
            this.pBack.Click += new System.EventHandler(this.pBack_Click);
            // 
            // pForward
            // 
            this.pForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pForward.Image = global::ProBrowser.Properties.Resources.icons8_prawo_50;
            this.pForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pForward.Name = "pForward";
            this.pForward.Size = new System.Drawing.Size(23, 22);
            this.pForward.Text = "Naprzod";
            this.pForward.Click += new System.EventHandler(this.pForward_Click);
            // 
            // pRefresh
            // 
            this.pRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pRefresh.Image = global::ProBrowser.Properties.Resources.icons8_synchronizacja_połączenia_50;
            this.pRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pRefresh.Name = "pRefresh";
            this.pRefresh.Size = new System.Drawing.Size(23, 22);
            this.pRefresh.Text = "odswierz";
            this.pRefresh.Click += new System.EventHandler(this.pRefresh_Click);
            // 
            // pHome
            // 
            this.pHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pHome.Image = global::ProBrowser.Properties.Resources.icons8_dom_50;
            this.pHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pHome.Name = "pHome";
            this.pHome.Size = new System.Drawing.Size(23, 22);
            this.pHome.Text = "Home";
            this.pHome.Click += new System.EventHandler(this.pHome_Click);
            // 
            // UrlText
            // 
            this.UrlText.Name = "UrlText";
            this.UrlText.Size = new System.Drawing.Size(400, 25);
            this.UrlText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UrlText_KeyPress);
            // 
            // pGo
            // 
            this.pGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pGo.Image = global::ProBrowser.Properties.Resources.icons8_odtwórz_50;
            this.pGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pGo.Name = "pGo";
            this.pGo.Size = new System.Drawing.Size(23, 22);
            this.pGo.Text = "Idz";
            this.pGo.Click += new System.EventHandler(this.pGo_Click);
            // 
            // NewTab
            // 
            this.NewTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.NewTab.Image = ((System.Drawing.Image)(resources.GetObject("NewTab.Image")));
            this.NewTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewTab.Name = "NewTab";
            this.NewTab.Size = new System.Drawing.Size(90, 22);
            this.NewTab.Text = "Nowa zakladka";
            this.NewTab.Click += new System.EventHandler(this.NewTab_Click);
            // 
            // Remove
            // 
            this.Remove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Remove.Image = ((System.Drawing.Image)(resources.GetObject("Remove.Image")));
            this.Remove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(88, 22);
            this.Remove.Text = "Usun Zakladke";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(894, 377);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.webBrowser);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(886, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 326);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(880, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(3, 3);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(880, 345);
            this.webBrowser.TabIndex = 0;
            // 
            // FindText
            // 
            this.FindText.Name = "FindText";
            this.FindText.Size = new System.Drawing.Size(121, 25);
            // 
            // pFind
            // 
            this.pFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pFind.Image = ((System.Drawing.Image)(resources.GetObject("pFind.Image")));
            this.pFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pFind.Name = "pFind";
            this.pFind.Size = new System.Drawing.Size(23, 22);
            this.pFind.Text = "Znajdz";
            this.pFind.Click += new System.EventHandler(this.pFind_Click);
            // 
            // ProBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 402);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ProBrowser";
            this.Text = "ProBrowser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton pBack;
        private System.Windows.Forms.ToolStripButton pForward;
        private System.Windows.Forms.ToolStripButton pHome;
        private System.Windows.Forms.ToolStripComboBox UrlText;
        private System.Windows.Forms.ToolStripButton pGo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.ToolStripButton NewTab;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripButton pRefresh;
        private System.Windows.Forms.ToolStripButton Remove;
        private System.Windows.Forms.ToolStripComboBox FindText;
        private System.Windows.Forms.ToolStripButton pFind;
    }
}

