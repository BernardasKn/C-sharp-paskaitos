using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite simbolį, kad gautumėte jo kvadratą");
            var sim = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Pow(sim, 2));
        }
    }
}
