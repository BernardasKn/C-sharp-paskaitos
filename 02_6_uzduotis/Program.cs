using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var marke = "Opel";
            var modelis = "Astra";
            var metai = 2005;
            var rida = 201501;

            Console.WriteLine("Automibilis {0} {1} ({2} m.) - {3} km.", marke, modelis, metai, rida);
        }
    }
}
