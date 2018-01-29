using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Food_boiling_min
{
    class Program
    {
        static void Main(string[] args)
        {   // Jagged Arrays (C# Programming Guide)
            // Deklaruojamas 2 masyvu masvymas
            string[][] jaggedVegetables = new string[][]
                {            new string []
            {
                "eggplant",
                "pumpkin",
                "cabbage",
                "broccoli",
                "carrot",
                "pepper",
                "beetroot",
                "asparagus",
                "turnips",
                "beans",
                "potatoes",
                "corn",
                "spinach",
            },

            new string [] { "20", "15", "12", "8", "10", "15", "60", "10", "20", "20", "20", "15", "2" }
        };

            for (int i = 0; i < jaggedVegetables.Length; i++)
            {
                Console.Write("Element({0}): ", i);
                for (int j = 0; j < jaggedVegetables[i].Length; j++)
                {
                    Console.Write("{0}{1}", jaggedVegetables[i][j], j == (jaggedVegetables[i].Length - 1) ? "" : " ");
                }

                Console.WriteLine();
            }


            
            


        }
    }
}
