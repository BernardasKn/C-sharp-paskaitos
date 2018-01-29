using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite savo egzamino rezulatą (1-100):");

            var a = Convert.ToInt32(Console.ReadLine());
            if(a == 100)
            {
                Console.WriteLine("Puiku");
            }
            else if (a >= 80)
            {
                Console.WriteLine("Gerai");
            }
            else if (a >= 50)
            {
                Console.WriteLine("Silpnai");
            }
            else if (a >= 20)
            {
                Console.WriteLine("Blogai");
            }
            else if (a <= 20)
            {
                Console.WriteLine("Labai blogai");
            }
            Console.ReadLine();

        }
    }
}
