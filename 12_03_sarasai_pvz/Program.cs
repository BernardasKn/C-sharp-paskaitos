using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_03_sarasai_pvz
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Sugeneruokite atsitiktinio dydžio sąrašą, kurį užpildykite atsitiktiniais skaičiais nuo 1 iki 100. Raskite:
            1.1. mažiausią skaičių;
            1.2. didžiausią skaičių;
            1.3. vidurkį;
            1.4. kiek skaičių yra žemesni už vidurkį;
            1.5. lyginių skaičių sumą; */

            var atsitiktiniai = new List<int>(); //sukuriamas sarasas

            var atsitiktinis = new Random(); // random kintamasis

            
            var kiek = 14; //kiek skaiciu

            for (int i = 0; i < kiek; i++)
            {
                atsitiktiniai.Add(atsitiktinis.Next(1, 100)); //deda atsitiktinius skaicius i sarasa
            }

            Console.WriteLine("Isvedami atsitiktiniai skaiciai:");
            foreach (var skaicius in atsitiktiniai)
            {
                Console.Write(skaicius + ", ");
            }

            Console.WriteLine();

            var maziausias = atsitiktiniai.Min();
            var didziausias = atsitiktiniai.Max();
            var vidurkis = atsitiktiniai.Average();

            Console.WriteLine("maziausias: " + maziausias);
            Console.WriteLine("didziausias: " + didziausias);
            Console.WriteLine("vidurkis: " + vidurkis);

            // kiek skaiciu mazeni uz vidurki?

            var mazUzVid = new List<int>();
            foreach (var a in atsitiktiniai) // skaiciuojam
            {
                if (a < vidurkis)
                {
                    mazUzVid.Add(a);
                }
            }
            Console.WriteLine("mazesni uz vidurki");
            foreach (var a in mazUzVid) // isvedam
            {
                Console.Write(a + ", ");
            }

            Console.WriteLine();

            var kiekYraMazesniu = mazUzVid.Count();
            Console.WriteLine("Mazesniu uz vidurki yra: " + kiekYraMazesniu);

            Console.WriteLine();

            //rasti lyginiu skaiciu suma

            var lyginiai = new List<int>();
            foreach (var a in atsitiktiniai)
            {
                if (a%2 == 0)
                {
                    lyginiai.Add(a);
                }
            }
            Console.WriteLine("Lyginiai skaiciai sarase: ");
            foreach (var a in lyginiai)
            {
                Console.Write(a + ", ");
            }




        }
    }
}
