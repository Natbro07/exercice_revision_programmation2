using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsRevisionPO2
{
    internal class Inventaire
    {
        public List<Livre> livres{  get; }
        public Inventaire() 
        { 
        livres = new List<Livre>();


        } 
        public void AjouterLivre(Livre livre)
        {
            livres.Add(livre);
        }
    }
}
