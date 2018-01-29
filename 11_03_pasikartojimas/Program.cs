using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_03_pasikartojimas
{
    class Program
    {
        static void Main(string[] args)
        {
            /* leisti varotojui pasirinkti kiek duomenu ivesti.
            suvesati duomenis i masyva, rasti: viduki, min, max, suma.
            Atlikti atrinkima i kita masyva duomenu, kur tenkina sia salyga: 
            visos temperaturos daugiau uz vidurki.
            Abieju masyvu duomenis isvesti. Is atrinku temperaturu masyvo rasti vidurki*/

            Console.WriteLine("Kiek temperaturu norite suvesti?");
            var kiek = Convert.ToInt32(Console.ReadLine());

            var temperaturos = new int[kiek];

            for (int i = 0; i < kiek; i++)
            {
                Console.WriteLine("Iveskite {0}-aja temp: ", i+1);
                temperaturos[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("IVESTI DUOMENYS");

            foreach (var temperatura in temperaturos)
            {
                Console.Write("[{0}] ", temperatura);
            }
            Console.WriteLine();

            //suma

            var suma = 0;

            foreach (var temp in temperaturos)
            {
                suma += temp;
            }
            Console.WriteLine("suma: " + suma);

            // vidurkis

            var vidurkis = (double)suma / temperaturos.Length;

            Console.WriteLine("vidurkis: " + Math.Round(vidurkis, 2)); // apvalins 2 skaicius po kablelio

            // maziausia temperatura

            var maziausias = temperaturos[0];

            foreach (var temp in temperaturos)
            {
                if (temp < maziausias)
                {
                    maziausias = temp;
                }
            }
            Console.WriteLine("maziausia: " + maziausias);

            // maziausia temperatura

            var didziausias = 0;

            foreach (var temp in temperaturos)
            {
                if (temp > didziausias)
                {
                    didziausias = temp;
                }
            }
            Console.WriteLine("didziausia: " + didziausias);

            //Atrinkimas 
            //temperaturos, kurios yra didesnes uz vidurki


            var atrinkta = new int[kiek];
            var kiekAtrinkta = 0;

            foreach (var temp in temperaturos)
            {
                if (temp > vidurkis)
                {
                    atrinkta[kiekAtrinkta] = temp;
                    kiekAtrinkta++;
                }
            }

            Console.WriteLine("Atrinkti duomenys");

            for (int i = 0; i < kiekAtrinkta; i++)
            {
                Console.Write("[{0}] ", atrinkta[i]);
            }

            Console.WriteLine();
        }
    }
}
