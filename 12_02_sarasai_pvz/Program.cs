using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_02_sarasai_pvz
{
    class Program
    {
        static void Main(string[] args)
        {
            var pinigai = new List<int>
            {
                650, 99, 78, 98, 96, 36, 57, 28, 11, 25, 36, 48, 71, 64, 20, 15, 16, 17
            };

            // pabandome isvesti

            foreach (var pin in pinigai)
            {
                Console.WriteLine("{0} Eur ", pin);
            }

            // rasti min, max, average,
            // atrinkti i kita sarasa mazesnius uz vidurki
            // atrinkti lyginius skaicius
            // atrinkti i kita sarasa tarp 30 ir max

            var maziausias = pinigai.Min();
            var didziausias = pinigai.Max();
            var vidurkis = pinigai.Average();

            Console.WriteLine("maziausias: " + maziausias);
            Console.WriteLine("didziausias: " + didziausias);
            Console.WriteLine("vidurkis: " + vidurkis);

            //atrinki mazesnius uz viduki

            var mazUzVid = new List<int>();

            foreach (var pinigas in pinigai) // skaiciuojam
            {
                if (pinigas < vidurkis)
                {
                    mazUzVid.Add(pinigas);
                }
            }

            Console.WriteLine("mazesni uz vidurki");

            foreach (var i in mazUzVid) // isvedam
            {
                Console.Write(i+ ", ");
            }

            Console.WriteLine();

            // atrinkti lyginius skaicius is pradinio

            var lyginiai = new List<int>();

            foreach (var pinigas in pinigai) // skaiciuojam
            {
                if (pinigas%2 == 0)
                {
                   lyginiai.Add(pinigas);
                }
            }

            Console.WriteLine("lyginiai");

            foreach (var i in lyginiai) // isvedam
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine();

            // atrinkti i kita sarasa tarp 30 ir max

            var intervalas = new List<int>();

            foreach (var pinigas in pinigai) // skaiciuojam
            {
                if (pinigas > 30 && pinigas < didziausias)
                {
                    intervalas.Add(pinigas);
                }
            }

            Console.WriteLine("tarp 30 ir max");

            foreach (var i in intervalas) // isvedam
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine();

        }
    }
}
