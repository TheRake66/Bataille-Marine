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
            this.panelPlateau = new System.Windows.Forms.Panel();
            this.paramètresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripBarre = new System.Windows.Forms.MenuStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
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
            this.panelPlateau.Location = new System.Drawing.Point(0, 27);
            this.panelPlateau.Name = "panelPlateau";
            this.panelPlateau.Size = new System.Drawing.Size(800, 423);
            this.panelPlateau.TabIndex = 1;
            // 
            // paramètresToolStripMenuItem
            // 
            this.paramètresToolStripMenuItem.Name = "paramètresToolStripMenuItem";
            this.paramètresToolStripMenuItem.Size = new System.Drawing.Size(78, 23);
            this.paramètresToolStripMenuItem.Text = "Paramètres";
            // 
            // menuStripBarre
            // 
            this.menuStripBarre.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paramètresToolStripMenuItem,
            this.toolStripTextBox1});
            this.menuStripBarre.Location = new System.Drawing.Point(0, 0);
            this.menuStripBarre.Name = "menuStripBarre";
            this.menuStripBarre.Size = new System.Drawing.Size(800, 27);
            this.menuStripBarre.TabIndex = 0;
            this.menuStripBarre.Text = "menuStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
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
            this.toolStripStatusLabelRestantes.Size = new System.Drawing.Size(714, 17);
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
            this.timerHorloge.Enabled = true;
            this.timerHorloge.Interval = 1000;
            this.timerHorloge.Tick += new System.EventHandler(this.timerHorloge_Tick);
            // 
            // Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStripBarre);
            this.Controls.Add(this.panelPlateau);
            this.Controls.Add(this.menuStripBarre);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripBarre;
            this.MaximizeBox = false;
            this.Name = "Jeu";
            this.Text = "Bataille Marine";
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
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.StatusStrip statusStripBarre;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRestantes;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTime;
        private System.Windows.Forms.Timer timerHorloge;
    }
}

