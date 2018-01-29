using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_tarpine_uzduotis
{
    class Program
    {
        /*The sum of the squares of the first ten natural numbers is, 12 + 22 + ... + 102 = 385
        The square of the sum of the first ten natural numbers is, (1 + 2 + ... + 10)2 = 552 = 3025
        Hence the difference between the sum of the squares of the first ten natural
        numbers and the square of the sum is 3025 − 385 = 2640.
        Find the difference between the sum of the squares of the first one hundred natural
        numbers and the square of the sum.
        Answer: 25164150 */

        static void Main(string[] args)
        {
            var skaicius = 0;
            
            for (int i = 1; i <= 100; i++)
            {
                skaicius += i*i;
            }
            Console.WriteLine(skaicius);

            var skaicius1 = 0;
                                    
            for (int i = 1; i <= 100; i++)
            {
                skaicius1 += i;
            }
            
            Console.WriteLine(skaicius1*skaicius1);

            Console.WriteLine(skaicius1 * skaicius1 - skaicius);

        }
    }
}
