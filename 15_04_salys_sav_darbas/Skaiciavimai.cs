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
            label1.Text = "Daugiausia gyventoju"; // jeigu properties lange nepervadiname lable
            var daugiausiaiGyventoju = pasaulis.DaugiausiaiGyventoju();
            textBox1.Text = daugiausiaiGyventoju.Pavadinimas;
            textBox4.Text = daugiausiaiGyventoju.GyventojuSkaicius.ToString();

            var maziausiaiGyventoju = pasaulis.MaziausiaiGyventoju();
            textBox2.Text = maziausiaiGyventoju.Pavadinimas;
            textBox3.Text = maziausiaiGyventoju.GyventojuSkaicius.ToString();

            var tankiausiaiGyventoju = pasaulis.TankiausiaiGyventoju(); //naudoja papildoma stulpeli, kuris formuojamas pagal konstruktoriu duomenu uzkelimo metu
            textBox6.Text = tankiausiaiGyventoju.Pavadinimas;
            textBox5.Text = tankiausiaiGyventoju.GyventojuTankis.ToString();

            var maziausiasTankis = pasaulis.MaziausiasTankis(); //naudoja papildoma stulpeli, kuris formuojamas pagal konstruktoriu duomenu uzkelimo metu
            textBox8.Text = maziausiasTankis.Pavadinimas;
            textBox7.Text = maziausiasTankis.GyventojuTankis.ToString();

            var didziausiaBpv = pasaulis.DidziausiaBpv(); //naudoja papildoma stulpeli is csv failo
            textBox10.Text = didziausiaBpv.Pavadinimas;
            textBox9.Text = didziausiaBpv.BendrojiPridetineVerte.ToString();

            var maziausiaBpv = pasaulis.MaziausiaBpv(); //naudoja papildoma stulpeli is csv failo
            textBox12.Text = maziausiaBpv.Pavadinimas;
            textBox11.Text = maziausiaBpv.BendrojiPridetineVerte.ToString();

        }
    }
}
