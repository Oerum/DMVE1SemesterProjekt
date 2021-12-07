using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.Forms.Ejendomsmægler;
using WindowsFormsApp1.Forms.Køber;
using WindowsFormsApp1.Forms.Sælger;

namespace DAL
{
    public class DB
    {
        public string ConnStr { get; set; }
        public DB()
        {
            ConnStr = "server=boundsoul1937.asuscomm.com;port=80;database=Ejendomsmægler;user=LicenseConnect;password=test12341234;SslMode=none;";
        }

        #region Ejendomsmægler
        public void Ejendommægler_InputDatoSQL()
        {
            MySqlConnection conn = new MySqlConnection(ConnStr);


            string sql = "SELECT *" +
                        "\nFROM SolgteBolig sb" +
                        "\nWHERE HandelsDato BETWEEN @Dato1 AND @Dato2" +
                        "\nORDER BY SælgerID ASC;";


            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Dato1", Ejendomsmægler_InputDato.Dato1);
            cmd.Parameters.AddWithValue("@Dato2", Ejendomsmægler_InputDato.Dato2);

            conn.Open();
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                BoligUdtræk newItem = new BoligUdtræk();

                newItem.SælgerID = Convert.ToInt32(rdr[2]);
                newItem.BoligID = Convert.ToInt32(rdr[0]);
                newItem.KøberID = Convert.ToInt32(rdr[1]);
                newItem.Pris = Convert.ToInt32(rdr[3]);
                newItem.M2 = Convert.ToInt32(rdr[4]);
                newItem.By = Convert.ToString(rdr[5]);
                newItem.PostNr = Convert.ToString(rdr[6]);
                newItem.Adresse = Convert.ToString(rdr[7]);
                newItem.Etager = Convert.ToInt32(rdr[8]);
                newItem.Byggeår = Convert.ToInt32(rdr[9]);
                newItem.Boligtype = Convert.ToString(rdr[10]);
                newItem.Værelser = Convert.ToInt32(rdr[11]);
                newItem.Energimærke = Convert.ToString(rdr[12]);
                newItem.OprettelsesDato = Convert.ToString(rdr[13]);
                newItem.HandelsDato = Convert.ToString(rdr[14]);

                Ejendomsmægler_InputDato.BoligUdtrækList.Add(newItem);
            }
            rdr.Close();
            conn.Close();
        }

