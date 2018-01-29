using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_6_random
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomas = new Random();
            var suma = 0;
            var didziausias = 0; //iskome didziausio


            for (int i = 0; i < 50; i++)
            {
                //Pirmas budas
                //Console.Write(randomas.Next(20) + " "); // [0-20)

                //antras budas
                var skaicius = randomas.Next(5,50); // [5-50) 5 patenka, 50 - nepatenka
                Console.Write(skaicius + " ");

                suma += skaicius;

                if(skaicius > didziausias)
                {
                    didziausias = skaicius;
                }

            }

            Console.WriteLine();
            Console.WriteLine("suma: " + suma);
            Console.WriteLine("didžiausias: " + didziausias);
        }
    }
}
