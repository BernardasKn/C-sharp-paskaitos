using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_04_garazas
{
    class Program
    {
        static void Main(string[] args)
        {
            var garazas = new Garazas("Pas Petra", "Kaunas prie baziu", 2, new List<Automobilis>
            {
                 new Automobilis("Opel", "Astra", 2005, 200000, 88, 2, "raudona"),
                 new Automobilis("Fiat", "Multipla", 2002, 100000, 60, 2, "raudona"),
                 new Automobilis("Ford", "Astra", 2001, 200000, 88, 2, "zalia"),
                 new Automobilis("Opel", "Astra", 1980, 15000, 89, 2, "ruda"),
                 new Automobilis("Trantas", "bulka", 2005, 300000, 55, 4, "raudona"),
                 new Automobilis("Shevrolet", "Mustang", 2005, 19000, 88, 3, "zydra"),
            });

            garazas.Isvedimas();

            garazas.AtnaudjintiPasirinkta();

            garazas.Skaiciavimai();
        




        }
    }
}
