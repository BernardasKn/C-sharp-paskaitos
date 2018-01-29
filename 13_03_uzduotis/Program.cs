using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_03_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dienu temperaturos
            /* kuriamas sarasas, daromi metodai: ivedimui, isvedimui, visu skaiciavimu isvedimui,
             atrinkimui i nauja sarasa*/

            var temperatura = new List<int>();
            Program tempPrograma = new Program();

            tempPrograma.DuomIvedimas(temperatura);
            Console.WriteLine();
            tempPrograma.DuomIsvedimas(temperatura, "PARADINIAI DUOMENYS");
            Console.WriteLine();
            tempPrograma.Skaiciavimai(temperatura);
            Console.WriteLine();
            List<int> atrinkti = tempPrograma.Atrinkimas(temperatura);
            tempPrograma.DuomIsvedimas(atrinkti, "ATRINKTI DUOMENYS");
        }
        // ====================================== MAIN PABAIGA ================================
        public void DuomIvedimas(List<int> sarasasBase)
        {
            Console.Write("Kiek temperaturu norite ivesti? ");
            var kiek = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kiek; i++)
            {
                var temp = Convert.ToInt32(Console.ReadLine());
                sarasasBase.Add(temp);
            }
        }
        public void DuomIsvedimas(List<int> sarasasBase, string komentaras)
        {
            Console.WriteLine(komentaras);
            foreach (var temp in sarasasBase)
            {
                Console.WriteLine("[{0}]", temp);
            }
        }
        public int Suma(List<int> sarasasBase)
        {
            return sarasasBase.Sum();
        }
        public int Maziausia(List<int> sarasasBase)
        {
            return sarasasBase.Min();
        }
        public int Didziausia(List<int> sarasasBase)
        {
            return sarasasBase.Max();
        }
        public double Vidurkis(List<int> sarasasBase)
        {
            var vidurkis = (double)Suma(sarasasBase) / sarasasBase.Count;
            return vidurkis;
        }
        public void Skaiciavimai(List<int> sarasasBase)
        {
            Console.WriteLine("Suma: " + Suma(sarasasBase));
            Console.WriteLine("Min: " + Maziausia(sarasasBase));
            Console.WriteLine("Max: " + Didziausia(sarasasBase));
            Console.WriteLine("Vidurkis: " + Vidurkis(sarasasBase));
        }
        public List<int> Atrinkimas(List<int> pradiniai)
        {
            //daigiau nei 25, bus karsta
            var atrinkti = new List<int>();
            foreach (var temp in pradiniai)
            {
                if (temp > 25)
                {
                    atrinkti.Add(temp);
                }
            }
            return atrinkti;
        }


    }
}
