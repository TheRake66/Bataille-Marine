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
    public partial class Victoire : Form
    {

        // -------------------------------------------------
        public Victoire(int nbMines,  int nbMinutes, int nbSecondes)
        {
            // Init
            InitializeComponent();
            // Affiche les stats
            this.richTextBoxText.Text = 
                @"Vous avez découvert les " + nbMines + " mine(s) en seulement " + nbMinutes + " minute(s) et " + nbSecondes + " seconde(s) !";
        }
        // -------------------------------------------------

        // -------------------------------------------------
        private void buttonFermer_Click(object sender, EventArgs e)
        {
            // Ferme
            this.Close();
        }
        // -------------------------------------------------

    }
}
