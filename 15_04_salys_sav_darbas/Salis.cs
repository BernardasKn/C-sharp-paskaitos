using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_04_salys_sav_darbas
{
    public class Salis
    {
        public string Pavadinimas { get; private set; }
        public string Zemynas { get; private set; }
        public List<Miestas> MiestuSarasas { get; private set; } = new List<Miestas>();

        public Salis (string failas)
        {
            var tekstas = File.ReadAllLines(failas);
            Pavadinimas = tekstas[0];
            Zemynas = tekstas[1];
            for (int i = 2; i < tekstas.Length; i++)
            {
                var miestas = new Miestas(tekstas[i]);
                MiestuSarasas.Add(miestas);
            }
        }
    }
}
