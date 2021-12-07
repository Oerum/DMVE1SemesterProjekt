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
    public partial class Ejendomsmægler_OpdaterSælger : Form
    {
        public static string ID { get; set; }
        public static string Tlf { get; set; }
        public static string Fornavn { get; set; }
        public static string Efternavn { get; set; }
        public static string Brugernavn { get; set; }
        public static string Kodeord { get; set; }
        public Ejendomsmægler_OpdaterSælger()
        {
            InitializeComponent();
            #region PassToGrid
            DB db = new DB();
            DataTable tbl = db.Ejendomsmægler_OpdaterSælger_PassToGrid();
            dataGridView1.DataSource = tbl;
            #endregion PassToGrid
        }

        private void button2_Click(object sender, EventArgs e)
        {     
            try
            {
                ID = textBox1.Text;
                DB db = new DB();
                db.Ejendomsmægler_OpdaterSælgerButton2SQL();
                textBox1.Text = ID;
                textBox2.Text = Tlf;
                textBox3.Text = Fornavn;
                textBox4.Text = Efternavn;
                textBox5.Text = Brugernavn;
                textBox6.Text = Kodeord;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                if (textBox1.Text != null && textBox2.Text != null && textBox3.Text != null && textBox4.Text != null && textBox5.Text != null && textBox6.Text != null)
                {
                    ID = textBox1.Text;
                    Tlf = textBox2.Text;
                    Fornavn = textBox3.Text;
                    Efternavn = textBox4.Text;
                    Brugernavn = textBox5.Text;
                    Kodeord = textBox6.Text;
                    
                    db.Ejendomsmægler_OpdaterSælgerButton1SQL();
                }
                else
                {
                    MessageBox.Show("Indtast gyldig information i alle kolonner");
                }

                #region PassToGrid
                DataTable tbl = db.Ejendomsmægler_OpdaterSælger_PassToGrid();
                dataGridView1.DataSource = tbl;
                #endregion PassToGrid

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }
    }
}
