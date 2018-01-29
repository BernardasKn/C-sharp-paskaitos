using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Išveskite visų įvestų skaičių sumą, skirtumą, sandaugą ir dalmenį");
            var sim = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Pow(sim, 2));
        }
    }
}
