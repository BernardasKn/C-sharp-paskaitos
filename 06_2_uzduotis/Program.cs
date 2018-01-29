using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("įveskite tris saičius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            if (a == b) // 1.1
            {
                Console.WriteLine("pirmas ir antras skaicius yra lygus");
            }
            if (b == c) // 1.2
            {
                Console.WriteLine("antras ir trečias skaicius yra lygus");
            }
            if (a > b) // 1.3
            {
                Console.WriteLine("pirmas skaičius didesnis už trečią");
            }
            if (b > c * 2) // 1.4
            {
                Console.WriteLine("antras didesnis us dviguba trecia");
            }
            if (a % 2 == 0) // 1.5
            {
                Console.WriteLine("pirmas skaicius yra lyginis");
            }
            if (b % 2 != 0) // 1.6
            {
                Console.WriteLine("antras skaicius yra nelyginis");
            }
            if (c > 0) // 1.7
            {
                Console.WriteLine("trecias skaicius daugiau uz nuli");
            }
            if (c < 0) // 1.8
            {
                Console.WriteLine("trecias skaicius maziau uz nuli");
            }

            Console.Read();
        }
    }
}
