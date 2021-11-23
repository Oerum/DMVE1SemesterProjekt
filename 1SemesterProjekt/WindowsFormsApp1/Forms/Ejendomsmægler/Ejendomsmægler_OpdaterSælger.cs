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

namespace WindowsFormsApp1.Forms.Ejendomsmægler
{
    public partial class Ejendomsmægler_OpdaterSælger : Form
    {
        public Ejendomsmægler_OpdaterSælger()
        {
            InitializeComponent();
            #region PassToGrid
            DB db = new DB();
            MySqlConnection conn = new MySqlConnection(db.ConnStr);
            DataTable tbl = new DataTable();
            string sqlshow = "SELECT * FROM Sælger;";
            MySqlCommand cmd1 = new MySqlCommand(sqlshow, conn);
            conn.Open();
            tbl.Load(cmd1.ExecuteReader());
            dataGridView1.DataSource = tbl;
            conn.Close();
            #endregion PassToGrid
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ID = "";
            string Tlf = "";
            string Fornavn = "";
            string Efternavn = "";
            string Brugernavn = "";
            string Kodeord = "";
            try
            {
                DB db = new DB();

                MySqlConnection conn = new MySqlConnection(db.ConnStr);


                string sql = "SELECT * FROM Sælger WHERE ID = @ID;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));

                conn.Open();
                cmd.ExecuteNonQuery();

                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ID = Convert.ToString(rdr[0]);
                    Tlf = Convert.ToString(rdr[1]);
                    Fornavn = Convert.ToString(rdr[2]);
                    Efternavn = Convert.ToString(rdr[3]);
                    Brugernavn = Convert.ToString(rdr[4]);
                    Kodeord = Convert.ToString(rdr[5]);
                }
                rdr.Close();
                conn.Close();
                textBox1.Text = ID;
                textBox2.Text = Tlf;
                textBox3.Text = Fornavn;
                textBox4.Text = Efternavn;
                textBox5.Text = Brugernavn;
                textBox6.Text = Kodeord;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                MySqlConnection conn = new MySqlConnection(db.ConnStr);

                string sql = "UPDATE Sælger SET Tlf = @Tlf, Fornavn = @Fornavn, Efternavn = @Efternavn, Brugernavn = @Brugernavn, Kodeord = HEX(AES_ENCRYPT(@Kodeord, 'somethingfunnyhere')) WHERE ID = @ID;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@Tlf", textBox2.Text);
                cmd.Parameters.AddWithValue("@Fornavn", textBox3.Text);
                cmd.Parameters.AddWithValue("@Efternavn", textBox4.Text);
                cmd.Parameters.AddWithValue("@Brugernavn", textBox5.Text);
                cmd.Parameters.AddWithValue("@Kodeord", textBox6.Text);

                conn.Open();

                if (textBox1.Text != null && textBox2.Text != null && textBox3.Text != null && textBox4.Text != null && textBox5.Text != null && textBox6.Text != null)
                {
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Indtast gyldig information i alle kolonner");
                }

                #region PassToGrid
                DataTable tbl = new DataTable();
                string sqlshow = "SELECT * FROM Sælger";
                MySqlCommand cmd1 = new MySqlCommand(sqlshow, conn);
                tbl.Load(cmd1.ExecuteReader());
                dataGridView1.DataSource = tbl;
                MessageBox.Show("Done");
                conn.Close();
                #endregion PassToGrid

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }
    }
}
