namespace WinFormsRevisionPO2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PersonnesListBox = new ListBox();
            buttonAugmenterAge = new Button();
            SuspendLayout();
            // 
            // PersonnesListBox
            // 
            PersonnesListBox.FormattingEnabled = true;
            PersonnesListBox.ItemHeight = 15;
            PersonnesListBox.Location = new Point(350, 131);
            PersonnesListBox.Name = "PersonnesListBox";
            PersonnesListBox.Size = new Size(120, 94);
            PersonnesListBox.TabIndex = 0;
            PersonnesListBox.SelectedValueChanged += PersonnesListBox_SelectedValueChanged;
            // 
            // buttonAugmenterAge
            // 
            buttonAugmenterAge.Location = new Point(339, 266);
            buttonAugmenterAge.Name = "buttonAugmenterAge";
            buttonAugmenterAge.Size = new Size(148, 23);
            buttonAugmenterAge.TabIndex = 1;
            buttonAugmenterAge.Text = "augmenter l'âge";
            buttonAugmenterAge.UseVisualStyleBackColor = true;
            buttonAugmenterAge.Click += buttonAugmenterAge_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAugmenterAge);
            Controls.Add(PersonnesListBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox PersonnesListBox;
        private Button buttonAugmenterAge;
    }
}
