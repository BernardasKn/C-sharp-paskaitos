using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + ", ");

                Console.WriteLine();
            }
            for (int i = 4; i < 20; i+=3)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine();

            var pradzia = 10;
            var pabaiga = 15;

            for (int i = pradzia; i < pabaiga; i++)
            {
                Console.Write(i + ", ");
            }

            //for (; ;) begalinis ciklas
            {
                Console.WriteLine("benas");
            }

        }
    }
}
