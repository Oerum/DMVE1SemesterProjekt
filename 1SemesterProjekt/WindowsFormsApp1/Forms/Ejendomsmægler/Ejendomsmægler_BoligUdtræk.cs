using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utf8Json;

namespace WindowsFormsApp1.Forms.Ejendomsmægler
{
    public partial class Ejendomsmægler_BoligUdtræk : Form
    {
        public Ejendomsmægler_BoligUdtræk()
        {
            InitializeComponent();
            try
            {
                #region PassToGrid
                List<string> BoligUdtræk = Ejendomsmægler_InputDato.BoligUdtræk;

                foreach (var v in BoligUdtræk)
                {
                    //int x = 1;
                    dataGridView1.Columns.Add("Keys", $"{v}");
                }

                /*
                for (int i = 1; i < BoligUdtræk.Count(); i++)
                {
                    if (v.Contains($"SælgerID: {i}"))
                    {
                        dataGridView1.Columns.Add("Keys", $"SælgerID {x}");        
                    }
                    x++;
                }
                */
                #endregion PassToGrid
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Ejendomsmægler_filtrerePris Pris = new Ejendomsmægler_filtrerePris();
            Pris.Show();
            this.Hide();
        }

        private void solgteBoligBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void solgteBoligBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
