using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpObjet
{
    public class Voiture
    {
        public string Couleur;
        private int vitessePrivee;

        public int Vitesse
        {
            get
            {
                return vitessePrivee;
            }
            set
            {
                vitessePrivee = value;
            }
        }

        public void getCouleur()
        {
            Console.WriteLine(this.Couleur);
        }

        public void Kalxonner()
        {
            Console.WriteLine("Pouet !");
        }
    }
}
