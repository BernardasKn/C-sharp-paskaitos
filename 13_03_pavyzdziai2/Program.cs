using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_03_pavyzdziai2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.EvenNumbers();
            Console.WriteLine();
            Program.OddNumbers(); //"Program." nera butina rasyti, kai metodas yra "static"
            Console.WriteLine();
            Program SuParemetru = new Program();
            SuParemetru.MethodWithParameter(10); // naudos reiksmes iki 10.
            Console.WriteLine();
            Program a = new Program(); // metodo, kurs retrurnina int naudojimas
            int sum =  a.Add2Number(10, 20);
            Console.WriteLine("Suma {0}", sum);
        }

        //public int MyProperty { get; private set; } propg --> 2x tab

        public void EvenNumbers() //instance method
        {
            int start = 0;
            while (start <= 20)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
        }

        public static void OddNumbers() //static method
        {
            int start = 1;
            while (start <= 20)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
        }
        public void MethodWithParameter(int Target) // metodas, kuris naudoja parametra
        {
            int start = 0;
            while (start <= Target)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
        }

        public int Add2Number(int FN, int SN) // metodas kur "returnina" reiksme
        {
            return FN + SN;
        }
    }
}
