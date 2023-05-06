using System;
using System.Drawing;
using System.Windows.Forms;

namespace J_GUN_Projet_CSharp
{
    public partial class Form2 : Form
    {
        int cpt = 0;
        int[,] echec = new int[12, 12];
        int[] depi = new int[] { 2, 1, -1, -2, -2, -1, 1, 2 };
        int[] depj = new int[] { 1, 2, 2, 1, -1, -2, -2, -1 };
        int nb_fuite, min_fuite, lmin_fuite = 0;
        int k, l, i, j;
        int ii = 13;
        int jj = 13;
        bool start = false;
        private Form1 maman;
        int largeur_case = 45;
        int position_plateau = 45;
        int taille_plateau = 8;
        /*  Initialisation de la fonction Button dans un tableau vide */
        private Button[,] grille;
        public Form2(Form1 m)
        {
            InitializeComponent();
            this.maman = m;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Text = "Jeu";
            button2.Width = 130;
            button2.Height = 50;
            button3.Text = "Commencer !";
            button3.Width = 130;
            button3.Height = 50;
            button5.Text = "Départ Aléatoire";
            button5.Width = 130;
            button5.Height = 50;
            button6.Text = "Choix départ";
            button6.Width = 130;
            button6.Height = 50;
            button7.Text = "Recommencer";
            button7.Width = 130;
            button7.Height = 50;
            button8.Text = "Itinéraire-Non-stop";
            button8.Width = 130;
            button8.Height = 50;
            button9.Text = "Itinéraire-Par-Pas";
            button9.Width = 130;
            button9.Height = 50;
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
                    this.Controls.Add(b);
                    grille[i, j] = b;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /**********************************************************************/
        /*     Parcours du cavalier sur l'échiquier   */
        /**********************************************************************/
        private void button3_Click(object sender, EventArgs e)
        {
            if (start == true)
            {
                // Initialiser le tableau de jeu
                for (i = 0; i < 12; i++)
                    for (j = 0; j < 12; j++)
                        echec[i, j] = ((i < 2 | i > 9 | j < 2 | j > 9) ? -1 : 0);

                i = ii + 1;
                j = jj + 1;
                echec[i, j] = 1;

                for (k = 2; k <= 64; k++)
                {
                    for (l = 0, min_fuite = 11; l < 8; l++)
                    {
                        ii = i + depi[l];
                        jj = j + depj[l];

                        nb_fuite = ((echec[ii, jj] != 0) ? 10 : fuite(echec, depi, depj, ii, jj));


                        if (nb_fuite < min_fuite)
                        {
                            min_fuite = nb_fuite;
                            lmin_fuite = l;
                        }
                    }

                    if (min_fuite == 9 & k != 64)
                    {
                        MessageBox.Show("***   IMPASSE   ***");
                        break;
                    }

                    i += depi[lmin_fuite];
                    j += depj[lmin_fuite];
                    echec[i, j] = k;
                }
                MessageBox.Show("Choissisez une méthodé d'affichage");
            }
            else
                MessageBox.Show("Tu ne remplis pas les conditions de départ");
        }

        /**********************************************************************/
        /*     Fonction pour gérer le départ aléatoire    */
        /**********************************************************************/
        private void button5_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            ii = random.Next(1, 8);
            jj = random.Next(1, 8);
            start = true;
            MessageBox.Show("Valeurs de départ générées : " + ii + "," + jj
    + "\n Veuillez à appuyez sur commencer pour afficher la simulation");
        }

        /**********************************************************************/
        /*     Fonction pour gérer le choix du départ    */
        /**********************************************************************/
        private void button6_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(this.textBox1.Text, out taille_plateau) == true
                && Int32.TryParse(this.textBox2.Text, out taille_plateau) == true)
            {
                ii = int.Parse(textBox1.Text);
                jj = int.Parse(textBox2.Text);
                if ((ii < 1 || ii > 8) || (jj < 1 || jj > 8))
                    MessageBox.Show("Les valeurs ne correspondent pas à la place indiquée dans les régles");
                else
                {
                    start = true;
                    MessageBox.Show("Valeurs de départ choisies : " + ii + "," + jj
                        + "\n Veuillez à appuyez sur commencer pour afficher la simulation");

                }
            }

            else
                MessageBox.Show("UN ENTIER");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int l = 0; l < grille.GetLength(0); l++)
                for (int c = 0; c < grille.GetLength(0); c++)
                {
                    grille[l, c].Text = "";
                }
            k = 2;
            cpt = 0;
            start = false;
        }

        /**********************************************************************/
        /*     Fonction pour affichage directe    */
        /**********************************************************************/
        private void button8_Click(object sender, EventArgs e)
        {
            // Afficher le résultat sur le plateau de jeu
            if (echec[2, 2] == 0)
                MessageBox.Show("Lancer la simulation");
            else
            {
                for (i = 2; i < 10; i++)
                {
                    for (j = 2; j < 10; j++)
                    {
                        grille[i - 2, j - 2].Text = echec[i, j].ToString();
                    }
                }
            }
        }


        /**********************************************************************/
        /*     Fonction pour gérer le nombre de pas à l'affichage    */
        /**********************************************************************/
        private void button9_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(this.textBox3.Text, out taille_plateau) == true)
            {
                cpt += int.Parse(textBox3.Text);
                if (echec[2, 2] == 0)
                    MessageBox.Show("Lancer la simulation");
                else
                {
                    for (i = 2; i < 10; i++)
                    {
                        for (j = 2; j < 10; j++)
                        {
                            if (echec[i, j] <= cpt)
                                grille[i - 2, j - 2].Text = echec[i, j].ToString();
                        }
                    }
                }
            }

            else
                MessageBox.Show("UN ENTIER");
        }

        private void déroulementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1) Choisir le moyen de départ" +
                "\n 2) Lancer la simulation" +
                "\n 3) Afficher la simulation directement ou avec un nombre de pas" +
                "4) Recommencer ou revenir au jeu");
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            maman.Close();
        }

        /**********************************************************************/
        /*     Fonction de recherche du nombre de cases de fuite possibles    */
        /**********************************************************************/

        static int fuite(int[,] echec, int[] depi, int[] depj, int i, int j)
        {
            int n, l;

            for (l = 0, n = 8; l < 8; l++)
                if (echec[i + depi[l], j + depj[l]] != 0) n--;

            return (n == 0) ? 9 : n;
        }

        /**********************************************************************/
        /*     Fonctions vides    */
        /**********************************************************************/

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


    }
}

