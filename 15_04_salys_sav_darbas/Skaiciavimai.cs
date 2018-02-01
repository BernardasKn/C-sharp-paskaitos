using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_04_salys_sav_darbas
{
    public partial class Skaiciavimai : Form
    {
        public Skaiciavimai(Pasaulis pasaulis)
        {
            InitializeComponent();
            label1.Text = "Daugiausia gyventoju"; // jeigu properties nepervadiname lable
            var daugiausiaiGyventoju = pasaulis.DaugiausiaiGyventoju();
            textBox1.Text = daugiausiaiGyventoju.Pavadinimas;
            textBox4.Text = daugiausiaiGyventoju.GyventojuSkaicius.ToString();

            var maziausiaiGyventoju = pasaulis.MaziausiaiGyventoju();
            textBox2.Text = maziausiaiGyventoju.Pavadinimas;
            textBox3.Text = maziausiaiGyventoju.GyventojuSkaicius.ToString();

            var tankiausiaiGyventoju = pasaulis.TankiausiaiGyventoju();
            textBox6.Text = tankiausiaiGyventoju.Pavadinimas;
            textBox3.Text = tankiausiaiGyventoju.GyventojuSkaicius/.ToString();//
        }
    }
}
