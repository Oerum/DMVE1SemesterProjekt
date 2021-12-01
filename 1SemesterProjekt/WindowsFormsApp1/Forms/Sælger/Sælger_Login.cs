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
            string UserName = "";
            string PassWord = "";
            try
            {
                DB db = new DB();

                MySqlConnection conn = new MySqlConnection(db.ConnStr);


                string sql = "SELECT ID, Brugernavn, CAST(AES_DECRYPT(UNHEX(Kodeord), 'somethingfunnyhere') as varchar(100)) FROM Sælger WHERE Brugernavn = @Brugernavn;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Brugernavn", textBox1.Text);

                conn.Open();

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Sælger_ID_LoggedIn = Convert.ToString(rdr[0]);
                    UserName = Convert.ToString(rdr[1]);
                    PassWord = Convert.ToString(rdr[2]);
                }
                rdr.Close();

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
