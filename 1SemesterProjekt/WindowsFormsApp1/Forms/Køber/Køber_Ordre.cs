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
        string BoligID { get; set; }
        string KøberID { get; set; }
        string SælgerID { get; set; }
        string Pris { get; set; }
        string M2 { get; set; }
        string PostNr { get; set; }
        string OprettelseDato { get; set; }
        string HandelsDato { get; set; }
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
                    Pris = Convert.ToString(rdr[3]);
                    M2 = Convert.ToString(rdr[4]);
                    PostNr = Convert.ToString(rdr[5]);
                    OprettelseDato = Convert.ToString(rdr[6]);
                    HandelsDato = Convert.ToString(rdr[7]);
                }
                rdr.Close();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error: {ex.Number} Bolig er ikke tilknyttet din konto");
            }

            if (BoligID != null && KøberID == Køber_Login.Køber_ID_LoggedIn && SælgerID != null && Pris != null && M2 != null && PostNr != null && OprettelseDato != null && HandelsDato != null)
            {
                try
                {
                    string cmd_Køb = "INSERT INTO BoligTilSalg (BoligID, SælgerID, Pris, M2, PostNr, OprettelsesDato) " +
                            "VALUES(@BoligID, @SælgerID, @Pris, @M2, @PostNr, @OprettelsesDato);";


                    MySqlCommand FjernKøb = new MySqlCommand(cmd_Køb, conn);
                    FjernKøb.Parameters.AddWithValue("@BoligID", int.Parse(BoligID));
                    FjernKøb.Parameters.AddWithValue("@SælgerID", int.Parse(SælgerID));
                    FjernKøb.Parameters.AddWithValue("@Pris", int.Parse(Pris));
                    FjernKøb.Parameters.AddWithValue("@M2", int.Parse(M2));
                    FjernKøb.Parameters.AddWithValue("@PostNr", PostNr);
                    FjernKøb.Parameters.AddWithValue("@OprettelsesDato", Convert.ToDateTime(OprettelseDato));


                    conn.Open();
                    FjernKøb.ExecuteNonQuery();
                    conn.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"{ex.Number}");
                }

                try
                {
                    string cmd_SletOrdre = "DELETE FROM SolgteBolig WHERE BoligID = @BoligID AND KøberID = @KøberID;";
                    MySqlCommand SletOrdre = new MySqlCommand(cmd_SletOrdre, conn);
                    SletOrdre.Parameters.AddWithValue("@BoligID", int.Parse(BoligID));
                    SletOrdre.Parameters.AddWithValue("@KøberID", int.Parse(Køber_Login.Køber_ID_LoggedIn));
                    conn.Open();
                    SletOrdre.ExecuteNonQuery();
                    conn.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"{ex}");
                }

                try
                {
                    MessageBox.Show("Køb fjernet succesfuldt");
                    #region PassToGrid
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
                catch
                {
                    MessageBox.Show("GridView Fejl");
                }
            }
            else
            {
                MessageBox.Show("Købet du Forsøger at annulere eksisterer ikke");
            }
            
        }
    }
}
