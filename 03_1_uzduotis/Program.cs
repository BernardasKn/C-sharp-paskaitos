using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius1 = 7;
            var skaicius2 = 5;

            Console.WriteLine("{0} + {1} = {2}", skaicius1, skaicius2, skaicius1 + skaicius2);
            Console.WriteLine("{0} - {1} = {2}", skaicius1, skaicius2, skaicius1 - skaicius2);
            Console.WriteLine("{0} * {1} = {2}", skaicius1, skaicius2, skaicius1 * skaicius2);
            Console.WriteLine("{0} / {1} = {2}", skaicius1, skaicius2, (double)skaicius1 / skaicius2);
            Console.WriteLine("{0} % {1} = {2}", skaicius1, skaicius2, skaicius1 % skaicius2);
        }
    }
}
