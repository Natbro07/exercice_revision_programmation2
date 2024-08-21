using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsRevisionPO2
{
    internal class Livre
    {
        private string titre;
        private string auteur;
        private int quantiteInventaire;
        private int prix;

        public Livre(string titre, string auteur, int quantiteInventaire, int prix)
        {
            Titre = titre;
            Auteur = auteur;
            QuantiteInventaire = quantiteInventaire;
            Prix = prix;
        }

        public string Titre { get => titre; set => titre = value; }
        public string Auteur { get => auteur; set => auteur = value; }
        public int QuantiteInventaire { get => quantiteInventaire; set => quantiteInventaire = value; }
        public int Prix { get => prix; set => prix = value; }

        public override string? ToString()
        {
            return Titre.ToString()+" " + Auteur.ToString() + " "+ QuantiteInventaire.ToString() +" "+ Prix.ToString();
        }
    }
}
