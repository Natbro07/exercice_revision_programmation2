namespace WinFormsRevisionPO2
{
    partial class RectangleForm
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
            textBoxLongueur = new TextBox();
            textBoxLargeur = new TextBox();
            listBoxRectangle = new ListBox();
            longueurLabel = new Label();
            largeurLabel = new Label();
            calculerButton = new Button();
            SuspendLayout();
            // 
            // textBoxLongueur
            // 
            textBoxLongueur.Location = new Point(279, 190);
            textBoxLongueur.Name = "textBoxLongueur";
            textBoxLongueur.Size = new Size(49, 23);
            textBoxLongueur.TabIndex = 0;
            // 
            // textBoxLargeur
            // 
            textBoxLargeur.Location = new Point(279, 238);
            textBoxLargeur.Name = "textBoxLargeur";
            textBoxLargeur.Size = new Size(49, 23);
            textBoxLargeur.TabIndex = 1;
            // 
            // listBoxRectangle
            // 
            listBoxRectangle.FormattingEnabled = true;
            listBoxRectangle.ItemHeight = 15;
            listBoxRectangle.Location = new Point(334, 135);
            listBoxRectangle.Name = "listBoxRectangle";
            listBoxRectangle.Size = new Size(262, 169);
            listBoxRectangle.TabIndex = 2;
            // 
            // longueurLabel
            // 
            longueurLabel.AutoSize = true;
            longueurLabel.Location = new Point(218, 193);
            longueurLabel.Name = "longueurLabel";
            longueurLabel.Size = new Size(55, 15);
            longueurLabel.TabIndex = 3;
            longueurLabel.Text = "longueur";
            // 
            // largeurLabel
            // 
            largeurLabel.AutoSize = true;
            largeurLabel.Location = new Point(218, 241);
            largeurLabel.Name = "largeurLabel";
            largeurLabel.Size = new Size(44, 15);
            largeurLabel.TabIndex = 4;
            largeurLabel.Text = "largeur";
            // 
            // calculerButton
            // 
            calculerButton.Location = new Point(432, 327);
            calculerButton.Name = "calculerButton";
            calculerButton.Size = new Size(75, 23);
            calculerButton.TabIndex = 5;
            calculerButton.Text = "Calculer";
            calculerButton.UseVisualStyleBackColor = true;
            calculerButton.Click += calculerButton_Click;
            // 
            // RectangleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(calculerButton);
            Controls.Add(largeurLabel);
            Controls.Add(longueurLabel);
            Controls.Add(listBoxRectangle);
            Controls.Add(textBoxLargeur);
            Controls.Add(textBoxLongueur);
            Name = "RectangleForm";
            Text = "RectangleForm";
            Load += RectangleForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLongueur;
        private TextBox textBoxLargeur;
        private ListBox listBoxRectangle;
        private Label longueurLabel;
        private Label largeurLabel;
        private Button calculerButton;
    }
}