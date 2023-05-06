
namespace J_GUN_Projet_CSharp
{
    partial class Form1
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.àProposDeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.règlesDuJeuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramètrageDuJeuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.couleursDeFondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.couleursDesBoutonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conseilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(609, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Départ Aléatoire";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(611, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "Rejouer !";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(611, 257);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 50);
            this.button4.TabIndex = 4;
            this.button4.Text = "Simulation";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(611, 357);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 50);
            this.button5.TabIndex = 5;
            this.button5.Text = "Revenir en arrière";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.àProposDeToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(818, 33);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // àProposDeToolStripMenuItem1
            // 
            this.àProposDeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.règlesDuJeuToolStripMenuItem,
            this.paramètrageDuJeuToolStripMenuItem,
            this.conseilsToolStripMenuItem});
            this.àProposDeToolStripMenuItem1.Name = "àProposDeToolStripMenuItem1";
            this.àProposDeToolStripMenuItem1.Size = new System.Drawing.Size(128, 29);
            this.àProposDeToolStripMenuItem1.Text = "&A propos de";
            this.àProposDeToolStripMenuItem1.Click += new System.EventHandler(this.àProposDeToolStripMenuItem1_Click);
            // 
            // règlesDuJeuToolStripMenuItem
            // 
            this.règlesDuJeuToolStripMenuItem.Name = "règlesDuJeuToolStripMenuItem";
            this.règlesDuJeuToolStripMenuItem.Size = new System.Drawing.Size(267, 34);
            this.règlesDuJeuToolStripMenuItem.Text = "Règles du jeu";
            this.règlesDuJeuToolStripMenuItem.Click += new System.EventHandler(this.règlesDuJeuToolStripMenuItem_Click);
            // 
            // paramètrageDuJeuToolStripMenuItem
            // 
            this.paramètrageDuJeuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.couleursDeFondToolStripMenuItem,
            this.couleursDesBoutonsToolStripMenuItem});
            this.paramètrageDuJeuToolStripMenuItem.Name = "paramètrageDuJeuToolStripMenuItem";
            this.paramètrageDuJeuToolStripMenuItem.Size = new System.Drawing.Size(267, 34);
            this.paramètrageDuJeuToolStripMenuItem.Text = "Paramètrage du jeu";
            // 
            // couleursDeFondToolStripMenuItem
            // 
            this.couleursDeFondToolStripMenuItem.Name = "couleursDeFondToolStripMenuItem";
            this.couleursDeFondToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.couleursDeFondToolStripMenuItem.Text = "Couleurs de fond";
            this.couleursDeFondToolStripMenuItem.Click += new System.EventHandler(this.couleursDeFondToolStripMenuItem_Click);
            // 
            // couleursDesBoutonsToolStripMenuItem
            // 
            this.couleursDesBoutonsToolStripMenuItem.Name = "couleursDesBoutonsToolStripMenuItem";
            this.couleursDesBoutonsToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.couleursDesBoutonsToolStripMenuItem.Text = "Couleurs des boutons";
            this.couleursDesBoutonsToolStripMenuItem.Click += new System.EventHandler(this.couleursDesBoutonsToolStripMenuItem_Click);
            // 
            // conseilsToolStripMenuItem
            // 
            this.conseilsToolStripMenuItem.Name = "conseilsToolStripMenuItem";
            this.conseilsToolStripMenuItem.Size = new System.Drawing.Size(267, 34);
            this.conseilsToolStripMenuItem.Text = "Conseils";
            this.conseilsToolStripMenuItem.Click += new System.EventHandler(this.conseilsToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(678, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 78);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 1050);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem àProposDeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem règlesDuJeuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramètrageDuJeuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conseilsToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem couleursDeFondToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couleursDesBoutonsToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

