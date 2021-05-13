using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bataille_Marine
{
    public partial class Preferences : Form
    {

        // -------------------------------------------------
        public Preferences(int nbCols, int nbLigns, int taille, int proba)
        {
            // Init
            InitializeComponent();
            // Change les valeurs
            this.trackBarColonnes.Value = nbCols;
            this.trackBarLignes.Value = nbLigns;
            this.trackBarTaille.Value = taille;
            this.trackBarProba.Value = proba;
        }
        // -------------------------------------------------



        // -------------------------------------------------
        private void trackBarColonnes_ValueChanged(object sender, EventArgs e)
        {
            this.labelColonnes.Text = "Nombre de colonnes (actuel : " + this.trackBarColonnes.Value + ", défaut : 15) : ";
        }

        private void trackBarLignes_ValueChanged(object sender, EventArgs e)
        {
            this.labelLignes.Text = "Nombre de lignes (actuel : " + this.trackBarLignes.Value + ", défaut : 15) : ";
        }

        private void trackBarTaille_ValueChanged(object sender, EventArgs e)
        {
            this.labelTaille.Text = "Taille des cases en pixel (actuelle : " + this.trackBarTaille.Value + ", défaut : 30) : ";
        }

        private void trackBarProba_ValueChanged(object sender, EventArgs e)
        {
            this.labelProba.Text = "Probabilité de mines par case (actuelle : " + this.trackBarProba.Value + ", défaut : 7) : ";
        }
        // -------------------------------------------------



        // -------------------------------------------------
        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSauvegarder_Click(object sender, EventArgs e)
        {
            ((Jeu)this.Owner).changerPreference(
                this.trackBarColonnes.Value,
                this.trackBarLignes.Value,
                this.trackBarTaille.Value,
                this.trackBarProba.Value
                );
            this.Close();
        }
        // -------------------------------------------------

    }
}
