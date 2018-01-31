using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_03_pavyzdziai
{
    class Program
    {
        static void Main(string[] args)
        {
            Pasisveikinti();
            Program p = new Program();
            p.Atsisveikinti();
        }

        private static void Pasisveikinti()
        {
            Console.WriteLine("Labas");
        }

        private void Atsisveikinti()
        {
            Console.WriteLine("Viso gero");
        }

    }
}
