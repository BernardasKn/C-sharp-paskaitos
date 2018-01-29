using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_02_studentai
{
    class Program
    {
        static void Main(string[] args)
        {
            var stud1 = new Studentas("fdfd","pvard", 150, 18, 'm');
            var stud2 = new Studentas("fgf", "pvard", 150, 18, 'm');
            var stud3 = new Studentas("kooof", "pvard", 150, 18, 'm');
            var stud4 = new Studentas("fofj", "pvard", 150, 18, 'm');

            stud1.Isvedimas();
            stud2.Isvedimas();
            stud3.Isvedimas();
            stud4.Isvedimas();


            var grupe = new Grupe(); // isvedame grupe
            grupe.Isvedimas();
        }
    }
}
