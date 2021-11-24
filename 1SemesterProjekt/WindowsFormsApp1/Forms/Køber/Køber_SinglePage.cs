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
    public partial class Køber_SinglePage : Form
    {
        public static Køber_SinglePage KSP;
        public Køber_SinglePage()
        {
            KSP = this;
            InitializeComponent();
            textBox1.Text = Køber_Login.Køber_Brugernavn;
            panel1.Controls.Clear();
            Køber_Bolig KøbBolig = new Køber_Bolig();
            KøbBolig.TopLevel = false;
            KøbBolig.AutoScroll = true;
            panel1.Controls.Add(KøbBolig);
            KøbBolig.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Køber_Bolig KøbBolig = new Køber_Bolig();
            KøbBolig.TopLevel = false;
            KøbBolig.AutoScroll = true;
            panel1.Controls.Add(KøbBolig);
            KøbBolig.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Køber_Ordre KøberOrdre = new Køber_Ordre();
            KøberOrdre.TopLevel = false;
            KøberOrdre.AutoScroll = true;
            panel1.Controls.Add(KøberOrdre);
            KøberOrdre.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Køber_Konto Køber_konto = new Køber_Konto();
            Køber_konto.TopLevel = false;
            Køber_konto.AutoScroll = true;
            panel1.Controls.Add(Køber_konto);
            Køber_konto.Show();
        }
    }
}
