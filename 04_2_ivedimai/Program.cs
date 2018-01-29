using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_2_ivedimai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite simbolį: ");
            var zn = Console.ReadLine();

            Console.WriteLine("{0} {0} {0} {0}", zn);
            Console.WriteLine("{0} {0} {0} {0}", zn);
            Console.WriteLine("{0} {0} {0} {0}", zn);
            Console.WriteLine("{0} {0} {0} {0}", zn);
        }
    }
}
