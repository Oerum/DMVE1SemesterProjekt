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
        public Køber_SinglePage()
        {
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
    }
}
