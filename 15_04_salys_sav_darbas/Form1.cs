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
    public partial class Form1 : Form
    {
        public Pasaulis Pasaulis { get; private set; } = new Pasaulis();
        public Form1()
        {
            InitializeComponent();
        }

        private void atidarytiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var failoPasirinkimas = new OpenFileDialog())
            {
                failoPasirinkimas.Filter = "csv failai (*.csv)|*.csv";
                failoPasirinkimas.Multiselect = true;

                if (failoPasirinkimas.ShowDialog() == DialogResult.OK)
                {
                    foreach (var failas in failoPasirinkimas.FileNames)
                    {
                        var salis = new Salis(failas);
                        Pasaulis.SaliuSarasas.Add(salis);

                        var skirtukas = new TabPage(salis.Pavadinimas);
                        tabControl1.Controls.Add(skirtukas);

                        skirtukas.Controls.Add(new DataGridView()
                        {
                            Dock = DockStyle.Fill,
                            DataSource = Pasaulis.SaliuSarasas.Last().MiestuSarasas
                        });

                    }
                }

            }
        }

        private void baigtiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void skaičiavimaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var forma = new Skaiciavimai(Pasaulis);
            forma.ShowDialog();
        }
    }
}
