using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_03_seima
{
    class Seima
    {
        public string Adresas { get; private set; }
        public List<Zmogus> Zmones { get; private set; } = new List<Zmogus>();

        public Seima(string adresas, List<Zmogus> zmones)
        {
            Adresas = adresas;
            Zmones = zmones;
        }

        public Seima()
        {
            Ivedimas();
        }

        public void Isvedimas()
        {
            Console.WriteLine("Seima gyvena {0} adresu", Adresas);
            foreach (var zmogus in Zmones)
            {
                zmogus.Isvedimas();
            }
        }

        public void Ivedimas()
        {
            Console.Write("Iveskite adresa: ");
            Adresas = Console.ReadLine();
            // klausti kiek zmoniu suvesti
            Console.Write("Kiek zmoniu riekia ivesti? ");
            // sukti cikla tiek kartu kiek reikia
            int zmoniuSkaicius = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < zmoniuSkaicius; i++)
            {
                // kurti tuscia zmogaus objekta naudojant () tuscia konstruktoriu
                var zmogus = new Zmogus(); //zmogaus konstruktorius iskvies ivedimo metoda - metodas yra zmogaus klaseje
                // zmogaus objekta ikelti i zmoniu sarasa
                Zmones.Add(zmogus); // List<Zmogus>
            }

            
        }

    }
}
