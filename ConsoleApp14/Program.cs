using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int pasirinkimas;

            do
            {
                Console.WriteLine("1 - laptopas, 2 -  stacionarus");
                pasirinkimas = Convert.ToInt32(Console.ReadLine());

                if (pasirinkimas < 1 || pasirinkimas > 2)
                {
                    Console.WriteLine("blogai įvestas skaičius");
                }
            }
            while (pasirinkimas < 1 || pasirinkimas > 2);

            Console.WriteLine("pasirinkimas: " + pasirinkimas);
        }
    }
}
