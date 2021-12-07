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
    public partial class Ejendomsmægler_Login : Form
    {
        public static string EjendomsmæglerUserName { get; set; }
        public static string EjendomsmæglerPassWord { get; set; }

        public Ejendomsmægler_Login()
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

                db.Ejendomsmægler_LoginSQL();

                if (textBox1.Text == EjendomsmæglerUserName && textBox2.Text == EjendomsmæglerPassWord)
                {
                    Ejendomsmælger_SinglePage Ej = new Ejendomsmægler_SingePage();
                    Ej.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Brugernavn eller Kodeord er ugyldigt");
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1042)
                {
                    MessageBox.Show("Kunne ikke oprette forbindelse til server");
                }
                MessageBox.Show($"{ex.Number}");
            }
        }

        private class Ejendomsmægler_SingePage : Ejendomsmælger_SinglePage
        {
        }
    }
}
