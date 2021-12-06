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
    public partial class Køber_Bolig : Form
    {
        string BoligID { get; set; }
        string SælgerID { get; set; }
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
        string OprettelsesDato { get; set; }

        public Køber_Bolig()
        {
            InitializeComponent();
            try
            {
                #region PassToGrid
                DB db = new DB();
                MySqlConnection conn = new MySqlConnection(db.ConnStr);
                DataTable tbl = new DataTable();
                string sqlshow = "SELECT * FROM BoligTilSalg;";
                MySqlCommand cmd1 = new MySqlCommand(sqlshow, conn);
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
                try
                {
                    string cmd_BoligValg = "SELECT * FROM BoligTilSalg Where BoligID = @BoligID";

                    MySqlCommand BoligValg = new MySqlCommand(cmd_BoligValg, conn);
                    BoligValg.Parameters.AddWithValue("@BoligID", Convert.ToInt32(textBox1.Text));

                    conn.Open();
                    MySqlDataReader rdr = BoligValg.ExecuteReader();
                    while (rdr.Read())
                    {
                        BoligID = Convert.ToString(rdr[0]);
                        SælgerID = Convert.ToString(rdr[1]);
                        Pris = Convert.ToString(rdr[2]);
                        M2 = Convert.ToString(rdr[3]);
                        By = Convert.ToString(rdr[4]);
                        PostNr = Convert.ToString(rdr[5]);
                        Adresse = Convert.ToString(rdr[6]);
                        Etager = Convert.ToString(rdr[7]);
                        Byggeår = Convert.ToString(rdr[8]);
                        Boligtype = Convert.ToString(rdr[9]);
                        Værelser = Convert.ToString(rdr[10]);
                        Energimærke = Convert.ToString(rdr[11]);
                        OprettelsesDato = Convert.ToString(rdr[12]);
                    }
                    rdr.Close();
                    conn.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"{ex.Number}");
                }

                if (BoligID != null && Køber_Login.Køber_ID_LoggedIn != null && Pris != null && M2 != null && PostNr != null && PostNr != null && OprettelsesDato != null)
                {
                    try
                    {

                        string cmd_Køb = "INSERT INTO SolgteBolig (BoligID, KøberID, SælgerID, Pris, M2, `By`, PostNr, Adresse, Etager, Byggeår, Boligtype, Værelser, Energimærke, OprettelsesDato, HandelsDato) " +
                            "VALUES(@BoligID, @KøberID, @SælgerID, @Pris, @M2, @By, @PostNr, @Adresse, @Etager, @Byggeår, @Boligtype, @Værelser, @Energimærke, @OprettelsesDato, CURRENT_DATE);";


                        MySqlCommand Køb = new MySqlCommand(cmd_Køb, conn);
                        Køb.Parameters.AddWithValue("@BoligID", Convert.ToInt32(BoligID));
                        Køb.Parameters.AddWithValue("@KøberID", Convert.ToInt32(Køber_Login.Køber_ID_LoggedIn));
                        Køb.Parameters.AddWithValue("@SælgerID", Convert.ToInt32(SælgerID));
                        Køb.Parameters.AddWithValue("@Pris", Convert.ToInt32(Pris));
                        Køb.Parameters.AddWithValue("@M2", Convert.ToInt32(M2));
                        Køb.Parameters.AddWithValue("@By", By);
                        Køb.Parameters.AddWithValue("@PostNr", PostNr);
                        Køb.Parameters.AddWithValue("@Adresse", Adresse);
                        Køb.Parameters.AddWithValue("@Etager", Etager);
                        Køb.Parameters.AddWithValue("@Byggeår", Byggeår);
                        Køb.Parameters.AddWithValue("@Boligtype", Boligtype);
                        Køb.Parameters.AddWithValue("@Værelser", Convert.ToInt32(Værelser));
                        Køb.Parameters.AddWithValue("@Energimærke", Energimærke);
                        Køb.Parameters.AddWithValue("@OprettelsesDato", Convert.ToDateTime(OprettelsesDato));


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
                        MessageBox.Show($"{"Noget gik galt " + ex.Number}");
                    }

                    try
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
                    catch
                    {
                        MessageBox.Show("GridView Fejl");
                    }
                }
                else
                {
                    MessageBox.Show("Boligen du forsøger at købe eksisterer ikke");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Feltet er tomt");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlConnection conn = new MySqlConnection(db.ConnStr);

            string filePath = @"..\..\txts\BoligTilSalg.txt";
            /*
            if (!File.Exists(filePath))
            {
                File.CreateText(filePath).Dispose();
            }
            */

            string cmd_TxtPrint = "SELECT * FROM BoligTilSalg";
            MySqlCommand TxtPrint = new MySqlCommand(cmd_TxtPrint, conn);


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
                        $"\tSælgerID: {Convert.ToString(rdr[1])}\n" +
                        $"\tPris: {Convert.ToString(rdr[2])}\n" +
                        $"\tM2: {Convert.ToString(rdr[3])}\n" +
                        $"\tBy: {Convert.ToString(rdr[4])}\n" +
                        $"\tPostNr: {Convert.ToString(rdr[5])}\n" +
                        $"\tAdresse: {Convert.ToString(rdr[6])}\n" +
                        $"\tEtager: {Convert.ToString(rdr[7])}\n" +
                        $"\tByggeår: {Convert.ToString(rdr[8])}\n" +
                        $"\tBoligtype: {Convert.ToString(rdr[9])}\n" +
                        $"\tVærelser: {Convert.ToString(rdr[10])}\n" +
                        $"\tEnergimærke: {Convert.ToString(rdr[11])}\n" +
                        $"\tOprettelsesDato: {Convert.ToString(rdr[12])}\n" +
                        "}\n");
                }
            }
            rdr.Close();
            conn.Close();
            MessageBox.Show($"Fil Hentet: {filePath}");
        }
    }
}
