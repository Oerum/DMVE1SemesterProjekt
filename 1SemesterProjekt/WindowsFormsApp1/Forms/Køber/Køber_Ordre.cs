using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms.Køber
{
    public partial class Køber_Ordre : Form
    {
        string BoligID { get; set; }
        string SælgerID { get; set; }
        string KøberID { get; set; }
        string Pris { get; set; }
        string M2 { get; set; }
        string By { get; set; }
        string PostNr { get; set; }
        string Adresse { get; set; }
        string Etager { get; set; }
        string Byggeår { get; set; }
        string Boligtype { get; set; }
        string Værelser { get; set; }
        string Energimærke { get; set; }
        string Oprettelsesdato { get; set; }
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
                    By = Convert.ToString(rdr[5]);
                    PostNr = Convert.ToString(rdr[6]);
                    Adresse = Convert.ToString(rdr[7]);
                    Etager = Convert.ToString(rdr[8]);
                    Byggeår = Convert.ToString(rdr[9]);
                    Boligtype = Convert.ToString(rdr[10]);
                    Værelser = Convert.ToString(rdr[11]);
                    Energimærke = Convert.ToString(rdr[12]);
                    Oprettelsesdato = Convert.ToString(rdr[13]);
                    HandelsDato = Convert.ToString(rdr[14]);
                }
                rdr.Close();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error: {ex.Number} Bolig er ikke tilknyttet din konto");
            }

            if (BoligID != null && KøberID == Køber_Login.Køber_ID_LoggedIn && SælgerID != null && Pris != null && M2 != null && By != null && PostNr != null && Adresse != null && Etager != null && Byggeår != null && Boligtype != null && Værelser != null && Energimærke != null && Oprettelsesdato != null && HandelsDato != null)
            {
                try
                {
                    string cmd_Køb = "INSERT INTO BoligTilSalg(BoligID, SælgerID, Pris, M2, `By`, PostNr, Adresse, Etager, Byggeår, Boligtype, Værelser, Energimærke, OprettelsesDato) " +
                                 "VALUES(@BoligID, @SælgerID, @Pris, @M2, @By, @PostNr, @Adresse, @Etager, @Byggeår, @Boligtype, @Værelser, @Energimærke, @OprettelsesDato);";


                    MySqlCommand FjernKøb = new MySqlCommand(cmd_Køb, conn);
                    FjernKøb.Parameters.AddWithValue("@BoligID", Convert.ToInt32(BoligID));
                    FjernKøb.Parameters.AddWithValue("@KøberID", Convert.ToInt32(KøberID));
                    FjernKøb.Parameters.AddWithValue("@SælgerID", Convert.ToInt32(SælgerID));
                    FjernKøb.Parameters.AddWithValue("@Pris", Convert.ToInt32(Pris));
                    FjernKøb.Parameters.AddWithValue("@M2", Convert.ToInt32(M2));
                    FjernKøb.Parameters.AddWithValue("@By", By);
                    FjernKøb.Parameters.AddWithValue("@PostNr", PostNr);
                    FjernKøb.Parameters.AddWithValue("@Adresse", Adresse);
                    FjernKøb.Parameters.AddWithValue("@Etager", Etager);
                    FjernKøb.Parameters.AddWithValue("@Byggeår", Byggeår);
                    FjernKøb.Parameters.AddWithValue("@Boligtype", Boligtype);
                    FjernKøb.Parameters.AddWithValue("@Værelser", Værelser);
                    FjernKøb.Parameters.AddWithValue("@Energimærke", Energimærke);
                    FjernKøb.Parameters.AddWithValue("@OprettelsesDato", Convert.ToDateTime(Oprettelsesdato));


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

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlConnection conn = new MySqlConnection(db.ConnStr);

            string filePath = @"..\..\txts\KøbteBolig.txt";
            /*
            if (!File.Exists(filePath))
            {
                File.CreateText(filePath).Dispose();
            }
            */

            string cmd_TxtPrint = "SELECT * FROM SolgteBolig Where KøberID = @KøberID";
            MySqlCommand TxtPrint = new MySqlCommand(cmd_TxtPrint, conn);
            TxtPrint.Parameters.AddWithValue("@KøberID", Køber_Login.Køber_ID_LoggedIn);


            conn.Open();
            MySqlDataReader rdr = TxtPrint.ExecuteReader();

            // Change the Encoding to what you need here (UTF8, Unicode, etc)
            using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                int x = 0;
                while (rdr.Read())
                {
                    x++;
                    writer.WriteLine(
                        "{\n" +
                        $"\tNR: {x}\n" +
                        $"\tBoligID: {Convert.ToString(rdr[0])}\n" +
                        $"\tKøberID: {Convert.ToString(rdr[1])}\n" +
                        $"\tSælgerID: {Convert.ToString(rdr[2])}\n" +
                        $"\tPris: {Convert.ToString(rdr[3])}\n" +
                        $"\tM2: {Convert.ToString(rdr[4])}\n" +
                        $"\tBy: {Convert.ToString(rdr[5])}\n" +
                        $"\tPostNr: {Convert.ToString(rdr[6])}\n" +
                        $"\tAdresse: {Convert.ToString(rdr[7])}\n" +
                        $"\tEtager: {Convert.ToString(rdr[8])}\n" +                               
                        $"\tByggeår: {Convert.ToString(rdr[9])}\n" +
                        $"\tBoligtype: {Convert.ToString(rdr[10])}\n" +
                        $"\tVærelser: {Convert.ToString(rdr[11])}\n" +
                        $"\tEnergimærke: {Convert.ToString(rdr[12])}\n" +
                        $"\tOprettelsesDato: {Convert.ToString(rdr[13])}\n" +
                        $"\tHandelsDato: {Convert.ToString(rdr[14])}\n" +
                        "}\n"); ;
                }
            }
            rdr.Close();
            conn.Close();
            MessageBox.Show($"Fil Hentet: {filePath}");
        }
    }
}
