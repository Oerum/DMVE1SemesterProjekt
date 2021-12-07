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
    public partial class Ejendomsmægler_OpretSælger : Form
    {
        public static string Tlf { get; set; }
        public static string Fornavn { get; set; }
        public static string Efternavn { get; set; }
        public static string Brugernavn1 { get; set; }
        public static string Kodeord1 { get; set; }
        public Ejendomsmægler_OpretSælger()
        {
            InitializeComponent();
            #region PassToGrid
            DB db = new DB();
            DataTable tbl = db.Ejendomsmægler_OpretSælger_PassToGrid();
            dataGridView1.DataSource = tbl;
            #endregion PassToGrid
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Tlf = textBox2.Text;
                Fornavn = textBox3.Text;
                Efternavn = textBox4.Text;
                Brugernavn1 = textBox5.Text;
                Kodeord1 = textBox6.Text;
                DB db = new DB();

                if (Tlf != null && Fornavn != null && Efternavn != null && Brugernavn1 != null && Kodeord1 != null)
                {
                    db.Ejendomsmægler_OpretSælgerSQL();
                    #region PassToGrid
                    DataTable tbl = db.Ejendomsmægler_OpretSælger_PassToGrid();
                    dataGridView1.DataSource = tbl;
                    #endregion PassToGrid
                }
                else
                {
                    MessageBox.Show("Field reading error");
                }



            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show("Brugernavn findes allerede");
                }
                else
                    MessageBox.Show($"{ex.Number}");
            }
        }
    }
}
