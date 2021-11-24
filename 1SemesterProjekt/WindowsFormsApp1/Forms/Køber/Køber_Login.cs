﻿using MySql.Data.MySqlClient;
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
    public partial class Køber_Login : Form
    {
        public static string Køber_ID_LoggedIn { get; set; }
        public static string Køber_Tlf { get; set; }
        public static string Køber_Fornavn { get; set; }
        public static string Køber_Efternavn { get; set; }
        public static string Køber_Brugernavn { get; set; }
        static string Køber_Kodeord { get; set; }

        public Køber_Login()
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
                DB db = new DB();

                MySqlConnection conn = new MySqlConnection(db.ConnStr);


                string sql = "SELECT ID, Tlf, Fornavn, Efternavn, Brugernavn, CAST(AES_DECRYPT(UNHEX(Kodeord), 'somethingfunnyhere') as varchar(100)) FROM Køber WHERE Brugernavn = Brugernavn;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Brugernavn", textBox1.Text);

                conn.Open();

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Køber_ID_LoggedIn = Convert.ToString(rdr[0]);
                    Køber_Tlf = Convert.ToString(rdr[1]);
                    Køber_Fornavn = Convert.ToString(rdr[2]);
                    Køber_Efternavn = Convert.ToString(rdr[3]);
                    Køber_Brugernavn = Convert.ToString(rdr[4]);
                    Køber_Kodeord = Convert.ToString(rdr[5]);
                }
                rdr.Close();

                if (textBox1.Text == Køber_Brugernavn && textBox2.Text == Køber_Kodeord)
                {
                    Køber_SinglePage SP = new Køber_SinglePage();
                    SP.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Brugernavn eller Kodeord er ugyldigt");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Køber_Register register = new Køber_Register();
            register.Show();
            this.Hide();
        }
    }
}
