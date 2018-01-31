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
    public partial class Skaiciavimu_forma : Form
    {
        public Skaiciavimu_forma()
        {
            InitializeComponent();
        }
        public Skaiciavimu_forma(string zodis)
        {
            InitializeComponent();
            label1.Text = zodis;
        }
    }
}
