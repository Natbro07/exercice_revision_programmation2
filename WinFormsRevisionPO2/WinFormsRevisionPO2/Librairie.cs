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
    public partial class Librairie : Form
    {
        public Librairie()
        {
            InitializeComponent();
        }

        private void Librairie_Load(object sender, EventArgs e)
        {

        }

        private void buttonAjouterLivre_Click(object sender, EventArgs e)
        {
            string titre = textBoxTitre.Text;
            string auteur = textBoxAuteur.Text;
            int prix = int.Parse(textBoxPrix.Text); 
            int quantiteInventaire = int.Parse(textBoxQuantiteInventaire.Text);
            Livre livre = new Livre(titre,auteur,prix, quantiteInventaire);
            if (textBoxTitre.Text != "" && textBoxAuteur.Text != "" && prix >0 && quantiteInventaire>=0 )
            {
                listBoxInventaire.Items.Add(livre);
            }
        }
    }
}
