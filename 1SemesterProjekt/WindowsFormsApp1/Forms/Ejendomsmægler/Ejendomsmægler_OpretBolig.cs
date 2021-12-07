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
    public partial class Ejendomsmægler_OpretBolig : Form
    {
        public static int SælgerID { get; set; }
        public static int Pris { get; set; }
        public static int M2 { get; set; }
        public static string By { get; set; }
        public static string PostNr { get; set; }
        public static string Adresse { get; set; }
        public static int Etager1 { get; set; }
        public static int Byggeår { get; set; }
        public static string Boligtype { get; set; }
        public static int Værelser { get; set; }
        public static string Energimærke { get; set; }

        public Ejendomsmægler_OpretBolig()
        {
            InitializeComponent();
            #region PassToGrid
            DB db = new DB();
            DataTable tbl = db.Ejendomsmægler_OpretBolig_PassToGrid();
            dataGridView1.DataSource = tbl;
            #endregion PassToGrid
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            try
            {
                try
                {
                    SælgerID = Convert.ToInt32(comboBox6.Text);
                    Pris = Convert.ToInt32(textBox3.Text);
                    M2 = Convert.ToInt32(textBox4.Text);
                    By = textBox5.Text;
                    PostNr = textBox6.Text;
                    Adresse = textBox7.Text;
                    Etager1 = Convert.ToInt32(comboBox1.Text);
                    Byggeår = Convert.ToInt32(comboBox2.Text);
                    Boligtype = comboBox3.Text;
                    Værelser = Convert.ToInt32(comboBox5.Text);
                    Energimærke = comboBox4.Text;



                    
                    if (comboBox6.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "" && comboBox4.Text != "" && comboBox5.Text != "")
                    {
                        db.Ejendomsmægler_OpretBoligSQL();
                    }
                    else
                    {
                        MessageBox.Show("[Udfyld Alle Felter]");
                    }

                    #region PassToGrid
                    DataTable tbl = db.Ejendomsmægler_OpretBolig_PassToGrid();
                    dataGridView1.DataSource = tbl;
                    #endregion PassToGrid
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"{ex.Number} = {ex}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Udfyld alle felter");
            }

            
        }

        private void Ejendomsmægler_OpretBolig_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ejendomsmæglerDataSet.Sælger' table. You can move, or remove it, as needed.
            this.sælgerTableAdapter.Fill(this.ejendomsmæglerDataSet.Sælger);

        }
    }
}
