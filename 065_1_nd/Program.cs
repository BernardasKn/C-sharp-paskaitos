using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _065_1_nd
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Vienuoliktokai nusprendė pasibaigus mokslo metams aplankyti gražiausias Lietuvos vietas.
            Kelionės maršrutą jie pradėjo rinktis iš anksto, kad galėtų numatyti kelionės išlaidas.
            Mokiniai pasirinko maršrutą Panevėžys-Plungė - Panevėžys(320 km).Į kelionę planuoja vykti
            k vienuoliktokų.Kelionės trukmė - d dienų. Kelionei kiekvienas vienuoliktokas gali skirti po t
            eurų.Maistui per dieną vienam žmogui reikia v eurų. Litras benzino kainuoja n eurų.Degalų
            sąnaudos sudaro b litrų šimtui kilometrų.Parenkite programą, kuri ekrane parodytų
            pranešimą “Vienuoliktokai gali vykti į šią kelionę”, jei numatomai kelionei skirti pinigai
            padengia kelionės išlaidas, arba “Vienuoliktokai negali vykti į šią kelionę”, jei numatomai
            kelionei skirti pinigai nepadengia kelionės išlaidų.*/

            int k, // vienuoliktokų skaičius
                d; // kelionės trukmė dienomis

            double t, // kiekvienas asmuo skiria EUR
                v, // vienam žmogui reikia EUR maistui
                n, // litro benzino kaina
                b, // degalų sąnaudos 100 km
                reikiamaSuma,
                papildomaSuma1a,
                skiriamaSuma;
            var km = 320;

            Console.Write("Kiek vienuoliktokų planuoja vykti? ");
            k = Convert.ToInt16(Console.ReadLine());
            Console.Write("Kokia kelionės trukmė dienomis? ");
            d = Convert.ToInt16(Console.ReadLine());
            Console.Write("Kievienas asmuo kelionei gali skirti EUR: ");
            t = Convert.ToInt16(Console.ReadLine());
            Console.Write("Vienam žmogui reikia EUR maistui per dieną: ");
            v = Convert.ToInt16(Console.ReadLine());
            Console.Write("Vieno litro benzino kaina: ");
            n = Convert.ToInt16(Console.ReadLine());
            Console.Write("Degalų sąnaudos 100 km: ");
            b = Convert.ToInt16(Console.ReadLine());

            reikiamaSuma = km / 100 * b * n + k * d * v;
            skiriamaSuma = k * t;
            papildomaSuma1a = (reikiamaSuma - skiriamaSuma) / k;

            if (skiriamaSuma > reikiamaSuma)
            {
                Console.Write("Vienuoliktokai gali vykti į kelionę!");
            }
            else
            {
                Console.Write(" Vienuoliktokai negali vykti į kelionę. \n Kiekvienas vienuoliktokas turi prisidėti {0} EUR papildomai", papildomaSuma1a);
            }
            Console.Read();
        }
    }
}
