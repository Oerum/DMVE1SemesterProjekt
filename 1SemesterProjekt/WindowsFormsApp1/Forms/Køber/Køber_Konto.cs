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
    public partial class Køber_Konto : Form
    {

        public Køber_Konto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();

                MySqlConnection conn = new MySqlConnection(db.ConnStr);


                string sql = "UPDATE Køber SET ";
                if (textBox1.Text != "")
                {
                    sql += "Tlf = @Tlf "; 
                        if (textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "" || textBox5.Text != "")
                        {
                            sql += ",";
                        }
                }
                if (textBox2.Text != "")
                {
                    sql += "Fornavn = @Fornavn ";
                        if (textBox3.Text != "" || textBox4.Text != "" || textBox5.Text != "")
                        {
                            sql += ",";
                        }
                }
                if (textBox3.Text != "")
                {
                    sql += "Efternavn = @Efternavn ";
                    if (textBox4.Text != "" || textBox5.Text != "")
                    {
                        sql += ",";
                    }
                }
                if (textBox4.Text != "")
                {
                    sql += "Brugernavn = @Brugernavn ";
                    if (textBox5.Text != "")
                    {
                        sql += ",";
                    }
                }
                if (textBox5.Text != "")
                {
                    sql += "Kodeord = HEX(AES_ENCRYPT(@Kodeord, 'somethingfunnyhere'))";

                }

                sql += "WHERE ID = @ID";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", int.Parse(Køber_Login.Køber_ID_LoggedIn));
                cmd.Parameters.AddWithValue("@Tlf", textBox1.Text);
                cmd.Parameters.AddWithValue("@Fornavn", textBox2.Text);
                cmd.Parameters.AddWithValue("@Efternavn", textBox3.Text);
                cmd.Parameters.AddWithValue("@Brugernavn", textBox4.Text);
                cmd.Parameters.AddWithValue("@Kodeord", textBox5.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("De indtastede informationer er ændret");

                if (textBox4.Text != "")
                {
                    Køber_SinglePage.KSP.Close();
                }
                

            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"{ex}");
            }
        }
    }
}
 