using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_cooking_min
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] vegetables = new string[13,2]
           {
                {"eggplant", "20"},
                {"pumpkin", "15" },
                {"cabbage", "12" },
                {"broccoli","8" },
                {"carrot", "10" },
                {"pepper", "15" },
                {"beetroot","60" },
                {"asparagus", "10" },
                {"turnips", "20" },
                {"beans", "20" },
                {"potatoes", "20" },
                {"corn", "15" },
                {"spinach", "2" }
            };
            Console.WriteLine("Vegetable Cooking time");

            int rowLength = vegetables.GetLength(0);
            int colLength = vegetables.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0}   ", vegetables[i, j]));
                }
                Console.WriteLine(Environment.NewLine);
                //Console.WriteLine(Environment.NewLine + Environment.NewLine);
            }
            Console.ReadLine();
            
            /*for (int i = 0; i < vegetables.Length; i++) //suveikia, bet ismeta klaida
            {
                Console.Write(vegetables[i, 0] + " ");
                Console.WriteLine(vegetables[i, 1]);
            }  */



        }
    }
}
