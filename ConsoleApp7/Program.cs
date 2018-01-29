using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fibonacio seka

            Console.Write("Kiek fibonačio sekos skaičių norite išvesti į ekraną?");
            var skaiciuKiekis = Convert.ToInt32(Console.ReadLine());

            int a = 1, b = 1, c = 0;

            Console.Write("{0} {1}", a, b);

            for (int i = 2; i <= skaiciuKiekis; i++)

            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;

            }
            Console.Read();
        }
    }
}
