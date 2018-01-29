using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite tris skaičius:");

            var a = Convert.ToInt16(Console.ReadLine());
            var b = Convert.ToInt16(Console.ReadLine());
            var c = Convert.ToInt16(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("Pirmas skaičius didžiausias");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("Antras skaičius didžiausias");
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("Trečias skaičius didžiausias");
            }
            else
                Console.WriteLine("Bent du skaičiai yra lygūs");

            Console.Read();
        }
    }
}