        public void Ejendomsmægler_InputPostNrSQL()
        {
            MySqlConnection conn = new MySqlConnection(ConnStr);

            string filePath = @"..\..\txts\BoligTilSalgPostNr.txt";
            /*
            if (!File.Exists(filePath))
            {
                File.CreateText(filePath).Dispose();
            }
            */
            string cmd_TxtPrint = "SELECT * FROM SolgteBolig WHERE PostNr = @PostNr";
            MySqlCommand TxtPrint = new MySqlCommand(cmd_TxtPrint, conn);
            TxtPrint.Parameters.AddWithValue("@PostNr", Ejendomsmægler_InputPostNr.InputPostNr);

            conn.Open();
            MySqlDataReader rdr = TxtPrint.ExecuteReader();

            // Change the Encoding to what you need here (UTF8, Unicode, etc)
            using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                while (rdr.Read())
                {
                    int Sum = 0;
                    Sum += Convert.ToInt32(rdr[3]);
                    writer.WriteLine(

                        "{\n" +
                        $"\tPostNr: {Convert.ToString(rdr[6])}\n" +
                        $"\tBoligID: {Convert.ToString(rdr[0])}\n" +
                        $"\tKøberID: {Convert.ToString(rdr[1])}\n" +
                        $"\tSælgerID: {Convert.ToString(rdr[2])}\n" +
                        $"\tPris: {Convert.ToString(rdr[3])}\n" +
                        $"\tM2: {Convert.ToString(rdr[4])}\n" +
                        $"\tBy: {Convert.ToString(rdr[5])}\n" +
                        $"\tAdresse: {Convert.ToString(rdr[7])}\n" +
                        $"\tEtage: {Convert.ToString(rdr[8])}\n" +
                        $"\tByggeår: {Convert.ToString(rdr[9])}\n" +
                        $"\tBoligtype: {Convert.ToString(rdr[10])}\n" +
                        $"\tVærelser: {Convert.ToString(rdr[11])}\n" +
                        $"\tEnergimærke: {Convert.ToString(rdr[12])}\n" +
                        $"\tOprettelsesDato: {Convert.ToString(rdr[13])}\n" +
                        $"\tHandelsDato: {Convert.ToString(rdr[14])}\n" +
                        "}\n" +
                        "\n");
                }
            }
            rdr.Close();
            conn.Close();
            MessageBox.Show($"Fil Hentet: {filePath}");
        }

        public void Ejendomsmægler_LoginSQL()
        {
            MySqlConnection conn = new MySqlConnection(ConnStr);


            string sql = "SELECT Brugernavn, CAST(AES_DECRYPT(UNHEX(Kodeord), 'somethingfunnyhere') as varchar(100)) as 'Kodeord' FROM Ejendomsmaegler WHERE Brugernavn = Brugernavn;";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            Ejendomsmægler_Login EjLogin = new Ejendomsmægler_Login();

            cmd.Parameters.AddWithValue("@Brugernavn", EjLogin.textBox1.Text);

            conn.Open();

            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Ejendomsmægler_Login.EjendomsmæglerUserName = Convert.ToString(rdr[0]);
                Ejendomsmægler_Login.EjendomsmæglerPassWord = Convert.ToString(rdr[1]);

            }
            rdr.Close();
        }

        public void Ejendomsmægler_OpdaterBoligButton2SQL()
        {
            MySqlConnection conn = new MySqlConnection(ConnStr);


            string sql = "SELECT * FROM BoligTilSalg WHERE BoligID = @BoligID;";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@BoligID", Ejendomsmægler_OpdaterBolig.BoligID);

            conn.Open();

            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Ejendomsmægler_OpdaterBolig.BoligID = Convert.ToInt32(rdr[0]);
                Ejendomsmægler_OpdaterBolig.SælgerID = Convert.ToInt32(rdr[1]);
                Ejendomsmægler_OpdaterBolig.Pris = Convert.ToInt32(rdr[2]);
                Ejendomsmægler_OpdaterBolig.M2 = Convert.ToInt32(rdr[3]);
                Ejendomsmægler_OpdaterBolig.By = Convert.ToString(rdr[4]);
                Ejendomsmægler_OpdaterBolig.PostNr = Convert.ToString(rdr[5]);
                Ejendomsmægler_OpdaterBolig.Adresse = Convert.ToString(rdr[6]);
                Ejendomsmægler_OpdaterBolig.Etager1 = Convert.ToInt32(rdr[7]);
                Ejendomsmægler_OpdaterBolig.Byggeår = Convert.ToInt32(rdr[8]);
                Ejendomsmægler_OpdaterBolig.Boligtype = Convert.ToString(rdr[9]);
                Ejendomsmægler_OpdaterBolig.Værelser = Convert.ToInt32(rdr[10]);
                Ejendomsmægler_OpdaterBolig.Energimærke = Convert.ToString(rdr[11]);
                Ejendomsmægler_OpdaterBolig.OprettelsesDato = Convert.ToString(rdr[12]);

            }
            rdr.Close();
            conn.Close();
            
        }

        public void Ejendomsmægler_OpdaterBoligButton1SQL()
        {
            MySqlConnection conn = new MySqlConnection(ConnStr);
            Ejendomsmægler_OpdaterBolig obj = new Ejendomsmægler_OpdaterBolig();

            string sql = "UPDATE BoligTilSalg SET SælgerID = @SælgerID, Pris = @Pris, M2 = @M2, `By` = @By, PostNr = @PostNr, Adresse = @Adresse, Etager = @Etager, Byggeår = @Byggeår, Boligtype = @Boligtype, Værelser = @Værelser, Energimærke = @Energimærke WHERE BoligID = @BoligID;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@BoligID", Convert.ToInt32(Ejendomsmægler_OpdaterBolig.BoligID));
            cmd.Parameters.AddWithValue("@SælgerID", Convert.ToInt32(Ejendomsmægler_OpdaterBolig.SælgerID));
            cmd.Parameters.AddWithValue("@Pris", Convert.ToInt32(Ejendomsmægler_OpdaterBolig.Pris));
            cmd.Parameters.AddWithValue("@M2", Convert.ToInt32(Ejendomsmægler_OpdaterBolig.M2));
            cmd.Parameters.AddWithValue("@By", Ejendomsmægler_OpdaterBolig.By);
            cmd.Parameters.AddWithValue("@PostNr", Ejendomsmægler_OpdaterBolig.PostNr);
            cmd.Parameters.AddWithValue("@Adresse", Ejendomsmægler_OpdaterBolig.Adresse);
            cmd.Parameters.AddWithValue("@Etager", Convert.ToInt32(Ejendomsmægler_OpdaterBolig.Etager1));
            cmd.Parameters.AddWithValue("@Byggeår", Convert.ToInt32(Ejendomsmægler_OpdaterBolig.Byggeår));
            cmd.Parameters.AddWithValue("@Boligtype", Ejendomsmægler_OpdaterBolig.Boligtype);
            cmd.Parameters.AddWithValue("@Værelser", Convert.ToInt32(Ejendomsmægler_OpdaterBolig.Værelser));
            cmd.Parameters.AddWithValue("@Energimærke", Ejendomsmægler_OpdaterBolig.Energimærke);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public DataTable Ejendomsmægler_OpdaterBolig_PassToGrid()
        {
            MySqlConnection conn = new MySqlConnection(ConnStr);
            DataTable tbl = new DataTable();
            string sqlshow = "SELECT * FROM BoligTilSalg;";
            MySqlCommand cmd1 = new MySqlCommand(sqlshow, conn);
            conn.Open();
            tbl.Load(cmd1.ExecuteReader());
            return tbl;
        }

        public DataTable Ejendomsmægler_OpdaterSælger_PassToGrid()
        {
            MySqlConnection conn = new MySqlConnection(ConnStr);
            DataTable tbl = new DataTable();
            string sqlshow = "SELECT * FROM Sælger;";
            MySqlCommand cmd1 = new MySqlCommand(sqlshow, conn);
            conn.Open();
            tbl.Load(cmd1.ExecuteReader());
            return tbl;
        }

        public void Ejendomsmægler_OpdaterSælgerButton2SQL()
        {
            MySqlConnection conn = new MySqlConnection(ConnStr);

            string sql = "SELECT * FROM Sælger WHERE ID = @ID;";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(Ejendomsmægler_OpdaterSælger.ID));

            conn.Open();
            cmd.ExecuteNonQuery();

            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Ejendomsmægler_OpdaterSælger.ID = Convert.ToString(rdr[0]);
                Ejendomsmægler_OpdaterSælger.Tlf = Convert.ToString(rdr[1]);
                Ejendomsmægler_OpdaterSælger.Fornavn = Convert.ToString(rdr[2]);
                Ejendomsmægler_OpdaterSælger.Efternavn = Convert.ToString(rdr[3]);
                Ejendomsmægler_OpdaterSælger.Brugernavn = Convert.ToString(rdr[4]);
                Ejendomsmægler_OpdaterSælger.Kodeord = Convert.ToString(rdr[5]);
            }
            rdr.Close();
            conn.Close();
        }

        public void Ejendomsmægler_OpdaterSælgerButton1SQL()
        {
            MySqlConnection conn = new MySqlConnection(ConnStr);

            string sql = "UPDATE Sælger SET Tlf = @Tlf, Fornavn = @Fornavn, Efternavn = @Efternavn, Brugernavn = @Brugernavn, Kodeord = HEX(AES_ENCRYPT(@Kodeord, 'somethingfunnyhere')) WHERE ID = @ID;";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(Ejendomsmægler_OpdaterSælger.ID));
            cmd.Parameters.AddWithValue("@Tlf", Ejendomsmægler_OpdaterSælger.Tlf);
            cmd.Parameters.AddWithValue("@Fornavn", Ejendomsmægler_OpdaterSælger.Fornavn);
            cmd.Parameters.AddWithValue("@Efternavn", Ejendomsmægler_OpdaterSælger.Efternavn);
            cmd.Parameters.AddWithValue("@Brugernavn", Ejendomsmægler_OpdaterSælger.Brugernavn);
            cmd.Parameters.AddWithValue("@Kodeord", Ejendomsmægler_OpdaterSælger.Kodeord);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable Ejendomsmægler_OpretBolig_PassToGrid()
        {
            MySqlConnection conn = new MySqlConnection(ConnStr);
            DataTable tbl = new DataTable();
            string sqlshow = "SELECT * FROM BoligTilSalg;";
            MySqlCommand cmd1 = new MySqlCommand(sqlshow, conn);
            conn.Open();
            tbl.Load(cmd1.ExecuteReader());
            return tbl;
        }

        public void Ejendomsmægler_OpretBoligSQL()
        {
            MySqlConnection conn = new MySqlConnection(ConnStr);


            string sql = "INSERT INTO BoligTilSalg(SælgerID, Pris, M2, `By`, PostNr, Adresse, Etager, Byggeår, Boligtype, Værelser, Energimærke, OprettelsesDato) " +
                         "VALUES(@SælgerID, @Pris, @M2, @By, @PostNr, @Adresse, @Etager, @Byggeår, @Boligtype, @Værelser, @Energimærke, CURRENT_Date);";


            MySqlCommand cmd = new MySqlCommand(sql, conn);


            cmd.Parameters.AddWithValue("@SælgerID", Ejendomsmægler_OpretBolig.SælgerID);
            cmd.Parameters.AddWithValue("@Pris", Ejendomsmægler_OpretBolig.Pris);
            cmd.Parameters.AddWithValue("@M2", Ejendomsmægler_OpretBolig.M2);
            cmd.Parameters.AddWithValue("@By", Ejendomsmægler_OpretBolig.By);
            cmd.Parameters.AddWithValue("@PostNr", Ejendomsmægler_OpretBolig.PostNr);
            cmd.Parameters.AddWithValue("@Adresse", Ejendomsmægler_OpretBolig.Adresse);
            cmd.Parameters.AddWithValue("@Etager", Ejendomsmægler_OpretBolig.Etager1);
            cmd.Parameters.AddWithValue("@Byggeår", Ejendomsmægler_OpretBolig.Byggeår);
            cmd.Parameters.AddWithValue("@Boligtype", Ejendomsmægler_OpretBolig.Boligtype);
            cmd.Parameters.AddWithValue("@Værelser", Ejendomsmægler_OpretBolig.Værelser);
            cmd.Parameters.AddWithValue("@Energimærke", Ejendomsmægler_OpretBolig.Energimærke);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable Ejendomsmægler_OpretSælger_PassToGrid()
        {
            MySqlConnection conn = new MySqlConnection(ConnStr);
            DataTable tbl = new DataTable();
            string sqlshow = "SELECT * FROM Sælger;";
            MySqlCommand cmd1 = new MySqlCommand(sqlshow, conn);
            conn.Open();
            tbl.Load(cmd1.ExecuteReader());
            return tbl;
        }

        public void Ejendomsmægler_OpretSælgerSQL()
        {
            MySqlConnection conn = new MySqlConnection(ConnStr);


            string sql = "INSERT INTO Sælger(Tlf, Fornavn, Efternavn, Brugernavn, Kodeord) " +
                         "VALUES (@Tlf, @Fornavn, @Efternavn, @Brugernavn, HEX(AES_ENCRYPT(@Kodeord, 'somethingfunnyhere')));";


            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Tlf", Ejendomsmægler_OpretSælger.Tlf);
            cmd.Parameters.AddWithValue("@Fornavn", Ejendomsmægler_OpretSælger.Fornavn);
            cmd.Parameters.AddWithValue("@Efternavn", Ejendomsmægler_OpretSælger.Efternavn);
            cmd.Parameters.AddWithValue("@Brugernavn", Ejendomsmægler_OpretSælger.Brugernavn1);
            cmd.Parameters.AddWithValue("@Kodeord", Ejendomsmægler_OpretSælger.Kodeord1);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable Ejendomsmægler_SletBolig_PassToGrid()
        {
            MySqlConnection conn = new MySqlConnection(ConnStr);
            DataTable tbl = new DataTable();
            string sqlshow = "SELECT * FROM BoligTilSalg;";
            MySqlCommand cmd1 = new MySqlCommand(sqlshow, conn);
            conn.Open();
            tbl.Load(cmd1.ExecuteReader());
            return tbl;
        }

        public void Ejendomsmægler_SletBoligSQL()
        {
            MySqlConnection conn = new MySqlConnection(ConnStr);

            string sql = "DELETE FROM BoligTilSalg WHERE BoligID = @BoligID;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@BoligID", Ejendomsmægler_SletBolig.BoligID);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable Ejendomsmægler_SletSælger_PassToGrid()
        {
            MySqlConnection conn = new MySqlConnection(ConnStr);
            DataTable tbl = new DataTable();
            string sqlshow = "SELECT * FROM Sælger;";
            MySqlCommand cmd1 = new MySqlCommand(sqlshow, conn);
            conn.Open();
            tbl.Load(cmd1.ExecuteReader());
            return tbl;
        }

        public void Ejendomsmælger_SletSælgerSQl()
        {
            MySqlConnection conn = new MySqlConnection(ConnStr);

            string sql = "DELETE FROM Sælger WHERE ID = @ID;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@ID", Ejendomsmægler_SletSælger.ID);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable Ejendomsmægler_SolgteBolig_PassToGrid()
        {
            MySqlConnection conn = new MySqlConnection(ConnStr);
            DataTable tbl = new DataTable();
            string sqlshow = "SELECT * FROM SolgteBolig ORDER BY PostNr DESC";
            MySqlCommand cmd1 = new MySqlCommand(sqlshow, conn);
            conn.Open();
            tbl.Load(cmd1.ExecuteReader());
            return tbl;
        }
        #endregion Ejendomsmægler

        #region Køber
        public DataTable Køber_Bolig_PassToGrid()
        {
            MySqlConnection conn = new MySqlConnection(ConnStr);
            DataTable tbl = new DataTable();
            string sqlshow = "SELECT * FROM BoligTilSalg;";
            MySqlCommand cmd1 = new MySqlCommand(sqlshow, conn);
            conn.Open();
            tbl.Load(cmd1.ExecuteReader());
            return tbl;
        }

        public void Køber_Bolig_GetInfo()
        {
            MySqlConnection conn = new MySqlConnection(ConnStr);


            string cmd_BoligValg = "SELECT * FROM BoligTilSalg Where BoligID = @BoligID";

            MySqlCommand BoligValg = new MySqlCommand(cmd_BoligValg, conn);
            BoligValg.Parameters.AddWithValue("@BoligID", Køber_Bolig.BoligID);

            conn.Open();
            MySqlDataReader rdr = BoligValg.ExecuteReader();
            while (rdr.Read())
            {
                Køber_Bolig.BoligID = Convert.ToInt32(rdr[0]);
                Køber_Bolig.SælgerID = Convert.ToInt32(rdr[1]);
                Køber_Bolig.Pris = Convert.ToInt32(rdr[2]);
                Køber_Bolig.M2 = Convert.ToInt32(rdr[3]);
                Køber_Bolig.By = Convert.ToString(rdr[4]);
                Køber_Bolig.PostNr = Convert.ToString(rdr[5]);
                Køber_Bolig.Adresse = Convert.ToString(rdr[6]);
                Køber_Bolig.Etager1 = Convert.ToInt32(rdr[7]);
                Køber_Bolig.Byggeår = Convert.ToInt32(rdr[8]);
                Køber_Bolig.Boligtype = Convert.ToString(rdr[9]);
                Køber_Bolig.Værelser = Convert.ToInt32(rdr[10]);
                Køber_Bolig.Energimærke = Convert.ToString(rdr[11]);
                Køber_Bolig.OprettelsesDato = Convert.ToString(rdr[12]);
            }
            rdr.Close();
            conn.Close();
        }

        public void Køber_Bolig_Buy()
        {
            MySqlConnection conn = new MySqlConnection(ConnStr);

            string cmd_Køb = "INSERT INTO SolgteBolig (BoligID, KøberID, SælgerID, Pris, M2, `By`, PostNr, Adresse, Etager, Byggeår, Boligtype, Værelser, Energimærke, OprettelsesDato, HandelsDato) " +
                            "VALUES(@BoligID, @KøberID, @SælgerID, @Pris, @M2, @By, @PostNr, @Adresse, @Etager, @Byggeår, @Boligtype, @Værelser, @Energimærke, @OprettelsesDato, CURRENT_DATE);";

            MySqlCommand Køb = new MySqlCommand(cmd_Køb, conn);
            Køb.Parameters.AddWithValue("@BoligID", Køber_Bolig.BoligID);
            Køb.Parameters.AddWithValue("@KøberID", Convert.ToInt32(Køber_Login.Køber_ID_LoggedIn));
            Køb.Parameters.AddWithValue("@SælgerID", Køber_Bolig.SælgerID);
            Køb.Parameters.AddWithValue("@Pris", Køber_Bolig.Pris);
            Køb.Parameters.AddWithValue("@M2", Køber_Bolig.M2);
            Køb.Parameters.AddWithValue("@By", Køber_Bolig.By);
            Køb.Parameters.AddWithValue("@PostNr", Køber_Bolig.PostNr);
            Køb.Parameters.AddWithValue("@Adresse", Køber_Bolig.Adresse);
            Køb.Parameters.AddWithValue("@Etager", Køber_Bolig.Etager1);
            Køb.Parameters.AddWithValue("@Byggeår", Køber_Bolig.Byggeår);
            Køb.Parameters.AddWithValue("@Boligtype", Køber_Bolig.Boligtype);
            Køb.Parameters.AddWithValue("@Værelser", Køber_Bolig.Værelser);
            Køb.Parameters.AddWithValue("@Energimærke", Køber_Bolig.Energimærke);
            Køb.Parameters.AddWithValue("@OprettelsesDato", Convert.ToDateTime(Køber_Bolig.OprettelsesDato));


            conn.Open();
            Køb.ExecuteNonQuery();
            conn.Close();
        }

        public void Køber_Bolig_DeleteFromSale()
        {
            MySqlConnection conn = new MySqlConnection(ConnStr);
            string cmd_Slet = "DELETE FROM BoligTilSalg WHERE BoligID = @BoligID;";
            MySqlCommand Slet = new MySqlCommand(cmd_Slet, conn);
            Slet.Parameters.AddWithValue("@BoligID", Køber_Bolig.BoligID);
            conn.Open();
            Slet.ExecuteNonQuery();
            conn.Close();
        }

        public void Køber_Bolig_txt()
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

        public void Køber_KontoSQL()
        {
            MySqlConnection conn = new MySqlConnection(ConnStr);


            string sql = "UPDATE Køber SET ";
            if (Køber_Konto.Tlf != "")
            {
                sql += "Tlf = @Tlf ";
                if (Køber_Konto.Fornavn != "" || Køber_Konto.Efternavn != "" || Køber_Konto.Brugernavn != "" || Køber_Konto.Kodeord != "")
                {
                    sql += ",";
                }
            }
            if (Køber_Konto.Fornavn != "")
            {
                sql += "Fornavn = @Fornavn ";
                if (Køber_Konto.Efternavn != "" || Køber_Konto.Brugernavn != "" || Køber_Konto.Kodeord != "")
                {
                    sql += ",";
                }
            }
            if (Køber_Konto.Efternavn != "")
            {
                sql += "Efternavn = @Efternavn ";
                if (Køber_Konto.Brugernavn != "" || Køber_Konto.Kodeord != "")
                {
                    sql += ",";
                }
            }
            if (Køber_Konto.Brugernavn != "")
            {
                sql += "Brugernavn = @Brugernavn ";
                if (Køber_Konto.Kodeord != "")
                {
                    sql += ",";
                }
            }
            if (Køber_Konto.Kodeord != "")
            {
                sql += "Kodeord = HEX(AES_ENCRYPT(@Kodeord, 'somethingfunnyhere'))";

            }

            sql += "WHERE ID = @ID";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(Køber_Login.Køber_ID_LoggedIn));
            cmd.Parameters.AddWithValue("@Tlf", Køber_Konto.Tlf);
            cmd.Parameters.AddWithValue("@Fornavn", Køber_Konto.Fornavn);
            cmd.Parameters.AddWithValue("@Efternavn", Køber_Konto.Efternavn);
            cmd.Parameters.AddWithValue("@Brugernavn", Køber_Konto.Brugernavn);
            cmd.Parameters.AddWithValue("@Kodeord", Køber_Konto.Kodeord);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Køber_LoginSQL()
        {
            MySqlConnection conn = new MySqlConnection(ConnStr);


            string sql = "SELECT ID, Tlf, Fornavn, Efternavn, Brugernavn, CAST(AES_DECRYPT(UNHEX(Kodeord), 'somethingfunnyhere') as varchar(100)) FROM Køber WHERE Brugernavn = @Brugernavn;";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Brugernavn", Køber_Login.Køber_Brugernavn);

            conn.Open();

            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Køber_Login.Køber_ID_LoggedIn = Convert.ToInt32(rdr[0]);
                Køber_Login.Køber_Tlf = Convert.ToString(rdr[1]);
                Køber_Login.Køber_Fornavn = Convert.ToString(rdr[2]);
                Køber_Login.Køber_Efternavn = Convert.ToString(rdr[3]);
                Køber_Login.Køber_Brugernavn = Convert.ToString(rdr[4]);
                Køber_Login.Køber_Kodeord = Convert.ToString(rdr[5]);
            }
            rdr.Close();
        }

        public DataTable Køber_Ordre_PassToGrid()
        {
            MySqlConnection conn = new MySqlConnection(ConnStr);
            DataTable tbl = new DataTable();
            string sqlshow = "SELECT * FROM SolgteBolig WHERE KøberID = @KøberID;";
            MySqlCommand cmd1 = new MySqlCommand(sqlshow, conn);
            cmd1.Parameters.AddWithValue("@KøberID", Køber_Login.Køber_ID_LoggedIn);
            conn.Open();
            tbl.Load(cmd1.ExecuteReader());
            return tbl;
        }

        public void Køber_Ordre_Get()
        {
            MySqlConnection conn = new MySqlConnection(ConnStr);
            string cmd_KøbtBoligLoad = "SELECT * FROM SolgteBolig Where BoligID = @BoligID AND KøberID = @KøberID";

            MySqlCommand KøbtBoligLoad = new MySqlCommand(cmd_KøbtBoligLoad, conn);
            KøbtBoligLoad.Parameters.AddWithValue("@BoligID", Køber_Ordre.BoligID);
            KøbtBoligLoad.Parameters.AddWithValue("@KøberID", Convert.ToInt32(Køber_Login.Køber_ID_LoggedIn));

            conn.Open();
            MySqlDataReader rdr = KøbtBoligLoad.ExecuteReader();
            while (rdr.Read())
            {
                Køber_Ordre.BoligID = Convert.ToInt32(rdr[0]);
                Køber_Ordre.KøberID = Convert.ToInt32(rdr[1]);
                Køber_Ordre.SælgerID = Convert.ToInt32(rdr[2]);
                Køber_Ordre.Pris = Convert.ToInt32(rdr[3]);
                Køber_Ordre.M2 = Convert.ToInt32(rdr[4]);
                Køber_Ordre.By = Convert.ToString(rdr[5]);
                Køber_Ordre.PostNr = Convert.ToString(rdr[6]);
                Køber_Ordre.Adresse = Convert.ToString(rdr[7]);
                Køber_Ordre.Etager1 = Convert.ToInt32(rdr[8]);
                Køber_Ordre.Byggeår = Convert.ToInt32(rdr[9]);
                Køber_Ordre.Boligtype = Convert.ToString(rdr[10]);
                Køber_Ordre.Værelser = Convert.ToInt32(rdr[11]);
                Køber_Ordre.Energimærke = Convert.ToString(rdr[12]);
                Køber_Ordre.OprettelsesDato = Convert.ToString(rdr[13]);
                Køber_Ordre.HandelsDato = Convert.ToString(rdr[14]);
            }
            rdr.Close();
            conn.Close();
        }

        public void Køber_Ordre_MoveFromSoldToSales()
        {
            MySqlConnection conn = new MySqlConnection(ConnStr);
            string cmd_Køb = "INSERT INTO BoligTilSalg(BoligID, SælgerID, Pris, M2, `By`, PostNr, Adresse, Etager, Byggeår, Boligtype, Værelser, Energimærke, OprettelsesDato) " +
                                 "VALUES(@BoligID, @SælgerID, @Pris, @M2, @By, @PostNr, @Adresse, @Etager, @Byggeår, @Boligtype, @Værelser, @Energimærke, @OprettelsesDato);";


            MySqlCommand FjernKøb = new MySqlCommand(cmd_Køb, conn);
            FjernKøb.Parameters.AddWithValue("@BoligID", Køber_Ordre.BoligID);
            FjernKøb.Parameters.AddWithValue("@KøberID", Køber_Ordre.KøberID);
            FjernKøb.Parameters.AddWithValue("@SælgerID", Køber_Ordre.SælgerID);
            FjernKøb.Parameters.AddWithValue("@Pris", Køber_Ordre.Pris);
            FjernKøb.Parameters.AddWithValue("@M2", Køber_Ordre.M2);
            FjernKøb.Parameters.AddWithValue("@By", Køber_Ordre.By);
            FjernKøb.Parameters.AddWithValue("@PostNr", Køber_Ordre.PostNr);
            FjernKøb.Parameters.AddWithValue("@Adresse", Køber_Ordre.Adresse);
            FjernKøb.Parameters.AddWithValue("@Etager", Køber_Ordre.Etager1);
            FjernKøb.Parameters.AddWithValue("@Byggeår", Køber_Ordre.Byggeår);
            FjernKøb.Parameters.AddWithValue("@Boligtype", Køber_Ordre.Boligtype);
            FjernKøb.Parameters.AddWithValue("@Værelser", Køber_Ordre.Værelser);
            FjernKøb.Parameters.AddWithValue("@Energimærke", Køber_Ordre.Energimærke);
            FjernKøb.Parameters.AddWithValue("@OprettelsesDato", Convert.ToDateTime(Køber_Ordre.OprettelsesDato));


            conn.Open();
            FjernKøb.ExecuteNonQuery();
            conn.Close();
        }

        public void Køber_Ordre_DeleteFromSold()
        {
            MySqlConnection conn = new MySqlConnection(ConnStr);
            string cmd_SletOrdre = "DELETE FROM SolgteBolig WHERE BoligID = @BoligID AND KøberID = @KøberID;";
            MySqlCommand SletOrdre = new MySqlCommand(cmd_SletOrdre, conn);
            SletOrdre.Parameters.AddWithValue("@BoligID", Køber_Ordre.BoligID);
            SletOrdre.Parameters.AddWithValue("@KøberID", Convert.ToInt32(Køber_Login.Køber_ID_LoggedIn));
            conn.Open();
            SletOrdre.ExecuteNonQuery();
            conn.Close();
        }

        public void Køber_Ordre_Txt()
        {
            MySqlConnection conn = new MySqlConnection(ConnStr);

            string filePath = @"..\..\txts\KøbteBolig.txt";
            /*
            if (!File.Exists(filePath))
            {
                File.CreateText(filePath).Dispose();
            }
            */

            string cmd_TxtPrint = "SELECT * FROM SolgteBolig Where KøberID = @KøberID";
            MySqlCommand TxtPrint = new MySqlCommand(cmd_TxtPrint, conn);
            TxtPrint.Parameters.AddWithValue("@KøberID", Convert.ToInt32(Køber_Login.Køber_ID_LoggedIn));


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

        public void Køber_OpretBruger()
        {
            MySqlConnection conn = new MySqlConnection(ConnStr);


            string sql = "INSERT INTO Køber(Tlf, Fornavn, Efternavn, Brugernavn, Kodeord) " +
                         "VALUES (@Tlf, @Fornavn, @Efternavn, @Brugernavn, HEX(AES_ENCRYPT(@Kodeord, 'somethingfunnyhere')));";


            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Tlf", Køber_Register.Tlf);
            cmd.Parameters.AddWithValue("@Fornavn", Køber_Register.Fornavn);
            cmd.Parameters.AddWithValue("@Efternavn", Køber_Register.Efternavn);
            cmd.Parameters.AddWithValue("@Brugernavn", Køber_Register.Brugernavn);
            cmd.Parameters.AddWithValue("@Kodeord", Køber_Register.Kodeord);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        #endregion Køber

        #region Sælger
        public void Sælger_LoginSQL()
        {
            MySqlConnection conn = new MySqlConnection(ConnStr);


            string sql = "SELECT ID, Brugernavn, CAST(AES_DECRYPT(UNHEX(Kodeord), 'somethingfunnyhere') as varchar(100)) FROM Sælger WHERE Brugernavn = @Brugernavn;";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Brugernavn", Sælger_Login.UserName);

            conn.Open();

            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Sælger_Login.Sælger_ID_LoggedIn = Convert.ToString(rdr[0]);
                Sælger_Login.UserName = Convert.ToString(rdr[1]);
                Sælger_Login.PassWord = Convert.ToString(rdr[2]);
            }
            rdr.Close();
            conn.Close();
        }

        public DataTable Sælger_OpdaterBolig_PassToGrid()
        {
            MySqlConnection conn = new MySqlConnection(ConnStr);
            DataTable tbl = new DataTable();
            string sqlshow = "SELECT * FROM BoligTilSalg Where SælgerID = @ID;";
            MySqlCommand cmd1 = new MySqlCommand(sqlshow, conn);
            cmd1.Parameters.AddWithValue("@ID", Sælger_Login.Sælger_ID_LoggedIn);
            conn.Open();
            tbl.Load(cmd1.ExecuteReader());
            return tbl;
        }

        public void Sælger_OpdaterBoligButton2SQL()
        {
            MySqlConnection conn = new MySqlConnection(ConnStr);

            string sql = "SELECT * FROM BoligTilSalg WHERE BoligID = @BoligID AND SælgerID = @SælgerID;";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@SælgerID", Convert.ToInt32(Sælger_Login.Sælger_ID_LoggedIn));
            cmd.Parameters.AddWithValue("@BoligID", Convert.ToInt32(Sælger_OpdaterBolig.BoligID));

            conn.Open();

            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Sælger_OpdaterBolig.SælgerID = Convert.ToInt32(rdr[1]);
                Sælger_OpdaterBolig.Pris = Convert.ToInt32(rdr[2]);
            }
            rdr.Close();
            conn.Close();          
        }

        public void Sælger_OpdaterBoligButton1SQL()
        {
            MySqlConnection conn = new MySqlConnection(ConnStr);

            string sql = "UPDATE BoligTilSalg SET Pris = @Pris WHERE BoligID = @BoligID AND SælgerID = @SælgerID;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);


            cmd.Parameters.AddWithValue("@SælgerID", Convert.ToInt32(Sælger_Login.Sælger_ID_LoggedIn));
            cmd.Parameters.AddWithValue("@BoligID", Convert.ToInt32(Sælger_OpdaterBolig.BoligID));
            cmd.Parameters.AddWithValue("@Pris", Convert.ToInt32(Sælger_OpdaterBolig.Pris));

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        #endregion Sælger

    }
}
