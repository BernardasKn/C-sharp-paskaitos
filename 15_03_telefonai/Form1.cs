using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_03_telefonai
{
    public partial class Form1 : Form
    {
        public List<Telefonas> Telefonai { get; private set; }


        public Form1()
        {
            InitializeComponent();
            Telefonai = new List<Telefonas>();
        }

        private void baigtiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nuskaitytiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // c sharp stream reader, kai ieskome google.
            // kad rasti failo kelia: open file dialog

            using (var failoPasirinkimoLangas = new OpenFileDialog())
            {
                failoPasirinkimoLangas.Filter = "csv failai (*.csv)|*.csv";
                
                if (failoPasirinkimoLangas.ShowDialog() == DialogResult.OK)
                {
                    //MessageBox.Show(failoPasirinkimoLangas.FileName);

                    //nuskaitinejimas

                    using (var skaitytuvas = new System.IO.StreamReader(failoPasirinkimoLangas.FileName))
                    {
                        string eilute;
                        var eil = 0;
                        while ((eilute = skaitytuvas.ReadLine()) != null)
                        {
                            //MessageBox.Show(eilute);

                            if (eil == 0) // kad prokti "headeri"
                            {
                                eil++;
                                continue; //soka i while pradzia
                            }
                             
                            var telefonas = new Telefonas(eilute);
                            Telefonai.Add(telefonas);

                        }
                        dataGridView1.DataSource = Telefonai;
                    }

                }
            }


        }

        private void skaičiavimaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var forma = new skaiciavimai(Telefonai);
            forma.ShowDialog();
        }
    }
}
