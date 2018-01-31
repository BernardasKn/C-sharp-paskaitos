using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_03_seima
{
    class Program
    {
        static void Main(string[] args)
        {
            var zmogus1 = new Zmogus(); // iskviecia ivedimo metoda aprasyta Zmogaus klaseje
            zmogus1.Isvedimas();


            var zmogus2 = new Zmogus("Jonas", "Petraits", 190, 50, 'v');
            zmogus2.Isvedimas();

            var seima1 = new Seima("Kaunas", new List<Zmogus>
            {
                new Zmogus("fhkdhfkdhf", "dfhkdhf", 12, 150, 'v'), // galima taip duomenis suvesti i sarasa
                new Zmogus("fhhkdf", "ddff", 80, 150, 'm')

            });

            /* new List<int>
             {
             41, 42 , 43
             
             };
              
             */

            var seima = new Seima();
            seima.Isvedimas();

        }
    }
}
