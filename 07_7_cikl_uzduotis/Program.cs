using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_7_cikl_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var atsakymas = 0;
            var pirmas = 2;
            var antras = 3;


            for (int i = 0; i < pirmas; i++)
            {
                atsakymas = atsakymas + antras;
            }
            Console.WriteLine("daugyba: " + atsakymas);
        }
    }
}
