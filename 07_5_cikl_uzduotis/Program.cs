using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_5_cikl_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("įveskite rėžių pradžią ir pabaigą:");
            Console.Write("rėžio pradžia: ");
            var pradzia = Convert.ToInt32(Console.ReadLine());
            Console.Write("rėžio pabaiga: ");
            var pabaiga = Convert.ToInt32(Console.ReadLine());

            if (pradzia < pabaiga)
            {
                for (int i = pradzia; i < pabaiga; i++)
                {
                    Console.WriteLine(Math.Pow(i,2));
                }
            }           

        }
    }
}
