using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskskite penkis savo pažymius:");

            var pirmas = Convert.ToDouble(Console.ReadLine());
            var antras = Convert.ToDouble(Console.ReadLine());
            var trečias = Convert.ToDouble(Console.ReadLine());
            var ketvirtas = Convert.ToDouble(Console.ReadLine());
            var penktas = Convert.ToDouble(Console.ReadLine());

            var vidurkis = (pirmas + antras + trečias + ketvirtas + penktas) / 5;

            if (vidurkis == 5)
            {
                Console.WriteLine("Vidurkis lygus 5");
            }
            if (vidurkis > 5)
            {
                Console.WriteLine("Vidukris daugiau už 5");
            }

        }
    }
}
