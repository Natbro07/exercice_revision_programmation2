using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsRevisionPO2
{
    public partial class RectangleForm : Form
    {
        public RectangleForm()
        {
            InitializeComponent();
        }

        private void calculerButton_Click(object sender, EventArgs e)
        {

            int largeur = int.Parse(textBoxLargeur.Text);
            int longueur = int.Parse(textBoxLongueur.Text);
            int air = largeur * longueur;
            int Perimetre = (2 * largeur) + (2 * longueur);

            if (textBoxLargeur.Text != "" && textBoxLongueur.Text != "")
            {
                listBoxRectangle.Items.Add("air: " + air);
                listBoxRectangle.Items.Add("perimetre : " + Perimetre);
            }

        }

        private void RectangleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
