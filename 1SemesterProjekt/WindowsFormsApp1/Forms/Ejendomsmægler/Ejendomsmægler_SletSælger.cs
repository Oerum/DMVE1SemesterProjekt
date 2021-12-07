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

namespace WindowsFormsApp1.Forms.Ejendomsmægler
{
    public partial class Ejendomsmægler_SletSælger : Form
    {
        public static int ID { get; set; }
        public Ejendomsmægler_SletSælger()
        {
            InitializeComponent();
            #region PassToGrid
            DB db = new DB();
            DataTable tbl = db.Ejendomsmægler_SletSælger_PassToGrid();
            dataGridView1.DataSource = tbl;
            #endregion PassToGrid
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(textBox1.Text);

                DB db = new DB();

                db.Ejendomsmælger_SletSælgerSQl();

                #region PassToGrid
                DataTable tbl = db.Ejendomsmægler_SletSælger_PassToGrid();
                dataGridView1.DataSource = tbl;
                #endregion PassToGrid

            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451)
                {
                    MessageBox.Show("Sælger kan ikke slættes, da han er tilknyttet boliger");
                }
                else
                {
                    MessageBox.Show($"{ex.Number}");
                }
                
            }
        }
    }
}
