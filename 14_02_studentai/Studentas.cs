using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_02_studentai
{
    class Studentas
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public int UgisCm { get; set; }
        public int Amzius { get; set; }
        public char Lytis { get; set; }

        // konstruktorius
        public Studentas()
        {

        }

        public Studentas(string vardas, string pavarde, int ugisCm, int amzius, char lytis)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            UgisCm = ugisCm;
            Amzius = amzius;
            Lytis = lytis;
        }

        //Isvedimo metodas

        public void Isvedimas()
        {
            Console.WriteLine("Studentas/-e {0} {1} ({2} m.), yra {3} cm ugio, jo/-jos lytis - {4}", Vardas, Pavarde, Amzius, UgisCm, Lytis);
            Console.WriteLine();
        }

    }
}
