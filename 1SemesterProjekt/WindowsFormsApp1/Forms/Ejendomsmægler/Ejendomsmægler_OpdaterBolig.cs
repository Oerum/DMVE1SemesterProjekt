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

namespace WindowsFormsApp1.Forms
{
    public partial class Ejendomsmægler_OpdaterBolig : Form
    {
        public Ejendomsmægler_OpdaterBolig()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {
            string BoligID = "";
            string SælgerID = "";
            string Pris = "";
            string M2 = "";
            string By = "";
            string PostNr = "";
            string Adresse = "";
            string Etager = "";
            string Byggeår = "";
            string Boligtype = "";
            string Værelser = "";
            string Energimærke = "";
            string OprettelsesDato = "";
            
            try
            {
                try
                {
                    DB db = new DB();

                    MySqlConnection conn = new MySqlConnection(db.ConnStr);


                    string sql = "SELECT * FROM BoligTilSalg WHERE BoligID = @BoligID;";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@BoligID", int.Parse(textBox1.Text));

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MySqlDataReader rdr = cmd.ExecuteReader();
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
                    textBox1.Text = BoligID;
                    textBox2.Text = SælgerID;
                    textBox3.Text = Pris;
                    textBox4.Text = M2;
                    textBox5.Text = By;
                    textBox6.Text = PostNr;
                    textBox7.Text = Adresse;
                    textBox8.Text = Etager;
                    textBox9.Text = Byggeår;
                    textBox10.Text = Boligtype;
                    textBox11.Text = Værelser;
                    textBox12.Text = Energimærke;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"{ex.Number} = {ex}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ugyldigt BoligID");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    DB db = new DB();
                    MySqlConnection conn = new MySqlConnection(db.ConnStr);

                    string sql = "UPDATE BoligTilSalg SET SælgerID = @SælgerID, Pris = @Pris, M2 = @M2, `By` = @By, PostNr = @PostNr, Adresse = @Adresse, Etager = @Etager, Byggeår = @Byggeår, Boligtype = @Boligtype, Værelser = @Værelser, Energimærke = @Energimærke WHERE BoligID = @BoligID;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@BoligID", Convert.ToInt32(textBox1.Text));
                    cmd.Parameters.AddWithValue("@SælgerID", Convert.ToInt32(textBox2.Text));
                    cmd.Parameters.AddWithValue("@Pris", Convert.ToInt32(textBox3.Text));
                    cmd.Parameters.AddWithValue("@M2", Convert.ToInt32(textBox4.Text));
                    cmd.Parameters.AddWithValue("@By", textBox5.Text);
                    cmd.Parameters.AddWithValue("@PostNr", textBox6.Text);
                    cmd.Parameters.AddWithValue("@Adresse", textBox7.Text);
                    cmd.Parameters.AddWithValue("@Etager", Convert.ToInt32(textBox8.Text));
                    cmd.Parameters.AddWithValue("@Byggeår", Convert.ToInt32(textBox9.Text));
                    cmd.Parameters.AddWithValue("@Boligtype", textBox10.Text);
                    cmd.Parameters.AddWithValue("@Værelser", Convert.ToInt32(textBox11.Text));
                    cmd.Parameters.AddWithValue("@Energimærke", textBox12.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    #region PassToGrid
                    DataTable tbl = new DataTable();
                    string sqlshow = "SELECT * FROM BoligTilSalg";
                    MySqlCommand cmd1 = new MySqlCommand(sqlshow, conn);
                    tbl.Load(cmd1.ExecuteReader());
                    dataGridView1.DataSource = tbl;
                    MessageBox.Show("Done");
                    conn.Close();
                    #endregion PassToGrid

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"{ex.Number} = {ex}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Udfyld alle felter");
            }
            
        }
    }
}
