using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms.Ejendomsmægler
{
    public class BoligUdtræk
    {
        public int BoligID { get; set; }
        public int KøberID { get; set; }
        public int SælgerID { get; set; }
        public int Pris { get; set; }
        public int M2 { get; set; }
        public string By { get; set; }
        public string PostNr { get; set; }
        public string Adresse { get; set; }
        public int Etager { get; set; }
        public int Byggeår { get; set; }
        public string Boligtype { get; set; }
        public int Værelser { get; set; }
        public string Energimærke { get; set; }
        public string OprettelsesDato { get; set; }
        public string HandelsDato { get; set; }
    }

    public partial class Ejendomsmægler_InputDato : Form
    {
        public static string Dato1 { get; set; }
        public static string Dato2 { get; set; }
        public static List<BoligUdtræk> BoligUdtrækList = new List<BoligUdtræk>();

        public Ejendomsmægler_InputDato()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    DB db = new DB();
                    MySqlConnection conn = new MySqlConnection(db.ConnStr);


                    string sql = "SELECT *" +
                                "\nFROM SolgteBolig sb" +
                                "\nWHERE HandelsDato BETWEEN @Dato1 AND @Dato2" + 
                                "\nORDER BY SælgerID ASC;";


                    MySqlCommand cmd = new MySqlCommand(sql, conn);


                    var dateFormats = new List<string> { "dd.MM.yyyy", "dd-MM-yyyy", "dd/MM/yyyy", "ddMMyyyy", "yyyy.MM.dd", "yyyy-MM-dd", "yyyy/MM/dd", "yyyyMMdd" };

                    DateTime Convert_Dato1 = DateTime.ParseExact(textBox1.Text, dateFormats.ToArray(), DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None);
                    DateTime Convert_Dato2 = DateTime.ParseExact(textBox2.Text, dateFormats.ToArray(), DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None);;

                    Dato1 = Convert_Dato1.ToString("yyyy-MM-dd");
                    Dato2 = Convert_Dato2.ToString("yyyy-MM-dd");

                    cmd.Parameters.AddWithValue("@Dato1", Dato1);
                    cmd.Parameters.AddWithValue("@Dato2", Dato2);

                    conn.Open();
                    if (Dato1 != null && Dato2 != null)
                    {

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

                            BoligUdtrækList.Add(newItem);
                        }
                        rdr.Close();

                        Ejendomsmægler_BoligUdtræk boligUdtrækForm = new Ejendomsmægler_BoligUdtræk();
                        boligUdtrækForm.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("[Udfyld Alle Felter]");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Udfyld I korrekt format");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Udfyld alle felter");
            }


        }
    }
}

