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
        public static Ejendomsmægler_Login instance;
        public Ejendomsmægler_Login()
        {
            InitializeComponent();
            instance = this;
            //this.ordreTableAdapter1.Fill(this.afleveringDataSet1.Ordre);

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


                string sql = "SELECT Brugernavn, CAST(AES_DECRYPT(UNHEX(Kodeord), 'somethingfunnyhere') as varchar(100)) as 'Kodeord' FROM Ejendomsmaegler WHERE Brugernavn = Brugernavn;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Brugernavn", textBox1.Text);

                conn.Open();
                
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    UserName = Convert.ToString(rdr[0]);
                    PassWord = Convert.ToString(rdr[1]);

                }
                rdr.Close();

                if (textBox1.Text == UserName && textBox2.Text == PassWord)
                {
                    Ejendomsmægler_SinglePage Ej = new Ejendomsmægler_SinglePage();
                    MessageBox.Show("Godkendt");
                    Ej.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }
    }
}
