﻿using DAL;
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
    public partial class Køber_Login : Form
    {
        public static int Køber_ID_LoggedIn { get; set; }
        public static string Køber_Tlf { get; set; }
        public static string Køber_Fornavn { get; set; }
        public static string Køber_Efternavn { get; set; }
        public static string Køber_Brugernavn { get; set; }
        public static string Køber_Kodeord { get; set; }

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
                Køber_Brugernavn = textBox1.Text;

                db.Køber_LoginSQL();

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
