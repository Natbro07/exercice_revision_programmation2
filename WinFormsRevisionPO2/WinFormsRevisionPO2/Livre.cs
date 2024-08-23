using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsRevisionPO2
{
    internal class Livre
    {
        public string Titre { get;  }
        public string Auteur { get ;  }
        public int QuantiteInventaire { get; }
        public int Prix { get;  }

        public Livre(string titre, string auteur, int quantiteInventaire, int prix)
        {
            Titre = titre;
            Auteur = auteur;
            QuantiteInventaire = quantiteInventaire;
            Prix = prix;
        }

       

        public override string? ToString()
        {
            return Titre.ToString()+" " + Auteur.ToString() + " "+ QuantiteInventaire.ToString() +" "+ Prix.ToString();
        }
    }
}
