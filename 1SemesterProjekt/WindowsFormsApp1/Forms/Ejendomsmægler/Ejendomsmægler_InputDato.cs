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
    public partial class Ejendomsmægler_InputDato : Form
    {
        public static string Dato1 { get; set; }
        public static string Dato2 { get; set; }
        public static List<string> BoligUdtræk = new List<string>() { };

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
                            BoligUdtræk.Add($"SælgerID = {Convert.ToString(rdr[2])}" +
                            $"\nBoligID = {Convert.ToString(rdr[0])}" +
                            $"\nKøberID = {Convert.ToString(rdr[1])}" +
                            $"\nPris = {Convert.ToString(rdr[3])}" +
                            $"\nM2 = {Convert.ToString(rdr[4])}" +
                            $"\nBy = {Convert.ToString(rdr[5])}" +
                            $"\nPostNr = {Convert.ToString(rdr[6])}" +
                            $"\nAdresse = {Convert.ToString(rdr[7])}" +
                            $"\nEtager = {Convert.ToString(rdr[8])}" +
                            $"\nByggeår = {Convert.ToString(rdr[9])}" +
                            $"\nBoligtype = {Convert.ToString(rdr[10])}" +
                            $"\nVærelser = {Convert.ToString(rdr[11])}" +
                            $"\nEnergimærke = {Convert.ToString(rdr[12])}" +
                            $"\nOprettelsesDato = {Convert.ToString(rdr[13])}" +
                            $"\nHandelsDato = {Convert.ToString(rdr[14])}\n");
                        }
                        rdr.Close();

                        /*
                        foreach (var attri in BoligUdtræk)
                            Console.WriteLine($"{attri} ");
                        */
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
                    MessageBox.Show($"Udfyld I korrekt format {ex}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Udfyld alle felter" + ex);
            }


        }
    }
}

