using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite tris skaičius:");

            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());
            var c = Convert.ToDouble(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Pirmas skaičius didesnis už antrą");
            }
            else if (b > c)
            {
                Console.WriteLine("Antras skaičius didesnis už trečią");
            }
            else if (c > a)
            {
                Console.WriteLine("Trečias skaičius didesnis už antrą");
            }
            Console.ReadLine();
        }
    }
}
