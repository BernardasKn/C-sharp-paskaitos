using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_02_pavyzdziai
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tema masinos

            var rida = new List<int>();
            Program programa = new Program();

            // metodai:

            // duomenu suvedimui

            programa.Ivedimas(rida);

            // duomenu isvedimui
            programa.Isvedimas(rida, "PARADINIAI DUOMENYS");

            // skaiciavimu iskvietimui, kuris iskvies siuos atskirus metodus
            // suma
            // min
            // max
            // vidurkis (vidurkis kviecia sumos metoda)
            programa.Skaiciavimai(rida);
            // atrinkimui i kita sarasa duomenu
            List<int> atrinkti = programa.Atrinkimas(rida);
            programa.Isvedimas(atrinkti, "ATRINKTI DUOMENYS");
            

        } // ==================================== MAIN PABAIGA ========================================

        public void Ivedimas(List<int> sarasas)
        {
            var dar = true;

            while (dar)
            {
                Console.WriteLine("Iveskite kilometraza: ");
                var km = Convert.ToInt32(Console.ReadLine());
                sarasas.Add(km);

                Console.WriteLine("norite kartoti? t/n");
                var kartoti = Console.ReadLine();
                if (kartoti != "t")
                {
                    dar = false;
                }
            }
        }

        public void Isvedimas(List<int> sarasas, string komentaras)
        {
            //isvesimas

            Console.WriteLine(komentaras);
            foreach (var km in sarasas)
            {
                Console.WriteLine("[{0}]", km);
            }


        }

        //sumos metodas aprasomas
        public int Suma(List<int> sarasas)
        {
            return sarasas.Sum();
        }
        //maziausio metodas
        public int Maziausias(List<int> sarasas)
        {
            return sarasas.Min();
        }
        //didziausio metodas
        public int Didziausias(List<int> sarasas)
        {
            return sarasas.Max();
        }
        //vidurkis
        public double Vidurkis(List<int> sarasas)
        {
            var vidurkis = (double)Suma(sarasas) / sarasas.Count;
            return vidurkis;
        }

        // metodas iskvietimui

        public void Skaiciavimai (List<int> sarasas)
        {
            Console.WriteLine("Suma: " + Suma(sarasas));
            Console.WriteLine("Min: " + Maziausias(sarasas));
            Console.WriteLine("Max: " + Didziausias(sarasas));
            Console.WriteLine("Vidurkis: " + Vidurkis(sarasas));
        }
        public List<int> Atrinkimas(List<int> pradiniai)
        {
            //daigiau nei 300k, laiksyims jau kaip lauza
            var atrinkti = new List<int>();
            foreach (var km in pradiniai)
            {
                if (km > 300000)
                {
                    atrinkti.Add(km);
                }
            }
            
            return atrinkti;
        }






    } // class pabaiga
}
