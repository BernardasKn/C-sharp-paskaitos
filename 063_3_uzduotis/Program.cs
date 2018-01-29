using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _063_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pasirinkite gėrimą: 1 - vanduo, 2 - kava, 3 - arbata");

            var gerimas = Convert.ToInt16(Console.ReadLine());

            switch (gerimas)
            {
                case 1:
                    Console.WriteLine("Jūs pasirinkote vandenį");
                    break;

                case 2:
                    Console.WriteLine("Jūs pasirinkote kavą");
                    break;

                default:
                    Console.WriteLine("Jūs pasirinkote arbatą");
                    break;
            }
        }
    }
}
