using DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms.Køber
{
    public partial class Køber_Bolig : Form
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

        public Køber_Bolig()
        {
            InitializeComponent();
            try
            {
                #region PassToGrid
                DB db = new DB();
                DataTable tbl = db.Køber_Bolig_PassToGrid();
                dataGridView1.DataSource = tbl;
                #endregion PassToGrid  
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlConnection conn = new MySqlConnection(db.ConnStr);

            try
            {
                try
                {
                    BoligID = Convert.ToInt32(textBox1.Text);
                    db.Køber_Bolig_GetInfo();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"{ex.Number}");
                }

                if (BoligID != -1 && Køber_Login.Køber_ID_LoggedIn != null && Pris != -1 && M2 != -1 && PostNr != null && PostNr != null && OprettelsesDato != null)
                {
                    try
                    {

                        db.Køber_Bolig_Buy();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show($"{ex.Number}");
                    }

                    try
                    {
                        db.Køber_Bolig_DeleteFromSale();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show($"{"Noget gik galt " + ex.Number}");
                    }

                    try
                    {
                        MessageBox.Show("Køb succesfuld");
                        #region PassToGrid
                        DataTable tbl = new DataTable();
                        string sqlshow = "SELECT * FROM BoligTilSalg;";
                        MySqlCommand cmd1 = new MySqlCommand(sqlshow, conn);
                        conn.Open();
                        tbl.Load(cmd1.ExecuteReader());
                        dataGridView1.DataSource = tbl;
                        conn.Close();
                        #endregion PassToGrid
                    }
                    catch
                    {
                        MessageBox.Show("GridView Fejl");
                    }
                }
                else
                {
                    MessageBox.Show("Boligen du forsøger at købe eksisterer ikke");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Feltet er tomt");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.Køber_Bolig_txt();
        }
    }
}
