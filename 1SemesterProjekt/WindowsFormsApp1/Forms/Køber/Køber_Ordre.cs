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
    public partial class Køber_Ordre : Form
    {
        public Køber_Ordre()
        {
            InitializeComponent();
            try
            {
                #region PassToGrid
                DB db = new DB();
                MySqlConnection conn = new MySqlConnection(db.ConnStr);
                DataTable tbl = new DataTable();
                string sqlshow = "SELECT * FROM SolgteBolig WHERE KøberID = @KøberID;";
                MySqlCommand cmd1 = new MySqlCommand(sqlshow, conn);
                cmd1.Parameters.AddWithValue("@KøberID", Køber_Login.Køber_ID_LoggedIn);
                conn.Open();
                tbl.Load(cmd1.ExecuteReader());
                dataGridView1.DataSource = tbl;
                conn.Close();
                #endregion PassToGrid
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlConnection conn = new MySqlConnection(db.ConnStr);

            string BoligID = "";
            string KøberID = "";
            string SælgerID = "";
            string Pris = "";
            string M2 = "";
            string PostNr = "";
            string Dato = "";

            try
            {
                try
                {
                    string cmd_KøbtBoligLoad = "SELECT * FROM SolgteBolig Where BoligID = @BoligID AND KøberID = @KøberID";

                    MySqlCommand KøbtBoligLoad = new MySqlCommand(cmd_KøbtBoligLoad, conn);
                    KøbtBoligLoad.Parameters.AddWithValue("@BoligID", int.Parse(textBox1.Text));
                    KøbtBoligLoad.Parameters.AddWithValue("@KøberID", int.Parse(Køber_Login.Køber_ID_LoggedIn));

                    conn.Open();
                    MySqlDataReader rdr = KøbtBoligLoad.ExecuteReader();
                    while (rdr.Read())
                    {
                        BoligID = Convert.ToString(rdr[0]);
                        KøberID = Convert.ToString(rdr[1]);
                        SælgerID = Convert.ToString(rdr[2]);
                        Pris = Convert.ToString(rdr[2]);
                        M2 = Convert.ToString(rdr[3]);
                        PostNr = Convert.ToString(rdr[4]);
                        Dato = Convert.ToString(rdr[5]);
                    }
                    rdr.Close();
                    conn.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error: {ex.Number} Bolig er ikke tilknyttet din konto");
                }

                try
                {
                    string cmd_Køb = "INSERT INTO SolgteBolig (BoligID, KøberID, SælgerID, Pris, M2, PostNr, HandelsDato) " +
                           "VALUES(@BoligID, @KøberID, @SælgerID, @Pris, @M2, @PostNr, CURRENT_TIMESTAMP);";


                    MySqlCommand Køb = new MySqlCommand(cmd_Køb, conn);
                    Køb.Parameters.AddWithValue("@BoligID", int.Parse(textBox1.Text));
                    Køb.Parameters.AddWithValue("@KøberID", int.Parse(Køber_Login.Køber_ID_LoggedIn));
                    Køb.Parameters.AddWithValue("@SælgerID", int.Parse(SælgerID));
                    Køb.Parameters.AddWithValue("@Pris", int.Parse(Pris));
                    Køb.Parameters.AddWithValue("@M2", int.Parse(M2));
                    Køb.Parameters.AddWithValue("@PostNr", PostNr);


                    conn.Open();
                    Køb.ExecuteNonQuery();
                    conn.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"{ex.Number}");
                }

                try
                {
                    string cmd_Slet = "DELETE FROM BoligTilSalg WHERE BoligID = @BoligID;";
                    MySqlCommand Slet = new MySqlCommand(cmd_Slet, conn);
                    Slet.Parameters.AddWithValue("@BoligID", int.Parse(BoligID));
                    conn.Open();
                    Slet.ExecuteNonQuery();
                    conn.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"{ex.Number}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
            finally
            {
                MessageBox.Show("Køb succesfuld");
                #region PassToGrid
                DataTable tbl = new DataTable();
                string sqlshow = "SELECT * FROM BoligTilSalg;";
                MySqlCommand cmd1 = new MySqlCommand(sqlshow, conn);
                conn.Open();
                tbl.Load(cmd1.ExecuteReader());
                dataGridView1.DataSource = tbl;
                conn.Close();
                #endregion PassToGrid
            }
        }
    }
}
