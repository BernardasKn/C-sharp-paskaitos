using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_01_pradmenys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMygtukas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Labas");
        }

       
        private void buttonGautiReiksme_Click(object sender, EventArgs e)
        {
            var reiksme = textBoxReiksme.Text;
            labelReiksme.Text = reiksme;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var daugiklis1 = Convert.ToInt32(textBoxDaugiklis1.Text);
            var daugiklis2 = Convert.ToInt32(textBoxDaugiklis2.Text);
            var sandauga = daugiklis1 * daugiklis2;
            labelSandauga.Text = sandauga.ToString();
        }

        private void buttonRodyti_Click(object sender, EventArgs e)
        {
            var forma = new InformacijosLangas();
            forma.ShowDialog();
        }

        private void buttonSiusti_Click(object sender, EventArgs e)
        {
            var reiksme = textBoxSiusti.Text;
            var forma = new Skaiciavimu_forma(reiksme);
            forma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var forma = new IvedimoForma())
            {
                forma.ShowDialog();

                if (forma.DialogResult == DialogResult.OK)
                {
                    var zodis = forma.Zodis;
                    label1.Text = zodis;
                }
            }
        }
    }
}
