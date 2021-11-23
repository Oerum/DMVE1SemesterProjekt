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
    public partial class Sælger_OpdaterBolig : Form
    {
        public Sælger_OpdaterBolig()
        {

            InitializeComponent();
            #region PassToGrid
            DB db = new DB();
            MySqlConnection conn = new MySqlConnection(db.ConnStr);
            DataTable tbl = new DataTable();
            string sqlshow = "SELECT * FROM BoligTilSalg Where SælgerID = @ID;";
            MySqlCommand cmd1 = new MySqlCommand(sqlshow, conn);
            cmd1.Parameters.AddWithValue("@ID", int.Parse(Sælger_Login.Sælger_ID_LoggedIn));
            conn.Open();
            tbl.Load(cmd1.ExecuteReader());
            dataGridView1.DataSource = tbl;
            conn.Close();
            #endregion PassToGrid
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string SælgerID = "";
            string Pris = "";

            try
            {
                DB db = new DB();
                MySqlConnection conn = new MySqlConnection(db.ConnStr);

                string sql = "SELECT * FROM BoligTilSalg WHERE BoligID = @BoligID AND SælgerID = @SælgerID;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@SælgerID", int.Parse(Sælger_Login.Sælger_ID_LoggedIn));
                cmd.Parameters.AddWithValue("@BoligID", int.Parse(textBox1.Text));

                conn.Open();

                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    SælgerID = Convert.ToString(rdr[1]);
                    Pris = Convert.ToString(rdr[2]);
                }
                rdr.Close();

                if (Sælger_Login.Sælger_ID_LoggedIn == SælgerID)
                {
                    cmd.ExecuteNonQuery();
                    textBox2.Text = SælgerID;
                    textBox3.Text = Pris;

                }
                else
                {
                    #region PassToGrid
                    MessageBox.Show("Du er ikke tilknyttet boligen du forsøger at ændre");
                    DataTable tbl = new DataTable();
                    string sqlshow = "SELECT * FROM BoligTilSalg Where SælgerID = @ID;";
                    MySqlCommand cmd1 = new MySqlCommand(sqlshow, conn);
                    cmd1.Parameters.AddWithValue("@ID", int.Parse(Sælger_Login.Sælger_ID_LoggedIn));
                    tbl.Load(cmd1.ExecuteReader());
                    dataGridView1.DataSource = tbl;
                    #endregion PassToGrid
                }


                conn.Close();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                MySqlConnection conn = new MySqlConnection(db.ConnStr);

                string sql = "UPDATE BoligTilSalg SET Pris = @Pris WHERE BoligID = @BoligID AND SælgerID = @SælgerID;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("@SælgerID", int.Parse(Sælger_Login.Sælger_ID_LoggedIn));
                cmd.Parameters.AddWithValue("@BoligID", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@Pris", int.Parse(textBox3.Text));

                conn.Open();


                if (Sælger_Login.Sælger_ID_LoggedIn == textBox2.Text)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fuldført");
                    #region PassToGrid
                    DataTable tbl = new DataTable();
                    string sqlshow = "SELECT * FROM BoligTilSalg Where SælgerID = @ID;";
                    MySqlCommand cmd1 = new MySqlCommand(sqlshow, conn);
                    cmd1.Parameters.AddWithValue("@ID", int.Parse(Sælger_Login.Sælger_ID_LoggedIn));
                    tbl.Load(cmd1.ExecuteReader());
                    dataGridView1.DataSource = tbl;
                    #endregion PassToGrid
                }
                else
                {
                    MessageBox.Show($"Du er ikke tilknyttet boligen du forsøger at ændre");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }
    }
}
