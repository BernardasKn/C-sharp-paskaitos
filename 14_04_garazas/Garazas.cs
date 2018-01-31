using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_04_garazas
{
    class Garazas
    {
        // pavadinimas, adresas, meisru skaicius, automobiliu objektu sarasas
        public string Pavadinimas { get; private set; }
        public string Adresas { get; private set; }
        public int MeistruSkaicius { get; private set; }
        public List<Automobilis> Automobiliai { get; private set; }

        // pilnas konstruktorius - ctor
        public Garazas(string pavadinimas, string adresas, int meistruSkaicius, List<Automobilis> automobiliai)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            MeistruSkaicius = meistruSkaicius;
            Automobiliai = automobiliai;
        }

        // isvedimo metodas
        public void Isvedimas()
        {
            Console.WriteLine("Garazas {0} adresu {1} turi {2} meistru", Pavadinimas, Adresas, MeistruSkaicius);
            Console.WriteLine("Remontuojami automobiliai");
            /*foreach (var auto in Automobiliai)
            {
                auto.Isvedimas();
            }*/

            // naudosime for cikla kad sunumeruoti automobilius

            for (int i = 0; i < Automobiliai.Count; i++)
            {
                Console.Write(i+1 + " auto: ");
                Automobiliai[i].Isvedimas();
            }
        }

        public void AtnaudjintiPasirinkta()
        {
            Console.WriteLine("Kuri automobili keisti: ");
            var kuris = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kuri automobili keisti: ");
            Automobiliai[kuris - 1].Isvedimas();

            Console.WriteLine("1 - atsukti rida");
            Console.WriteLine("2 - perdazyti");
            Console.WriteLine("3 - didinti galia");

            var pasirinkimas = Convert.ToInt32(Console.ReadLine());

            switch (pasirinkimas)
            {
                case 1:
                    Automobiliai[kuris - 1].RidosAtsukimas();
                    break;
                case 2:
                    Automobiliai[kuris - 1].Perdazymas();
                    break;
                case 3:
                    Automobiliai[kuris - 1].GaliosKelimas();
                    break;
            }
            Console.WriteLine("Atnaujintas automobilis: ");
            Automobiliai[kuris - 1].Isvedimas();
        }
        public void Skaiciavimai() // cia isvesim visus skaiciavius
        {
            Console.WriteLine("SKAICIAVIMAI");
            Console.WriteLine("Bendra visu automobiliu rida {0} ", TotalRida());
        }

        public int TotalRida()
        {
            var sum = 0;
            foreach (var auto in Automobiliai)
            {
                sum += auto.Rida;
            }
            
            return sum;
        }




    }
}
