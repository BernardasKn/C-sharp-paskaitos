using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_02_studentai
{
    class Grupe
    {
        public List<Studentas> Studentai { get; set; } = new List<Studentas>();

        /* publis Grupe()
        {
        Studentai = new LIst<Studentas>(); // jeigu nedame lygybe po get set
        }*/

        public Grupe()
        {
            Studentai.Add(new Studentas("Tom", "Smith", 180, 20, 'v'));
            Studentai.Add(new Studentas("Der", "Smith", 180, 20, 'v'));
            Studentai.Add(new Studentas("Hek", "Opapa", 180, 20, 'v'));
            Studentai.Add(new Studentas("Lili", "Fiji", 170, 20, 'm'));
            Studentai.Add(new Studentas("Iki", "Tutu", 116, 20, 'm'));
            Studentai.Add(new Studentas("Pepe", "Mimimi", 160, 20, 'm'));
            Studentai.Add(new Studentas("James", "Blunt", 189, 20, 'v'));

            //var studentas = new Studentas("Iki", "Tutu", 116, 20, 'm');
            //Studentai.Add(studentas);
        }
        public void Isvedimas()
        {
            Console.WriteLine("Studentai");
            foreach (var studentas in Studentai)
            {
                studentas.Isvedimas(); // studento isvedimo metodas
            }
            Console.WriteLine("Skaiciavimai"); //Skaiciavimai skaiciavimai skaiciavimai 

            Console.WriteLine("Zemiausias studentas");

            var zemiausias = ZemiausiasStudentas();
            zemiausias.Isvedimas();

            //ZemiausiasStudnetas().Isvedimas(); // objektas.jo_metodas

        } // grupe klases isvedimo metodo pabaiga

        // Grupes klaseje nauji metodai
        // Zemiausias studentas
        public Studentas ZemiausiasStudentas()
        {
            var zemiausias = Studentai.First();
            // dar galima: var zemiausias = Studentai[0];

            foreach (var studentas in Studentai) // eina per studentu sarasa
            {
                if (studentas.UgisCm < zemiausias.UgisCm) // lygina pagal tam tikras studentu savybes
                {
                    zemiausias = studentas; // priskiria visa objekta
                }
            }
            // grazina visa objekta
            return zemiausias;
        }

        // Vyriausias studentas
        public Studentas VyriausiasStudentas()
        {
            var zemiausias = Studentai.First();
            // dar galima: var zemiausias = Studentai[0];

            foreach (var studentas in Studentai) // eina per studentu sarasa
            {
                if (studentas.UgisCm < zemiausias.UgisCm) // lygina pagal tam tikras studentu savybes
                {
                    zemiausias = studentas; // priskiria visa objekta
                }
            }
            // grazina visa objekta
            return zemiausias;

            // Kiek moteru
            // kiek vyru
            // amziaus vidurkis




        }
    }
}
