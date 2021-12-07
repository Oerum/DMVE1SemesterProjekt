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

namespace WindowsFormsApp1.Forms.Køber
{
    public partial class Køber_Konto : Form
    {
        public static int ID { get; set; }
        public static string Tlf { get; set; }
        public static string Fornavn { get; set; }
        public static string Efternavn { get; set; }
        public static string Brugernavn { get; set; }
        public static string Kodeord { get; set; }
        
        public Køber_Konto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(Køber_Login.Køber_ID_LoggedIn);
                Tlf = textBox1.Text;
                Fornavn = textBox2.Text;
                Efternavn = textBox3.Text;
                Brugernavn = textBox4.Text;
                @Kodeord = textBox5.Text;
                DB db = new DB();

                db.Køber_KontoSQL();

                MessageBox.Show("De indtastede informationer er ændret");

                if (textBox4.Text != "")
                {
                    Køber_SinglePage.KSP.Close();
                }
                

            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"{ex}");
            }
        }
    }
}
 