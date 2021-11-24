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
                DB db = new DB();

                MySqlConnection conn = new MySqlConnection(db.ConnStr);


                string sql = "INSERT INTO Køber(Tlf, Fornavn, Efternavn, Brugernavn, Kodeord) " +
                             "VALUES (@Tlf, @Fornavn, @Efternavn, @Brugernavn, HEX(AES_ENCRYPT(@Kodeord, 'somethingfunnyhere')));";


                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Tlf", textBox1.Text);
                cmd.Parameters.AddWithValue("@Fornavn", textBox3.Text);
                cmd.Parameters.AddWithValue("@Efternavn", textBox4.Text);
                cmd.Parameters.AddWithValue("@Brugernavn", textBox5.Text);
                cmd.Parameters.AddWithValue("@Kodeord", textBox6.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

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
