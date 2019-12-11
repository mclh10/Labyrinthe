using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Table : Materiel
    {
        private int hauteur;
        private int nbPieds;

        public int Hauteur
        {
            get => hauteur;
            set => hauteur = value;
        }

        public int NbPieds
        {
            get => nbPieds;
            set => nbPieds = value;
        }


        public override void SeDecrire()
        {

        }
    }
}
