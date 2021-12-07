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
    public partial class Ejendomsmægler_OpdaterBolig : Form
    {
        public static int BoligID { get; set; }
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
        public static string OprettelsesDato { get; set; }
        public Ejendomsmægler_OpdaterBolig()
        {
            InitializeComponent();
            #region PassToGrid
            DB db = new DB();
            DataTable tbl = db.Ejendomsmægler_OpdaterBolig_PassToGrid();
            dataGridView1.DataSource = tbl;
            #endregion PassToGrid
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    BoligID = Convert.ToInt32(textBox1.Text);
                    DB db = new DB();
                    db.Ejendomsmægler_OpdaterBoligButton2SQL();

                    textBox1.Text = Convert.ToString(BoligID);
                    textBox2.Text = Convert.ToString(SælgerID);
                    textBox3.Text = Convert.ToString(Pris);
                    textBox4.Text = Convert.ToString(M2);
                    textBox5.Text = Convert.ToString(By);
                    textBox6.Text = Convert.ToString(PostNr);
                    textBox7.Text = Convert.ToString(Adresse);
                    textBox8.Text = Convert.ToString(Etager1);
                    textBox9.Text = Convert.ToString(Byggeår);
                    textBox10.Text = Convert.ToString(Boligtype);
                    textBox11.Text = Convert.ToString(Værelser);
                    textBox12.Text = Convert.ToString(Energimærke);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"{ex.Number} = {ex}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Forkert Format");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    BoligID = Convert.ToInt32(textBox1.Text);
                    SælgerID = Convert.ToInt32(textBox2.Text);
                    Pris = Convert.ToInt32(textBox3.Text);
                    M2 = Convert.ToInt32(textBox4.Text);
                    By = Convert.ToString(textBox5.Text);
                    PostNr = Convert.ToString(textBox6.Text);
                    Adresse = Convert.ToString(textBox7.Text);
                    Etager1 = Convert.ToInt32(textBox8.Text);
                    Byggeår = Convert.ToInt32(textBox9.Text);
                    Boligtype = Convert.ToString(textBox10.Text);
                    Værelser = Convert.ToInt32(textBox11.Text);
                    Energimærke = Convert.ToString(textBox12.Text);
                    DB db = new DB();
                    db.Ejendomsmægler_OpdaterBoligButton1SQL();

                    #region PassToGrid
                    DataTable tbl = db.Ejendomsmægler_OpdaterBolig_PassToGrid();
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
                MessageBox.Show("Udfyld alle felter");
            }
            
        }
    }
}
