using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpObjet
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture voitureTest = new Voiture();
            voitureTest.Couleur = "rouge";
            voitureTest.getCouleur();

            int vitesseVoiture = voitureTest.Vitesse = 50;
            Console.WriteLine(vitesseVoiture);
        }
    }
}
