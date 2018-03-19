using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpObjet
{
    public class Voiture
    {
        private int vitessePrivee;

        public string Couleur{ get; set; }

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

        public void Kalxonner()
        {
            Console.WriteLine("Pouet !");
        }
    }
}
