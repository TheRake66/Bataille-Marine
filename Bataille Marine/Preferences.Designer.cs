namespace Bataille_Marine
{
    partial class Preferences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preferences));
            this.trackBarColonnes = new System.Windows.Forms.TrackBar();
            this.labelColonnes = new System.Windows.Forms.Label();
            this.labelLignes = new System.Windows.Forms.Label();
            this.trackBarLignes = new System.Windows.Forms.TrackBar();
            this.labelTaille = new System.Windows.Forms.Label();
            this.trackBarTaille = new System.Windows.Forms.TrackBar();
            this.labelProba = new System.Windows.Forms.Label();
            this.trackBarProba = new System.Windows.Forms.TrackBar();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonSauvegarder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarColonnes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLignes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTaille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarProba)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarColonnes
            // 
            this.trackBarColonnes.Location = new System.Drawing.Point(20, 36);
            this.trackBarColonnes.Maximum = 30;
            this.trackBarColonnes.Minimum = 3;
            this.trackBarColonnes.Name = "trackBarColonnes";
            this.trackBarColonnes.Size = new System.Drawing.Size(300, 45);
            this.trackBarColonnes.TabIndex = 0;
            this.trackBarColonnes.Value = 3;
            this.trackBarColonnes.ValueChanged += new System.EventHandler(this.trackBarColonnes_ValueChanged);
            // 
            // labelColonnes
            // 
            this.labelColonnes.AutoSize = true;
            this.labelColonnes.Location = new System.Drawing.Point(20, 20);
            this.labelColonnes.Name = "labelColonnes";
            this.labelColonnes.Size = new System.Drawing.Size(111, 13);
            this.labelColonnes.TabIndex = 1;
            this.labelColonnes.Text = "Nombre de colonnes :";
            // 
            // labelLignes
            // 
            this.labelLignes.AutoSize = true;
            this.labelLignes.Location = new System.Drawing.Point(20, 84);
            this.labelLignes.Name = "labelLignes";
            this.labelLignes.Size = new System.Drawing.Size(95, 13);
            this.labelLignes.TabIndex = 3;
            this.labelLignes.Text = "Nombre de lignes :";
            // 
            // trackBarLignes
            // 
            this.trackBarLignes.Location = new System.Drawing.Point(20, 100);
            this.trackBarLignes.Maximum = 30;
            this.trackBarLignes.Minimum = 3;
            this.trackBarLignes.Name = "trackBarLignes";
            this.trackBarLignes.Size = new System.Drawing.Size(300, 45);
            this.trackBarLignes.TabIndex = 2;
            this.trackBarLignes.Value = 9;
            this.trackBarLignes.ValueChanged += new System.EventHandler(this.trackBarLignes_ValueChanged);
            // 
            // labelTaille
            // 
            this.labelTaille.AutoSize = true;
            this.labelTaille.Location = new System.Drawing.Point(20, 148);
            this.labelTaille.Name = "labelTaille";
            this.labelTaille.Size = new System.Drawing.Size(128, 13);
            this.labelTaille.TabIndex = 5;
            this.labelTaille.Text = "Taille des cases en pixel :";
            // 
            // trackBarTaille
            // 
            this.trackBarTaille.Location = new System.Drawing.Point(20, 164);
            this.trackBarTaille.Maximum = 50;
            this.trackBarTaille.Minimum = 10;
            this.trackBarTaille.Name = "trackBarTaille";
            this.trackBarTaille.Size = new System.Drawing.Size(300, 45);
            this.trackBarTaille.TabIndex = 4;
            this.trackBarTaille.Value = 15;
            this.trackBarTaille.ValueChanged += new System.EventHandler(this.trackBarTaille_ValueChanged);
            // 
            // labelProba
            // 
            this.labelProba.AutoSize = true;
            this.labelProba.Location = new System.Drawing.Point(20, 212);
            this.labelProba.Name = "labelProba";
            this.labelProba.Size = new System.Drawing.Size(151, 13);
            this.labelProba.TabIndex = 7;
            this.labelProba.Text = "Probabilité de mines par case :";
            // 
            // trackBarProba
            // 
            this.trackBarProba.Location = new System.Drawing.Point(20, 228);
            this.trackBarProba.Maximum = 20;
            this.trackBarProba.Minimum = 1;
            this.trackBarProba.Name = "trackBarProba";
            this.trackBarProba.Size = new System.Drawing.Size(300, 45);
            this.trackBarProba.TabIndex = 6;
            this.trackBarProba.Value = 3;
            this.trackBarProba.ValueChanged += new System.EventHandler(this.trackBarProba_ValueChanged);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnuler.Location = new System.Drawing.Point(23, 279);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 8;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonSauvegarder
            // 
            this.buttonSauvegarder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSauvegarder.Location = new System.Drawing.Point(220, 279);
            this.buttonSauvegarder.Name = "buttonSauvegarder";
            this.buttonSauvegarder.Size = new System.Drawing.Size(100, 23);
            this.buttonSauvegarder.TabIndex = 9;
            this.buttonSauvegarder.Text = "Sauvegarder";
            this.buttonSauvegarder.UseVisualStyleBackColor = true;
            this.buttonSauvegarder.Click += new System.EventHandler(this.buttonSauvegarder_Click);
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 321);
            this.Controls.Add(this.buttonSauvegarder);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.labelProba);
            this.Controls.Add(this.trackBarProba);
            this.Controls.Add(this.labelTaille);
            this.Controls.Add(this.trackBarTaille);
            this.Controls.Add(this.labelLignes);
            this.Controls.Add(this.trackBarLignes);
            this.Controls.Add(this.labelColonnes);
            this.Controls.Add(this.trackBarColonnes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Preferences";
            this.Text = "Préférences du jeu";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarColonnes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLignes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTaille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarProba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarColonnes;
        private System.Windows.Forms.Label labelColonnes;
        private System.Windows.Forms.Label labelLignes;
        private System.Windows.Forms.TrackBar trackBarLignes;
        private System.Windows.Forms.Label labelTaille;
        private System.Windows.Forms.TrackBar trackBarTaille;
        private System.Windows.Forms.Label labelProba;
        private System.Windows.Forms.TrackBar trackBarProba;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonSauvegarder;
    }
}