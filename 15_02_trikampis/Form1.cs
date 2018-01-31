using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_02_trikampis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSkaiciuoti_Click(object sender, EventArgs e)
        {
            var statinis = Convert.ToInt32(textBoxsStatinis.Text);
            var krastine = Convert.ToInt32(textBoxKrastine.Text);
            var plotas = (double)statinis * krastine / 2;

            textBoxPlotas.Text = plotas.ToString();
        
        }
    }
}
