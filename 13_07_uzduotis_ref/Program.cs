using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_07_uzduotis_ref
{
    class Program
    {
        static void Main(string[] args)
        {
            var vardas = "Ben";
            var pavarde = "Affleck";
            var amzius = 40;

            Isvedimas(vardas, pavarde, amzius);
            Ivedimas(ref vardas, ref pavarde, ref amzius);
            Isvedimas(vardas, pavarde, amzius);


        } //========= Main pabaiga ========

        public static void Ivedimas(ref string vardas,ref string pavarde, ref int amzius)
        {
            // programoje ivestas vardas
            Console.WriteLine("Programoje ivestas vardas " + vardas);
            
            //iveskite nauja
            Console.Write("Iveskite nauja: ");
            vardas = Console.ReadLine();

            // programoje ivesta pavarde
            Console.WriteLine("Programoje ivesta pavarde " + pavarde);
            
            //iveskite nauja
            Console.Write("Iveskite nauja: ");
            pavarde = Console.ReadLine();

            Console.WriteLine("Programoje ivestas amzius " + amzius);
            Console.Write("Iveskite nauja: ");
            amzius = Convert.ToInt32(Console.ReadLine());
        }

        public static void Isvedimas(string vardas, string pavarde, int amzius)
        {
            Console.WriteLine("{0} {1} ({2} m.)", vardas, pavarde, amzius);
        }



    }
}
