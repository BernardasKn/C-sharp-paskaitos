using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarpine_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Kiek darbuotojas gali iškepti kepalų per valandą? ");
            var kepalai = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kiek darbuotojų turi kepykla? ");
            var darbuotojai = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vieno kepalo savikaina? ");
            var savikaina = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vieno kepalo kaina? ");
            var kaina = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kiek kepykla turi užsakymų? ");
            var uzsakymai = Convert.ToDouble(Console.ReadLine());

            double kepalaiPerDiena;
            kepalaiPerDiena = 8 * darbuotojai * kepalai;

            Console.WriteLine("Kepyla per dieną iškepa kepalų {0}", kepalaiPerDiena);

            double kepaluSavikaina,
                gautosPajamos,
                gautasPelnas,
                nespesKepalu;
            kepaluSavikaina = savikaina * kepalaiPerDiena;
            Console.WriteLine("Visų kepalų savikaina {0}", kepaluSavikaina);
            gautosPajamos = kepalaiPerDiena * kaina;
            Console.WriteLine("Gatos pajamos {0}", gautosPajamos);
            gautasPelnas = gautosPajamos - kepaluSavikaina;
            Console.WriteLine("Gatas pelnas {0}", gautasPelnas);

            if (kepalaiPerDiena > uzsakymai)
            {
                Console.WriteLine("Spės iškepti per dieną visu užsakymus.");
            }
            else
            {
                nespesKepalu = uzsakymai - kepalaiPerDiena;
                Console.WriteLine("Nespės {0} kepalų", nespesKepalu);
            }
            Console.ReadLine();

           

        }
    }
}
