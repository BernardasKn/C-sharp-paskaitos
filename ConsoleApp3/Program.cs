using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite du skaičius:");

            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Pirmas skaičius didesnis už antrą");
            }
            else if (a < b)
            {
                Console.WriteLine("Antras skaičius didesnis už pirmą");
            }
            else
            {
                Console.WriteLine("Skaičiai lygūs");
            }
            Console.Read();
        }
    }
}
