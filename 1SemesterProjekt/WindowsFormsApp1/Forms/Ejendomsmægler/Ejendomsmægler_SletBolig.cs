using DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class Ejendomsmægler_SletBolig : Form
    {
        public static int BoligID { get; set; }
        public Ejendomsmægler_SletBolig()
        {
            InitializeComponent();
            #region PassToGrid
            DB db = new DB();
            DataTable tbl = db.Ejendomsmægler_SletBolig_PassToGrid();
            dataGridView1.DataSource = tbl;
            #endregion PassToGrid
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BoligID = Convert.ToInt32(textBox1.Text);
                DB db = new DB();

                db.Ejendomsmægler_SletBoligSQL();

                #region PassToGrid
                DataTable tbl = db.Ejendomsmægler_SletBolig_PassToGrid();
                dataGridView1.DataSource = tbl;
                #endregion PassToGrid

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void boligTilSalgBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void ejendomsmæglerDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
