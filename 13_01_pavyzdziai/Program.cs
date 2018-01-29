using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_01_pavyzdziai
{
    class Matematika
    {
        public static int Suma(int a, int b)
        {
            return a + b;
        }

        public static int Skirtumas(int a, int b)
        {
            var skritumas = a - b;
            return skritumas;
        }
        public static int Sandauga(int a, int b)
        {
            return a * b;
        }

        public static double Dalmuo(int a, int b)
        {
            return (double) a / b;
        }


    }



    class Program
    {
        static void Main(string[] args)
        {
            var suma = Matematika.Suma(5, 4);
            Console.WriteLine(suma);

            var skirtumas = Matematika.Skirtumas(5, 4);
            Console.WriteLine(skirtumas);

            var sandauga = Matematika.Sandauga(5, 4);
            Console.WriteLine(sandauga);
            
            var dalyba= Matematika.Dalmuo(5, 4);
            Console.WriteLine(dalyba);

        }
    }
}
