using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_04_salys_sav_darbas
{
    public class Pasaulis
    {
        public List<Salis> SaliuSarasas { get; private set; } = new List<Salis>();


        public Miestas DaugiausiaiGyventoju()
        {
            var gyv = SaliuSarasas.First().MiestuSarasas.First();
            foreach (var salis in SaliuSarasas)
            {
                foreach (var miestas in salis.MiestuSarasas)
                {
                    if (miestas.GyventojuSkaicius > gyv.GyventojuSkaicius)
                    {
                        gyv = miestas;
                    }
                }
            }


            return gyv;
        }

        public Miestas MaziausiaiGyventoju()
        {
            var gyv = SaliuSarasas.First().MiestuSarasas.First(); // miestas
            foreach (var salis in SaliuSarasas)
            {
                foreach (var miestas in salis.MiestuSarasas)
                {
                    if (miestas.GyventojuSkaicius < gyv.GyventojuSkaicius)
                    {
                        gyv = miestas;
                    }
                }
            }


            return gyv;
        }

        public Miestas TankiausiaiGyventoju()
        {
            var gyv = SaliuSarasas.First().MiestuSarasas.First(); // miestas
            //var gyvtankis = 0;
            foreach (var salis in SaliuSarasas)
            {
                foreach (var miestas in salis.MiestuSarasas)
                {
                    if (miestas.GyventojuSkaicius/miestas.PlotasKvKm > gyv.GyventojuSkaicius/miestas.PlotasKvKm)
                    {
                        gyv = miestas;
                        //gyvtankis = (double).miestas.GyventojuSkaicius / miestas.PlotasKvKm;

                    }
                }
            }


            return gyv;
        }


    }

}    
