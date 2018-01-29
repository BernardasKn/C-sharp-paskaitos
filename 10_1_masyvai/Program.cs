using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_masyvai
{
    class Program
    {
        static void Main(string[] args)
        {
            // studentu paymiai

            int[] pazymiai = { 10, 8, 3, 2, 5, 6, 7, 9};

            Console.WriteLine(pazymiai[1]);
            Console.WriteLine(pazymiai[3]);
            Console.WriteLine(pazymiai[6]);
            Console.WriteLine(pazymiai[7]);


            //2 --> 8

            pazymiai[3] = 8;

            Console.WriteLine(pazymiai[3]);

            Console.WriteLine();

            foreach (var pazymys in pazymiai) //isvesti visus
            {
                Console.WriteLine(pazymys + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < pazymiai.Length; i++) // panaudojant indeksa, galim persokti indeksą, galim išvesti kas antrą ir pan.
            {
                Console.WriteLine(pazymiai[i] + " ");
            }

            Console.WriteLine();

            // naujas masyvas - vardai
            Console.WriteLine("Vardų įvedimo uždavinys");

            var vardai = new string[7];

            for (int i = 0; i < vardai.Length; i++)
            {
                Console.Write("Iveskite varda: ");
                vardai[i] = Console.ReadLine();
            }

            Console.WriteLine();

            foreach (var vardas in vardai)
            {
                Console.WriteLine(vardas + ", ");
            }

            Console.WriteLine();

            // pazymiai 2

            Console.WriteLine("kiek pazymiu norite suvesti?");
            var kiek = Convert.ToInt32(Console.ReadLine());

            var pazymiai2 = new int[kiek];

            for (int i = 0; i < pazymiai2.Length; i++)
            {
                Console.WriteLine("iveskite {0}-aji pazymi: ", i+1);
                pazymiai2[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var pazymys in pazymiai2)
            {
                Console.WriteLine("[{0}]", pazymys);
            }


            // algoritmas suma

            var suma = 0;

            foreach (var pazymys in pazymiai2)
            {
                suma += pazymys;
                // suma = suma + pazymys;
                
            }

            Console.WriteLine("suma: " + suma);


            // algoritmas min pazymys

            var maziausias = pazymiai2[0]; // kai min ieskome reikia pirmo nario is masyvo; kai max tai ziurime su 0 arba su pirmu.

            foreach (var pazymys in pazymiai2)
            {
                if (pazymys < maziausias)
                {
                    maziausias = pazymys;
                }
            }

            Console.WriteLine("maziausias: " + maziausias);

            // Sekantis naudojam ant basic dalyku

           // Console.WriteLine("maziausias: " + pazymiai2.Min());

            // algoritmas didziausias pazymys

            var didziausias = pazymiai2[0]; // arba prisilyginam 0

            foreach (var pazymys in pazymiai2)
            {
                if (pazymys > didziausias)
                {
                    didziausias = pazymys;
                }
            }

            Console.WriteLine("didziausias: " + didziausias);

            // Console.WriteLine("didziausias: " + pazymiai2.Max()); 

            var vidurkis = (double)suma / pazymiai2.Length;

            Console.WriteLine("vidurkis: " + vidurkis);
            Console.WriteLine("vidurkis: " + pazymiai2.Average());

        }
    }
}
