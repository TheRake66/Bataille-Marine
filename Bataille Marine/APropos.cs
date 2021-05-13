using Bataille_Marine.Properties;
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
    public partial class APropos : Form
    {

        // -------------------------------------------------
        private Random rnd = new Random();
        // -------------------------------------------------



        // -------------------------------------------------
        public APropos()
        {
            InitializeComponent();
        }
        // -------------------------------------------------



        // -------------------------------------------------
        private void buttonFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // -------------------------------------------------



        // -------------------------------------------------
        private void timerAnim_Tick(object sender, EventArgs e)
        {
            int x = this.pictureBoxLogo.Location.X;

            if (x < this.Width) x++;
            else
            {
                x = -this.pictureBoxLogo.Width;

                // Met une image random
                Image img = null;
                int num = this.rnd.Next(6);
                if (num == 0) img = Resources.un;
                else if (num == 1) img = Resources.carte;
                else if (num == 2) img = Resources.croix;
                else if (num == 3) img = Resources.point;
                else if (num == 4) img = Resources.mine;
                else if (num == 5) img = Resources.explosion;
                this.pictureBoxLogo.Image = img;
            }

            this.pictureBoxLogo.Location = new Point(x, this.pictureBoxLogo.Location.Y);
        }
        // -------------------------------------------------

    }
}
