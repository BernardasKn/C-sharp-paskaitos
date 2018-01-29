using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_02_pasikartojimas
{
    class Program
    {
        static void Main(string[] args)
        {
            /* sudeti i masyva skaicius kurie dalinasi is 5 ir patenka i nurodytus rezius [30 - 150]. 
            Masyva isvesti graziai */

            var skaiciai = new int[120];
            var indeksas = 0; // kad masyvo duomenys butu is eiles, jei naudotume i indeksa, tai butu uzpildytas kas penktas langelis

            for (int i = 30; i <= 150; i++)
            {
                if (i % 5 == 0)
                {
                    skaiciai[indeksas] = i;
                    indeksas++;
                }
            }
            foreach (var skaicius in skaiciai)
            {
                Console.Write("[{0}]", skaicius);
            }
            Console.WriteLine();

            for (int i = 0; i < indeksas; i++)
            {
                Console.Write("[{0}]", skaiciai[i]);
            }
            Console.WriteLine();

            // rasti skaiciu suma, vidurki, didziausia, maziausia skaicius
            //is turimo masyvo

            //sumos paieska

            var suma = 0;

            for (int i = 0; i < indeksas; i++)
            {
                suma += skaiciai[i];
            }
            Console.WriteLine("suma: " + suma);

            //vidurkio paieska
            var vidurkis = (double)suma / indeksas;

            Console.WriteLine("vidurkis: " + vidurkis);

            //didžiausio skaiciau paieska

            var didziausias = skaiciai[indeksas-1];
            Console.WriteLine("didziausias: " + didziausias);

            //maziausio skaiciaus paieska

            var maziausias = skaiciai[0];

            Console.WriteLine("maziausias: " + maziausias);


            
        }
    }
}
