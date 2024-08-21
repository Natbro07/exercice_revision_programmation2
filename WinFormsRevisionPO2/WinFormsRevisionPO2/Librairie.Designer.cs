namespace WinFormsRevisionPO2
{
    partial class Librairie
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
            buttonAjouterLivre = new Button();
            listBoxInventaire = new ListBox();
            textBoxTitre = new TextBox();
            textBoxAuteur = new TextBox();
            textBoxQuantiteInventaire = new TextBox();
            textBoxPrix = new TextBox();
            titre = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // buttonAjouterLivre
            // 
            buttonAjouterLivre.Location = new Point(383, 98);
            buttonAjouterLivre.Name = "buttonAjouterLivre";
            buttonAjouterLivre.Size = new Size(112, 23);
            buttonAjouterLivre.TabIndex = 0;
            buttonAjouterLivre.Text = "Ajouter le livre";
            buttonAjouterLivre.UseVisualStyleBackColor = true;
            buttonAjouterLivre.Click += buttonAjouterLivre_Click;
            // 
            // listBoxInventaire
            // 
            listBoxInventaire.FormattingEnabled = true;
            listBoxInventaire.ItemHeight = 15;
            listBoxInventaire.Location = new Point(371, 151);
            listBoxInventaire.Name = "listBoxInventaire";
            listBoxInventaire.Size = new Size(232, 169);
            listBoxInventaire.TabIndex = 1;
            // 
            // textBoxTitre
            // 
            textBoxTitre.Location = new Point(227, 151);
            textBoxTitre.Name = "textBoxTitre";
            textBoxTitre.Size = new Size(100, 23);
            textBoxTitre.TabIndex = 2;
            // 
            // textBoxAuteur
            // 
            textBoxAuteur.Location = new Point(227, 200);
            textBoxAuteur.Name = "textBoxAuteur";
            textBoxAuteur.Size = new Size(100, 23);
            textBoxAuteur.TabIndex = 3;
            // 
            // textBoxQuantiteInventaire
            // 
            textBoxQuantiteInventaire.Location = new Point(227, 241);
            textBoxQuantiteInventaire.Name = "textBoxQuantiteInventaire";
            textBoxQuantiteInventaire.Size = new Size(100, 23);
            textBoxQuantiteInventaire.TabIndex = 4;
            // 
            // textBoxPrix
            // 
            textBoxPrix.Location = new Point(227, 286);
            textBoxPrix.Name = "textBoxPrix";
            textBoxPrix.Size = new Size(100, 23);
            textBoxPrix.TabIndex = 5;
            // 
            // titre
            // 
            titre.AutoSize = true;
            titre.Location = new Point(186, 151);
            titre.Name = "titre";
            titre.Size = new Size(30, 15);
            titre.TabIndex = 6;
            titre.Text = "Titre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 203);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 7;
            label2.Text = "Auteur";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 244);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 8;
            label3.Text = "Quantité en inventaire";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(183, 289);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 9;
            label4.Text = "Prix";
            // 
            // Librairie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(titre);
            Controls.Add(textBoxPrix);
            Controls.Add(textBoxQuantiteInventaire);
            Controls.Add(textBoxAuteur);
            Controls.Add(textBoxTitre);
            Controls.Add(listBoxInventaire);
            Controls.Add(buttonAjouterLivre);
            Name = "Librairie";
            Text = "Librairie";
            Load += Librairie_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAjouterLivre;
        private ListBox listBoxInventaire;
        private TextBox textBoxTitre;
        private TextBox textBoxAuteur;
        private TextBox textBoxQuantiteInventaire;
        private TextBox textBoxPrix;
        private Label titre;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}