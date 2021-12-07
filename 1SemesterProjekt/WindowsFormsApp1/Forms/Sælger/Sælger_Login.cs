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

namespace WindowsFormsApp1.Forms.Sælger
{
    public partial class Sælger_Login : Form
    {
        public static string UserName { get; set; }
        public static string PassWord { get; set; }
        public static string Sælger_ID_LoggedIn { get; set; }
        public Sælger_Login()
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
                UserName = textBox1.Text;
                DB db = new DB();

                db.Sælger_LoginSQL();

                if (textBox1.Text == UserName && textBox2.Text == PassWord)
                {
                    Sælger SP = new Sælger();
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
    }
}
