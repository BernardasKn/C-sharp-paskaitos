using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        /*Sukurkite string tipo kintamąjį.Prie jo vis pridėkite
        vartotojo įrašomus skirtingus žodžius. Tačiau jei
        vartotojas įrašytų “exit” -baigti ciklą.Baigus vykdyti ciklą
        turi būti išvestas string kintamasis prie kurio vis buvo
        pridedami skirtingi žodžiai.*/
        static void Main(string[] args)
        {
            var sakinys = "";
            var ivedimas = "";

            while (ivedimas != "exit")
            {
                Console.Write("Įveskite žodį arba exit: ");
                ivedimas = Console.ReadLine();

                if (ivedimas != "exit")
                {
                    sakinys += ivedimas + " ";
                }
            }

            Console.WriteLine(sakinys);




        }
    }
}
