using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsRevisionPO2
{
    internal class Personne
    {
        public Personne(string nom, string prenom, int age)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
        }

        public string Nom { get;  }
        public string Prenom { get;  }
        public int Age { get; private set; }

        public int PersonneFeter(int age)
        {

        return age ++; 
        }

        public override string? ToString()
        {
            return Nom.ToString() +" "+  Prenom.ToString()+" " + Age;
        }
    }
}
