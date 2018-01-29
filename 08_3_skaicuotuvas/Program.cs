using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_3_skaicuotuvas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Ar norite atlikti skaičiavimus? (t/n)"); // skaičiavimo pasirinkimą pabandyti su switch
            var pageidavimas = "t"; // Iš pradžių nereikia klausti, turi būti tenkinama sąlyga.

            while (pageidavimas == "t")
            {
                Console.WriteLine("Įveskite 2 skaičius: ");
                var pirmas = double.Parse(Console.ReadLine()); //Moka tik iš teksto į skaičių
                var antras = double.Parse(Console.ReadLine());

                Console.WriteLine("{0} + {1} = {2}", pirmas, antras, pirmas + antras);
                Console.WriteLine("{0} - {1} = {2}", pirmas, antras, pirmas - antras);
                Console.WriteLine("{0} * {1} = {2}", pirmas, antras, pirmas * antras);
                Console.WriteLine("{0} / {1} = {2}", pirmas, antras, pirmas / antras);

                Console.WriteLine("Ar norite atlikti skaičiavimus? (t/n)");
                pageidavimas = Console.ReadLine();
            }
        }
    }
}
