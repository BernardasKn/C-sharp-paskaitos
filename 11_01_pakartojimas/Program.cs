using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_01_pakartojimas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            rasti visu skaciu is [10-100] reziu, kurie dalinasi is 3 suma
             */
            var suma = 0;

            for (int i = 10; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    suma += i;
                }
            }
            Console.WriteLine("suma: " + suma);

        }
    }
}
