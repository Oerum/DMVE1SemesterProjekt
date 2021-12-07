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
    public partial class Køber_Ordre : Form
    {
        public static int BoligID { get; set; }
        public static int KøberID { get; set; }
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
        public static string HandelsDato { get; set; }
        public Køber_Ordre()
        {
            InitializeComponent();
            try
            {
                #region PassToGrid
                DB db = new DB();
                DataTable tbl = db.Køber_Ordre_PassToGrid();
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
            

            try
            {
                BoligID = Convert.ToInt32(textBox1.Text);

                db.Køber_Ordre_Get();
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error: {ex.Number} Bolig er ikke tilknyttet din konto");
            }

            if (BoligID != -1 && KøberID == Convert.ToInt32(Køber_Login.Køber_ID_LoggedIn) && SælgerID != -1 && Pris != -1 && M2 != -1 && By != null && PostNr != null && Adresse != null && Etager1 != -1 && Byggeår != -1 && Boligtype != null && Værelser != -1 && Energimærke != null && OprettelsesDato != null && HandelsDato != null)
            {
                try
                {
                    db.Køber_Ordre_MoveFromSoldToSales();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"{ex.Number}");
                }

                try
                {
                    db.Køber_Ordre_DeleteFromSold();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"{ex}");
                }

                try
                {
                    MessageBox.Show("Køb fjernet succesfuldt");
                    #region PassToGrid
                    DataTable tbl = db.Køber_Ordre_PassToGrid();
                    dataGridView1.DataSource = tbl;
                    #endregion PassToGrid
                }
                catch
                {
                    MessageBox.Show("GridView Fejl");
                }
            }
            else
            {
                MessageBox.Show("Købet du Forsøger at annulere eksisterer ikke");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.Køber_Ordre_Txt();
        }
    }
}
