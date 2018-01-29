using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_7_speliojimo_zaidimas
{
    class Program
    {
        static void Main(string[] args)
        {
            //žaidimas, kuomet reikia atspeti skaičių...

            var atsitiktinis = new Random(); // susikurti tik vieną kartą
            var atsitiktinisSkaicius = atsitiktinis.Next(1, 10); // [1, 10)
            Console.WriteLine("Iveskite savo spejima");
            var spejimas = Convert.ToInt32(Console.ReadLine());

            var gyvybes = 2;
            
            while(spejimas != atsitiktinisSkaicius && gyvybes >= 0)
            {
                if (gyvybes == 0)
                {
                    Console.WriteLine("Game Over");
                }
                else if (spejimas > atsitiktinisSkaicius)
                {
                    Console.WriteLine("Turite ivesti mazesni skaiciu, nei pries tai.");
                    spejimas = Convert.ToInt32(Console.ReadLine());
                }
                else if (spejimas < atsitiktinisSkaicius)
                {
                    Console.WriteLine("Turite ivesti didesni skaiciu, nei pries tai.");
                    spejimas = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Atspejote " + spejimas);
                }
                gyvybes--;
            }
           

            

        }
    }
}
