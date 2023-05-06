using System;
using System.Drawing;
using System.Windows.Forms;

namespace J_GUN_Projet_CSharp
{
    public partial class Form1 : Form
    {
        int cpt;
        int max_recul = 0;
        int[] positionXY = new int[2];
        /*  Taille de l'échiquier */
        int largeur_case = 45;
        int position_plateau = 45;
        int taille_plateau = 8;
        /*  Déplacement possible du cavalier */
        int[,] deplacements = new int[,] { { 2, 1 }, { 2, -1 }, { -2, 1 }, { -2, -1 }, { 1, 2 }, { -1, 2 }, { 1, -2 }, { -1, -2 } };
        /*  Initialisation de la fonction Button dans un tableau vide */
        private Button[,] grille;
        /*  Initialisation de la fonction Image   */
        private Image i_Chevalier;
        /*  Initialisation de la graine pour la fonction Random   */
        Random rand = new Random();
        private Form2 fille;
        public Form1()
        {
            InitializeComponent();
            this.fille = new Form2(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cpt = -1;
            button1.Visible = false;
            button2.Text = "Départ Aléatoire";
            button2.Width = 130;
            button2.Height = 50;
            button3.Text = "Rejouer !";
            button3.Width = 130;
            button3.Height = 50;
            button4.Text = "Simulation";
            button4.Width = 130;
            button4.Height = 50;
            button5.Text = "Revenir en arrière";
            button5.Width = 130;
            button5.Height = 50;
            /*  Chargement de l'image du pion   */
            i_Chevalier = Image.FromFile("images\\chess-piece-knight.jpg");

            /*  Chargement du plateau de jeu */
            grille = new Button[taille_plateau, taille_plateau];
            Button b = new Button();
            for (int i = 0; i < grille.GetLength(0); i++)
            {
                for (int j = 0; j < grille.GetLength(0); j++)
                {
                    b = new Button();
                    b.Location = new Point(i * largeur_case + position_plateau, j * largeur_case + position_plateau);
                    b.Size = new Size(largeur_case, largeur_case);
                    b.Text = "";
                    if (((i % 2 == 0) && (j % 2 != 0)) || (i % 2 != 0) && (j % 2 == 0))
                        b.BackColor = Color.DarkGray;
                    b.Click += new EventHandler(this.button1_Click);
                    b.MouseEnter += new EventHandler(this.button1_MouseEnter);
                    b.MouseLeave += new EventHandler(this.button1_MouseLeave);
                    this.Controls.Add(b);
                    grille[i, j] = b;
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button b;
                b = sender as Button;
                if (cpt < 0)
                {
                    b.BackgroundImage = i_Chevalier;
                    b.BackgroundImageLayout = ImageLayout.Stretch;
                    cpt++;
                    positionXY = TrouverPosition(grille);
                }
                else if (b.BackColor == Color.Red)
                {
                    positionXY = TrouverPosition(grille);
                    b.BackgroundImage = i_Chevalier;
                    b.BackgroundImageLayout = ImageLayout.Stretch;
                    cpt++;
                    grille[positionXY[0], positionXY[1]].BackgroundImage = null;
                    grille[positionXY[0], positionXY[1]].Text = cpt.ToString();
                    grille[positionXY[0], positionXY[1]].Enabled = false;
                    max_recul = 0;
                }
                button2.Enabled = false;
            }
        }

        /**********************************************************************/
        /*     Fonction pour repérer les déplacements possible du pion    */
        /**********************************************************************/
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            for (int i = 0; i < grille.GetLength(0); i++)
            {
                for (int j = 0; j < grille.GetLength(0); j++)
                {
                    if (grille[i, j].BackgroundImage != null)
                    {
                        for (int k = 0; k < deplacements.GetLength(0); k++)
                        {
                            int newX = i + deplacements[k, 0];
                            int newY = j + deplacements[k, 1];

                            if (newX >= 0 && newX < grille.GetLength(0) && newY >= 0 && newY < grille.GetLength(1))
                            {
                                grille[newX, newY].BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
        }

        /**********************************************************************/
        /*  Fonction pour ne plus repérer les déplacements possible du pion   */
        /**********************************************************************/
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            for (int i = 0; i < taille_plateau; i++)
            {
                for (int j = 0; j < taille_plateau; j++)
                {
                    if (((i % 2 == 0) && (j % 2 != 0)) || (i % 2 != 0) && (j % 2 == 0))
                        grille[i, j].BackColor = Color.DarkGray;
                    else
                        grille[i, j].BackColor = Color.White;
                }
            }
        }

        /**********************************************************************/
        /*  Bouton de départ Aléatoire     */
        /**********************************************************************/
        private void button2_Click(object sender, EventArgs e)
        {
            int i_Aleatoire = rand.Next(0, 8);
            int j_Aleatoire = rand.Next(0, 8);
            grille[i_Aleatoire, j_Aleatoire].BackgroundImage = i_Chevalier;
            grille[i_Aleatoire, j_Aleatoire].BackgroundImageLayout = ImageLayout.Stretch;
            cpt++;
            positionXY = TrouverPosition(grille);
            button2.Enabled = false;
        }


        /**********************************************************************/
        /*          Bouton Rejouer           */
        /**********************************************************************/
        private void button3_Click(object sender, EventArgs e)
        {
            for (int l = 0; l < grille.GetLength(0); l++)
                for (int c = 0; c < grille.GetLength(0); c++)
                {
                    grille[l, c].Text = "";
                    grille[l, c].Enabled = true;
                    grille[l, c].BackgroundImage = null;
                    if (((l % 2 == 0) && (c % 2 != 0)) || (l % 2 != 0) && (c % 2 == 0))
                        grille[l, c].BackColor = Color.DarkGray;
                    else
                        grille[l, c].BackColor = Color.White;
                }
            button2.Enabled = true;
            cpt = -1;
        }

        /**********************************************************************/
        /*                   Bouton Simulation              */
        /**********************************************************************/
        private void button4_Click(object sender, EventArgs e)
        {
            fille.Show();
        }

        /**********************************************************************/
        /*             Bouton revenir sur ses pas            */
        /**********************************************************************/
        private void button5_Click(object sender, EventArgs e)
        {
            int i, j;
            int n = cpt - 1;
            positionXY = TrouverPosition(grille);
            if (positionXY == null)
                MessageBox.Show("Choisssisez une case de départ");
            else
            {
                for (int l = 0; l < deplacements.GetLength(0); l++)
                {
                    i = positionXY[0] + deplacements[l, 0];
                    j = positionXY[1] + deplacements[l, 1];
                    if (i >= 0 && i < grille.GetLength(0) && j >= 0 && j < grille.GetLength(1))
                    {
                        if (grille[i, j].Enabled == false && grille[i, j].Text.Equals(cpt.ToString()) && max_recul < 5 && cpt > 0)
                        {
                            grille[i, j].BackgroundImage = i_Chevalier;
                            grille[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                            grille[i, j].Text = "";
                            grille[i, j].Enabled = true;
                            grille[positionXY[0], positionXY[1]].Text = "";
                            grille[positionXY[0], positionXY[1]].Enabled = true;
                            grille[positionXY[0], positionXY[1]].BackgroundImage = null;
                            max_recul++;
                            cpt--;
                        }
                    }
                }
            }

        }

        int[] TrouverPosition(Button[,] grille)
        {
            int[] position = new int[2];
            for (int i = 0; i < grille.GetLength(0); i++)
            {
                for (int j = 0; j < grille.GetLength(0); j++)
                {
                    if (grille[i, j].BackgroundImage != null)
                    {
                        position[0] = i; // la première valeur correspond à la position X
                        position[1] = j; // la deuxième valeur correspond à la position Y
                        return position;
                    }
                }
            }
            return null;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void règlesDuJeuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Le jeu consiste à faire parcourir à un cavalier l'ensemble de l'échiquier sans passer deux fois sur la même case.\n"
                + "2. Le cavalier peut se déplacer sur l'une des 8 cases qui vont s'afficher en rouge.\n"
                + "3. Il y aura deux boutons : un pour choisir les coordonnées de départ et un autre pour tirer au sort les coordonnées de départ.");
        }

        private void conseilsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La méthode utilisée pour le déplacement du cavalier est basée sur une heuristique due à Euler : choisir comme case de fuite, " +
                "en partant de l'étape N, la case de l'étape N+1 qui, à l'étape N+2, présente le MINIMUM de case de fuites possibles." +
                "Vous pouvez aussi vous rabattre sur la simulation qui vous donne la solution au problème.");
        }

        private void àProposDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void couleursDeFondToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        private void couleursDesBoutonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            button2.BackColor = colorDialog1.Color;
            button3.BackColor = colorDialog1.Color;
            button4.BackColor = colorDialog1.Color;
            button5.BackColor = colorDialog1.Color;
        }
    }
}
