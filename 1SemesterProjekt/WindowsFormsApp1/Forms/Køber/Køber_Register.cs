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
    public partial class Køber_Register : Form
    {
        public static string Tlf { get; set; }
        public static string Fornavn { get; set; }
        public static string Efternavn { get; set; }
        public static string Brugernavn { get; set; }
        public static string Kodeord { get; set; }

        public Køber_Register()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Tlf = textBox1.Text;
                Fornavn = textBox3.Text;
                Efternavn = textBox4.Text;
                Brugernavn = textBox5.Text;
                Kodeord = textBox6.Text;

                DB db = new DB();

                db.Køber_OpretBruger();

                MessageBox.Show("Bruger Oprettet");

                Køber_Login login = new Køber_Login();
                login.Show();
                this.Hide();
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
