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
            components = new System.ComponentModel.Container();
            buttonAjouterLivre = new Button();
            listBoxInventaire = new ListBox();
            textBoxTitre = new TextBox();
            textBoxAuteur = new TextBox();
            textBoxQuantiteInventaire = new TextBox();
            textBoxPrix = new TextBox();
            errorProviderAjoutDeLivre = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderAjoutDeLivre).BeginInit();
            SuspendLayout();
            // 
            // buttonAjouterLivre
            // 
            buttonAjouterLivre.Location = new Point(22, 140);
            buttonAjouterLivre.Name = "buttonAjouterLivre";
            buttonAjouterLivre.Size = new Size(138, 43);
            buttonAjouterLivre.TabIndex = 0;
            buttonAjouterLivre.Text = "Ajouter le livre";
            buttonAjouterLivre.UseVisualStyleBackColor = true;
            buttonAjouterLivre.Click += buttonAjouterLivre_Click;
            // 
            // listBoxInventaire
            // 
            listBoxInventaire.FormattingEnabled = true;
            listBoxInventaire.ItemHeight = 15;
            listBoxInventaire.Location = new Point(225, 14);
            listBoxInventaire.Name = "listBoxInventaire";
            listBoxInventaire.Size = new Size(232, 169);
            listBoxInventaire.TabIndex = 1;
            // 
            // textBoxTitre
            // 
            textBoxTitre.Location = new Point(22, 24);
            textBoxTitre.Name = "textBoxTitre";
            textBoxTitre.PlaceholderText = "Titre";
            textBoxTitre.Size = new Size(138, 23);
            textBoxTitre.TabIndex = 2;
            // 
            // textBoxAuteur
            // 
            textBoxAuteur.Location = new Point(22, 53);
            textBoxAuteur.Name = "textBoxAuteur";
            textBoxAuteur.PlaceholderText = "Auteur";
            textBoxAuteur.Size = new Size(138, 23);
            textBoxAuteur.TabIndex = 3;
            // 
            // textBoxQuantiteInventaire
            // 
            textBoxQuantiteInventaire.Location = new Point(22, 82);
            textBoxQuantiteInventaire.Name = "textBoxQuantiteInventaire";
            textBoxQuantiteInventaire.PlaceholderText = "Quantité";
            textBoxQuantiteInventaire.Size = new Size(138, 23);
            textBoxQuantiteInventaire.TabIndex = 4;
            // 
            // textBoxPrix
            // 
            textBoxPrix.Location = new Point(22, 111);
            textBoxPrix.Name = "textBoxPrix";
            textBoxPrix.PlaceholderText = "Prix";
            textBoxPrix.Size = new Size(138, 23);
            textBoxPrix.TabIndex = 5;
            // 
            // errorProviderAjoutDeLivre
            // 
            errorProviderAjoutDeLivre.ContainerControl = this;
            // 
            // Librairie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 220);
            Controls.Add(textBoxPrix);
            Controls.Add(textBoxQuantiteInventaire);
            Controls.Add(textBoxAuteur);
            Controls.Add(textBoxTitre);
            Controls.Add(listBoxInventaire);
            Controls.Add(buttonAjouterLivre);
            Name = "Librairie";
            Text = "Librairie";
            Load += Librairie_Load;
            ((System.ComponentModel.ISupportInitialize)errorProviderAjoutDeLivre).EndInit();
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
        private ErrorProvider errorProviderAjoutDeLivre;
    }
}