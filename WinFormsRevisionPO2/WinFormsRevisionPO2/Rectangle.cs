using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsRevisionPO2
{
    internal class Rectangle
    {
        private int longueur;
        private int largeur;
        private int air;
        private int perimetre;

        public Rectangle(int longueur, int largeur, int air, int perimetre)
        {
            Longueur = longueur;
            Largeur = largeur;
            Air = longueur *largeur;
            Perimetre =( 2* largeur)  + (2 *longueur) ;
        }

        public int Longueur { get => longueur; set => longueur = value; }
        public int Largeur { get => largeur; set => largeur = value; }
        public int Air { get => air; set => air = value; }
        public int Perimetre { get => perimetre; set => perimetre = value; }

        public override string? ToString()
        {
            return air.ToString()+ " "+ perimetre.ToString();
        }
    }
}
