using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_04_garazas
{
    class Automobilis
    {
        // modelis, marke, gamybos metai, rida, galia kw, darbinis turis, spalva 

        public string Modelis { get; private set; }
        public string Marke { get; private set; }
        public int GamybosMetai { get; private set; }
        public int Rida { get; private set; }
        public int GaliaKw { get; private set; }
        public int DarbinisTuris { get; private set; }
        public string Spalva { get; private set; }


        //pilnas konsruktorius

        public Automobilis(string modelis, string marke, int gamybosMetai, int rida, int galiaKw, int darbinisTuris, string spalva)
        {
            Modelis = modelis;
            Marke = marke;
            GamybosMetai = gamybosMetai;
            Rida = rida;
            GaliaKw = galiaKw;
            DarbinisTuris = darbinisTuris;
            Spalva = spalva;
        }

        //tik isvedimo metodas, be ivedimo
        public void Isvedimas()
        {
            Console.WriteLine("Automobilis {0} {1} ({2} m.), {3} km, {4} kw, {5} l, {6}", Modelis, Marke, GamybosMetai, Rida, GaliaKw, DarbinisTuris, Spalva);
        }
        //nauji metodai
        // atsukti rida
        public void RidosAtsukimas()
        {
            Console.WriteLine("Dabarine rida " + Rida);
            Console.Write("Iveskite norima: ");
            var naujaRida = Convert.ToInt32(Console.ReadLine());
            Rida = naujaRida;
            Console.WriteLine("Rida pakeista i: " + Rida);
        }

        // perdazyti
        public void Perdazymas()
        {
            Console.WriteLine("Dabarine spalva" + Spalva);
            Console.WriteLine("Kokia spalva norite perdazyti automobili?");
            var naujaSpalva = Console.ReadLine();
            Spalva = naujaSpalva;
            Console.WriteLine("Spalva pakeista i: " + Spalva);
        }


        // pakelti galia
        public void GaliosKelimas()
        {
            Console.WriteLine("Dabartine galia " + GaliaKw);
            Console.WriteLine("Kokia galia norite tureti?");
            var naujaGaliaKw = Convert.ToInt32(Console.ReadLine());
            GaliaKw = naujaGaliaKw;
            Console.WriteLine("Galia pakeista i: " + GaliaKw);
        }



    }
}
