using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite atsitiktinį skaičių: ");

            var skaicius = Convert.ToInt32(Console.ReadLine());

            while (skaicius%9 == 0)
            {

                skaicius = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine("Jus ivedete skaiciu, kuris yra lygus " + skaicius);
        }
    }
}
