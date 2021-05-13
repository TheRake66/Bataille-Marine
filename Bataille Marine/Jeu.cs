using Bataille_Marine.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bataille_Marine
{
    public partial class Jeu : Form
    {

        // -------------------------------------------------
        private PictureBox[,] plateau;
        private Random rnd = new Random();

        private bool[,] 
            mines, 
            verouiller, 
            decouvert;
        private int
            nbCols = 15,
            nbLigs = 15,
            taille = 30,
            probaParCase = 7, // (NbCols + Nbligne) / 2
            nbMines,
            nbSecondes,
            nbMinutes;

        private bool premierClick;
        // -------------------------------------------------



        // -------------------------------------------------
        public Jeu()
        {
            // Init
            InitializeComponent();
        }
        // -------------------------------------------------



        // -------------------------------------------------
        private void Jeu_Load(object sender, EventArgs e)
        {
            // Charge les cases au lancement
            chargerCases();
        }
        // -------------------------------------------------



        // -------------------------------------------------
        private void chargerCases()
        {
            // Efface les tableau et variable
            this.panelPlateau.Controls.Clear();
            this.plateau = new PictureBox[this.nbCols, this.nbLigs];
            this.decouvert = new bool[this.nbCols, this.nbLigs];
            this.verouiller = new bool[this.nbCols, this.nbLigs];
            this.premierClick = true;

            for (int i = 0; i < this.nbCols; i++)
            {
                for (int j = 0; j < this.nbLigs; j++)
                {
                    // Copie les adresse mem
                    int copyI = i, copyJ = j;

                    // Creer les images
                    PictureBox carre = new PictureBox();
                    carre.Size = new Size(this.taille, this.taille);
                    carre.Location = new Point(i * this.taille, j * this.taille);
                    carre.Image = Resources.carte;
                    carre.MouseClick += (s, e) =>
                    {
                        switch (e.Button)
                        {
                            // Decouvrir la case
                            case MouseButtons.Left:
                                decouvrirCase(copyI, copyJ);
                                break;
                            // Mettre un point d'interrogation
                            case MouseButtons.Middle:
                                interogationCase(copyI, copyJ);
                                break;
                            // Mettre une croix
                            case MouseButtons.Right:
                                minerCase(copyI, copyJ);
                                break;
                        }
                    };
                    this.panelPlateau.Controls.Add(carre);

                    this.plateau[i, j] = carre; // Defini le plateau d'image
                    this.decouvert[i, j] = false; // Defini le tableau des cases d'ecouverte
                    this.verouiller[i, j] = false;  // Defini le tableau des cases verouiller par une croix ou un point
                }
            }

            // Change le titre de la fenetre
            this.Text = "Bataille Marine - " + this.nbCols + " par " + this.nbLigs;
            // Change la taille de la fenetre
            this.ClientSize = new Size(
                this.taille * this.nbLigs, 
                this.taille * this.nbCols + this.menuStripBarre.Height + this.statusStripBarre.Height
                );

            // Reset et affiche les infos de la status barre
            this.toolStripStatusLabelRestantes.Text = "Cliquez dur une case pour démarrer le jeu";
        }
        // -------------------------------------------------



        // -------------------------------------------------
        private void placerMines(int colonne, int ligne)
        {
            // Reset les mines
            this.mines = new bool[this.nbCols, this.nbLigs];
            this.nbMines = 0;

            for (int i = 0; i < this.nbCols; i++)
            {
                for (int j = 0; j < this.nbLigs; j++)
                {
                    if (i != colonne && j != ligne)
                    {
                        // Defini les mines
                        if (rnd.Next(this.probaParCase) == rnd.Next(this.probaParCase))
                        {
                            this.mines[i, j] = true;
                            this.nbMines++;
                        }
                        else
                        {
                            this.mines[i, j] = false;
                        }
                    }
                }
            }

            // Reset et affiche les infos de la status barre
            ecrireLabelMines();
        }
        // -------------------------------------------------



        // -------------------------------------------------
        private int countNbVoisin(int colonne, int ligne)
        {
            int countmine = 0;

            // Ligne haut
            if (ligne - 1 >= 0)
            {
                if (colonne - 1 >= 0 && this.mines[colonne - 1, ligne - 1]) countmine++;
                if (this.mines[colonne, ligne - 1]) countmine++;
                if (colonne + 1 < this.nbCols && this.mines[colonne + 1, ligne - 1]) countmine++;
            }

            // Ligne milieu
            if (colonne - 1 >= 0 && this.mines[colonne - 1, ligne]) countmine++;
            if (colonne + 1 < this.nbCols && this.mines[colonne + 1, ligne]) countmine++;

            if (ligne + 1 < this.nbLigs)
            {
                // Ligne bas
                if (colonne - 1 >= 0 && this.mines[colonne - 1, ligne + 1]) countmine++;
                if (this.mines[colonne, ligne + 1]) countmine++;
                if (colonne + 1 < this.nbCols && this.mines[colonne + 1, ligne + 1]) countmine++;
            }

            return countmine;
        }
        // -------------------------------------------------



        // -------------------------------------------------
        private void placerNumVoisinAuto(int colonne, int ligne)
        {
            // Met la bonne image en comptant
            placerNumVoisin(countNbVoisin(colonne, ligne), colonne, ligne);
        }
        // -------------------------------------------------



        // -------------------------------------------------
        private void placerNumVoisin(int num, int colonne, int ligne)
        {
            // Met la bonne image
            Image img = null;
            if (num == 0) img = Resources.mer;
            else if (num == 1) img = Resources.un;
            else if (num == 2) img = Resources.deux;
            else if (num == 3) img = Resources.trois;
            else if (num == 4) img = Resources.quatre;
            else if (num == 5) img = Resources.cinq;
            else if (num == 6) img = Resources.six;
            else if (num == 7) img = Resources.sept;
            else if (num == 8) img = Resources.huit;
            this.plateau[colonne, ligne].Image = img;

            this.decouvert[colonne, ligne] = true;
        }
        // -------------------------------------------------



        // -------------------------------------------------
        private void decouvrirCase(int colonne, int ligne)
        {
            if (!this.verouiller[colonne, ligne] && !this.decouvert[colonne, ligne]) // Si case pas verouiller et pas decouverte
            {
                if (!this.premierClick)
                {
                    if (!this.mines[colonne, ligne])
                    {
                        normalDecouverte(colonne, ligne);
                    }
                    else
                    {
                        // Si clique sur mine
                        perdu();
                    }
                }
                else
                {
                    premiereDecouverte(colonne, ligne);
                }
            }
        }
        // -------------------------------------------------



        // -------------------------------------------------
        private void normalDecouverte(int colonne, int ligne)
        {
            // Son
            play(Resources.bulle);

            // Decouvre cette case
            placerNumVoisinAuto(colonne, ligne);

            expandCaseVide();
        }
        // -------------------------------------------------



        // -------------------------------------------------
        private void perdu()
        {
            // Son
            play(Resources.explosion1);
            for (int i = 0; i < this.nbCols; i++)
            {
                for (int j = 0; j < this.nbLigs; j++)
                {
                    if (!this.decouvert[i, j])
                    {
                        if (this.mines[i, j]) this.plateau[i, j].Image = Resources.mine;
                        else placerNumVoisinAuto(i, j);
                    }
                }
            }
        }
        // -------------------------------------------------



        // -------------------------------------------------
        private void premiereDecouverte(int colonne, int ligne)
        {
            // Place les mine
            placerMines(colonne, ligne);

            // Decouvre cette case
            normalDecouverte(colonne, ligne);

            // Lance le jeu
            this.premierClick = false;
            this.nbSecondes = 0;
            this.nbMinutes = 0;
        }
        // -------------------------------------------------



        // -------------------------------------------------
        private void expandCaseVide()
        {
            int nbModif = 0, lastModif = 0;

            do
            {
                lastModif = nbModif;
                nbModif = 0;

                for (int i = 0; i < this.nbCols; i++)
                {
                    for (int j = 0; j < this.nbLigs; j++)
                    {
                        Console.WriteLine(nbModif.ToString());
                        if (this.decouvert[i, j] && countNbVoisin(i, j) == 0)
                        {
                            // Ligne haut
                            if (j - 1 >= 0)
                            {
                                if (i - 1 >= 0 && this.mines[i - 1, j - 1]) placerNumVoisinAuto(i - 1, j - 1); nbModif++;
                                if (!this.mines[i, j - 1]) placerNumVoisinAuto(i, j - 1); nbModif++;
                                if (i + 1 < this.nbCols && this.mines[i + 1, j - 1]) placerNumVoisinAuto(i + 1, j - 1); nbModif++;
                            }

                            // Ligne milieu
                            if (i - 1 >= 0 && !this.mines[i - 1, j]) placerNumVoisinAuto(i - 1, j); nbModif++;
                            if (i + 1 < this.nbCols && !this.mines[i + 1, j]) placerNumVoisinAuto(i + 1, j); nbModif++;

                            if (j + 1 < this.nbLigs)
                            {
                                // Ligne bas
                                if (i - 1 >= 0 && !this.mines[i - 1, j + 1]) placerNumVoisinAuto(i - 1, j + 1); nbModif++;
                                if (!this.mines[i, j + 1]) placerNumVoisinAuto(i, j + 1); nbModif++;
                                if (i + 1 < this.nbCols && !this.mines[i + 1, j + 1]) placerNumVoisinAuto(i + 1, j + 1); nbModif++;
                            }
                        }
                    }
                }

            } while (nbModif > lastModif);
        }
        // -------------------------------------------------



        // -------------------------------------------------
        private void interogationCase(int colonne, int ligne)
        {
            PictureBox carre = this.plateau[colonne, ligne];
            if (!this.decouvert[colonne, ligne]) // Si case pas decouverte
            {
                play(Resources.papier);
                if (this.verouiller[colonne, ligne]) // Si verouiller
                {
                    // Deverouille
                    carre.Image = Resources.carte;
                    this.verouiller[colonne, ligne] = true;
                }
                else
                {
                    // Verouille
                    carre.Image = Resources.point;
                    this.verouiller[colonne, ligne] = false;
                }
            }
        }
        // -------------------------------------------------



        // -------------------------------------------------
        private void minerCase(int colonne, int ligne)
        {
            PictureBox carre = this.plateau[colonne, ligne];
            if (!this.decouvert[colonne, ligne] && this.nbMines > 0) // Si case pas decouverte et qu'il reste des mines
            {
                play(Resources.papier);
                if (this.verouiller[colonne, ligne]) // Si verouiller
                {
                    // Deverouille
                    carre.Image = Resources.carte;
                    this.verouiller[colonne, ligne] = false;
                    this.nbMines++;
                }
                else
                {
                    // Verouille
                    carre.Image = Resources.croix;
                    this.verouiller[colonne, ligne] = true;
                    this.nbMines--;
                }
                ecrireLabelMines(); // Actualise le label des mines
            }
        }
        // -------------------------------------------------



        // -------------------------------------------------
        private void ecrireLabelMines()
        { 
            // Actualise le label des mines
            this.toolStripStatusLabelRestantes.Text = "Mines restantes : " + this.nbMines.ToString();
        }
        // -------------------------------------------------



        // -------------------------------------------------
        private void timerHorloge_Tick(object sender, EventArgs e)
        {
            // Systeme horloge
            if (this.nbSecondes == 59)
            {
                this.nbMinutes++;
                this.nbSecondes = 0;
            }
            else
            {
                this.nbSecondes++;
            }

            // Actualise le label de l'horloge
            this.toolStripStatusLabelTime.Text = 
                (this.nbMinutes < 10 ? "0" : "") + this.nbMinutes.ToString() + " : " +
                (this.nbSecondes < 10 ? "0" : "") + this.nbSecondes.ToString();
        }
        // -------------------------------------------------



        // -------------------------------------------------
        private void play(UnmanagedMemoryStream ressource)
        {
            // Joue async
            using (SoundPlayer snd = new SoundPlayer(ressource)) snd.Play();
        }
        // -------------------------------------------------

    }
}
