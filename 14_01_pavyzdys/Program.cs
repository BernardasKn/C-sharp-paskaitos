using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_01_pavyzdys
{
    // public PascalCase
    // private: _camelCase

    class Automobilis
    {
        // prop --> tabx 2

        public string Spalva { get; set; }
        public string Marke { get; set; }
        public string Modelis { get; set; }
        public int Rida { get; set; }
        public int Pavaros { get; set; }
        public double DarbinisTuris { get; set; }
        public int GaliaKw { get; set; }


        //ctor x2tab (turi buti klaseje)

        public Automobilis() //defoltinis turi buti
        {

        }

        public Automobilis(string spalva, string marke, string modelis, int rida, int pavaros, double darbinisTuris, int galiaKw)
        {
            Spalva = spalva; //jeigu vedame po lygybes is didziosios raides, tai pries kintamojo pavadinima turi buti "this. "
            Marke = marke;
            Modelis = modelis;
            Rida = rida;
            Pavaros = pavaros;
            DarbinisTuris = darbinisTuris;
            GaliaKw = galiaKw;
        }

        public void Isvedimas() // isvedimos metodas taip pat aprasomas klaseje
        {
            Console.WriteLine("Automobilio {0} {1} duomenys", Marke, Modelis); // is didziosios raides kaip ir klaseje
            Console.WriteLine("Rida: " + Rida);
            Console.WriteLine("Spalva: " + Spalva);
            Console.WriteLine("Pavaros: " + Pavaros);
            Console.WriteLine("Darbinis turis: " + DarbinisTuris);
            Console.WriteLine("Galia, kw: " + GaliaKw);
            Console.WriteLine();
        }

        public void Ivedimas()
        {
            Console.Write("Iveskite marke:  ");
            Marke = Console.ReadLine();
            Console.Write("Iveskite modeli:  ");
            Modelis = Console.ReadLine();
            Console.Write("Iveskite spalva:  ");
            Spalva = Console.ReadLine();
            Console.Write("Iveskite rida:  ");
            Rida = Convert.ToInt32(Console.ReadLine());
            Console.Write("Iveskite pavaras:  ");
            Pavaros = Convert.ToInt32(Console.ReadLine());
            Console.Write("Iveskite darbini turi:  ");
            //DarbinisTuris = Convert.ToDouble(Console.ReadLine());

            string darbTuris = Console.ReadLine();
            double darbTurisSk; // saugo skaiciu jei pavyks konvertuoti
            bool pavyko = double.TryParse(darbTuris, out darbTurisSk); //bandom konvertuoti, jei pavyksta bool pavyko = true
            if (pavyko) // jei pavyko
            {
                DarbinisTuris = darbTurisSk; // priskiriama nauja reiksme
            }
            else // jei nepavyko
            {
                DarbinisTuris = 0; // priskiam defolta
            }

            Console.Write("Iveskite galia:  ");
            Rida = Convert.ToInt32(Console.ReadLine());
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Automobilis automobilis = new Automobilis();
            automobilis.Marke = "opel";
            automobilis.Spalva = "juoda";
            automobilis.Modelis = "astra";
            automobilis.DarbinisTuris = 2.0;
            automobilis.Rida = 300000;
            automobilis.Pavaros = 5;
            automobilis.GaliaKw = 150;

            Console.WriteLine(automobilis.Marke);
            Console.WriteLine(automobilis.Modelis);
            Console.WriteLine(automobilis.Spalva);

            Console.WriteLine();
            automobilis.Isvedimas(); // panadojame isvedimo metoda

            var auto2 = new Automobilis
            {
                Marke = "ferari",
                Modelis = "jojo",
                Spalva = "raudona",
                DarbinisTuris = 4.5,
                Rida = 0,
                Pavaros = 6,
                GaliaKw = 300
            };

            Console.WriteLine(auto2.Marke);
            Console.WriteLine(auto2.Modelis);
            Console.WriteLine(auto2.Spalva);

            Console.WriteLine();
            auto2.Isvedimas(); // panaudojam isvedimo metoda auto2


            var auto3 = new Automobilis("raidona", "opelis", "astra", 2000, 6, 1.2, 80);
            Console.WriteLine(auto3.Marke);
            Console.WriteLine(auto3.Modelis);
            Console.WriteLine(auto3.Spalva);


            Console.WriteLine();
            auto3.Isvedimas(); // panaudojam isvedimo metoda auto3


            var auto4 = new Automobilis(); // auto panaudojan ivedimo ir isvedimo metodus
            auto4.Ivedimas();
            auto4.Isvedimas();
            
        }
    }
}
