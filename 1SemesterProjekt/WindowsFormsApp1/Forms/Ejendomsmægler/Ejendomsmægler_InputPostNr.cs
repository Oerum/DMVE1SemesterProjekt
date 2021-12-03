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

namespace WindowsFormsApp1.Forms.Ejendomsmægler
{
    public partial class Ejendomsmægler_InputPostNr : Form
    {
        public static string InputPostNr { get; set; }
        public static bool IsActive { get; set; }
        public Ejendomsmægler_InputPostNr()
        {
            InitializeComponent();
            IsActive = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InputPostNr = textBox1.Text;
            IsActive = false;

            try
            {
                try
                {
                    if (InputPostNr != null)
                    {
                        DB db = new DB();
                        MySqlConnection conn = new MySqlConnection(db.ConnStr);

                        string filePath = @"..\..\txts\BoligTilSalgPostNr.txt";
                        /*
                        if (!File.Exists(filePath))
                        {
                            File.CreateText(filePath).Dispose();
                        }
                        */
                        string cmd_TxtPrint = "SELECT * FROM SolgteBolig WHERE PostNr = @PostNr";
                        MySqlCommand TxtPrint = new MySqlCommand(cmd_TxtPrint, conn);
                        TxtPrint.Parameters.AddWithValue("@PostNr", InputPostNr);

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
                    this.Hide();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"{ex}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ugyldigt PostNr");
            }
            
            
        }
    }
}
