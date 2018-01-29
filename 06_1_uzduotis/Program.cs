using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _06_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite, bet kokį teigiamą skaičių:");

            var teigiamas = Convert.ToInt16(Console.ReadLine());

            if (teigiamas < 0)
            {
                Console.WriteLine("Eik tu avino šmots!");
            }
            if (teigiamas > 0)
            {
                Console.WriteLine("Nu gudras!");
            }
            if (teigiamas % 2 == 0)
            {
                Console.WriteLine("Lyginis skaičius");
            }
            if (teigiamas % 4 == 0)
            {
                Console.WriteLine("Dalinas iš keturių");
            }
            if (teigiamas > 10)
            {
                Console.WriteLine("Daugiau už 10");
            }
            Console.Read();
        }
    }
}
