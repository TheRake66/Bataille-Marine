namespace Bataille_Marine
{
    partial class Jeu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jeu));
            this.panelPlateau = new System.Windows.Forms.Panel();
            this.paramètresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recommencerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.préférencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripBarre = new System.Windows.Forms.MenuStrip();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.règlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.pageInternetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.àProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripBarre = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelRestantes = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerHorloge = new System.Windows.Forms.Timer(this.components);
            this.menuStripBarre.SuspendLayout();
            this.statusStripBarre.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPlateau
            // 
            this.panelPlateau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPlateau.Location = new System.Drawing.Point(0, 24);
            this.panelPlateau.Name = "panelPlateau";
            this.panelPlateau.Size = new System.Drawing.Size(800, 404);
            this.panelPlateau.TabIndex = 1;
            // 
            // paramètresToolStripMenuItem
            // 
            this.paramètresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recommencerToolStripMenuItem,
            this.toolStripSeparator2,
            this.préférencesToolStripMenuItem,
            this.sonToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitterToolStripMenuItem});
            this.paramètresToolStripMenuItem.Name = "paramètresToolStripMenuItem";
            this.paramètresToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.paramètresToolStripMenuItem.Text = "Jeu";
            // 
            // recommencerToolStripMenuItem
            // 
            this.recommencerToolStripMenuItem.Name = "recommencerToolStripMenuItem";
            this.recommencerToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.recommencerToolStripMenuItem.Text = "Recommencer";
            this.recommencerToolStripMenuItem.Click += new System.EventHandler(this.recommencerToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(148, 6);
            // 
            // préférencesToolStripMenuItem
            // 
            this.préférencesToolStripMenuItem.Name = "préférencesToolStripMenuItem";
            this.préférencesToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.préférencesToolStripMenuItem.Text = "Préférences";
            this.préférencesToolStripMenuItem.Click += new System.EventHandler(this.préférencesToolStripMenuItem_Click);
            // 
            // sonToolStripMenuItem
            // 
            this.sonToolStripMenuItem.Checked = true;
            this.sonToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sonToolStripMenuItem.Name = "sonToolStripMenuItem";
            this.sonToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.sonToolStripMenuItem.Text = "Son";
            this.sonToolStripMenuItem.Click += new System.EventHandler(this.sonToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // menuStripBarre
            // 
            this.menuStripBarre.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paramètresToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStripBarre.Location = new System.Drawing.Point(0, 0);
            this.menuStripBarre.Name = "menuStripBarre";
            this.menuStripBarre.Size = new System.Drawing.Size(800, 24);
            this.menuStripBarre.TabIndex = 0;
            this.menuStripBarre.Text = "menuStrip1";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.règlesToolStripMenuItem,
            this.toolStripSeparator3,
            this.pageInternetToolStripMenuItem,
            this.àProposToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // règlesToolStripMenuItem
            // 
            this.règlesToolStripMenuItem.Name = "règlesToolStripMenuItem";
            this.règlesToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.règlesToolStripMenuItem.Text = "Règles du jeu";
            this.règlesToolStripMenuItem.Click += new System.EventHandler(this.règlesToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // pageInternetToolStripMenuItem
            // 
            this.pageInternetToolStripMenuItem.Name = "pageInternetToolStripMenuItem";
            this.pageInternetToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pageInternetToolStripMenuItem.Text = "Page internet";
            this.pageInternetToolStripMenuItem.Click += new System.EventHandler(this.pageInternetToolStripMenuItem_Click);
            // 
            // àProposToolStripMenuItem
            // 
            this.àProposToolStripMenuItem.Name = "àProposToolStripMenuItem";
            this.àProposToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.àProposToolStripMenuItem.Text = "À propos...";
            this.àProposToolStripMenuItem.Click += new System.EventHandler(this.àProposToolStripMenuItem_Click);
            // 
            // statusStripBarre
            // 
            this.statusStripBarre.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelRestantes,
            this.toolStripStatusLabelTime});
            this.statusStripBarre.Location = new System.Drawing.Point(0, 428);
            this.statusStripBarre.Name = "statusStripBarre";
            this.statusStripBarre.Size = new System.Drawing.Size(800, 22);
            this.statusStripBarre.TabIndex = 2;
            this.statusStripBarre.Text = "statusStrip1";
            // 
            // toolStripStatusLabelRestantes
            // 
            this.toolStripStatusLabelRestantes.Name = "toolStripStatusLabelRestantes";
            this.toolStripStatusLabelRestantes.Size = new System.Drawing.Size(745, 17);
            this.toolStripStatusLabelRestantes.Spring = true;
            this.toolStripStatusLabelRestantes.Text = "Mines restantes : 5";
            this.toolStripStatusLabelRestantes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabelTime
            // 
            this.toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
            this.toolStripStatusLabelTime.Size = new System.Drawing.Size(40, 17);
            this.toolStripStatusLabelTime.Text = "00 : 00";
            // 
            // timerHorloge
            // 
            this.timerHorloge.Interval = 1000;
            this.timerHorloge.Tick += new System.EventHandler(this.timerHorloge_Tick);
            // 
            // Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelPlateau);
            this.Controls.Add(this.statusStripBarre);
            this.Controls.Add(this.menuStripBarre);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripBarre;
            this.MaximizeBox = false;
            this.Name = "Jeu";
            this.Text = "Bataille Marine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Jeu_FormClosing);
            this.Load += new System.EventHandler(this.Jeu_Load);
            this.menuStripBarre.ResumeLayout(false);
            this.menuStripBarre.PerformLayout();
            this.statusStripBarre.ResumeLayout(false);
            this.statusStripBarre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelPlateau;
        private System.Windows.Forms.ToolStripMenuItem paramètresToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripBarre;
        private System.Windows.Forms.StatusStrip statusStripBarre;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRestantes;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTime;
        private System.Windows.Forms.Timer timerHorloge;
        private System.Windows.Forms.ToolStripMenuItem recommencerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem préférencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sonToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem règlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem pageInternetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem àProposToolStripMenuItem;
    }
}

