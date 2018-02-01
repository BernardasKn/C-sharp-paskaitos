using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_04_salys_sav_darbas
{
    public class Miestas
    {
        public string Pavadinimas { get; private set; }
        public int GyventojuSkaicius { get; private set; }
        public double PlotasKvKm { get; private set; }

        public Miestas(string pavadinimas, int gyventojuSkaicius, double plotasKvKm)
        {
            Pavadinimas = pavadinimas;
            GyventojuSkaicius = gyventojuSkaicius;
            PlotasKvKm = plotasKvKm;
        }
        public Miestas(string eilute)
        {
            var isskaidyta = eilute.Split(';');
            Pavadinimas = isskaidyta[0];
            GyventojuSkaicius  = Convert.ToInt32(isskaidyta[1]);
            PlotasKvKm = Convert.ToDouble(isskaidyta[2]);
        }



    }
}
