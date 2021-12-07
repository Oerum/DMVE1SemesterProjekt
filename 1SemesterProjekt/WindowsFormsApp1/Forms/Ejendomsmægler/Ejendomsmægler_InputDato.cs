using DAL;
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
                    var dateFormats = new List<string> { "dd.MM.yyyy", "dd-MM-yyyy", "dd/MM/yyyy", "ddMMyyyy", "yyyy.MM.dd", "yyyy-MM-dd", "yyyy/MM/dd", "yyyyMMdd" };

                    DateTime Convert_Dato1 = DateTime.ParseExact(textBox1.Text, dateFormats.ToArray(), DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None);
                    DateTime Convert_Dato2 = DateTime.ParseExact(textBox2.Text, dateFormats.ToArray(), DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None);;

                    Dato1 = Convert_Dato1.ToString("yyyy-MM-dd");
                    Dato2 = Convert_Dato2.ToString("yyyy-MM-dd");

                   
                    if (Dato1 != null && Dato2 != null)
                    {
                        DB db = new DB();
                        db.Ejendommægler_InputDatoSQL();
                        
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

