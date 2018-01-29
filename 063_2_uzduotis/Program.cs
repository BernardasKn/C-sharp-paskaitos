using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _063_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ar norite tęsti? (YES / NO)");

            string command = Console.ReadLine();

            switch (command.ToUpper())
            {
                case "YES":
                case "Y":
                    Console.WriteLine("Programa bus vykdoma");
                    break;

                case "NO":
                case "N":
                    Console.WriteLine("Programa nebebus vykdoma");
                    break;

                default:
                    Console.WriteLine("Bloga komanda");
                    break;
   
            }
            Console.Read();
        }
    }
}
