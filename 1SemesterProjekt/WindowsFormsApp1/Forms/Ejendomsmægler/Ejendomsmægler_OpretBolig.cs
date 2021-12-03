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
    public partial class Ejendomsmægler_OpretBolig : Form
    {
        public Ejendomsmægler_OpretBolig()
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    DB db = new DB();

                    MySqlConnection conn = new MySqlConnection(db.ConnStr);


                    string sql = "INSERT INTO BoligTilSalg(SælgerID, Pris, M2, `By`, PostNr, Adresse, Etager, Byggeår, Boligtype, Værelser, Energimærke, OprettelsesDato) " +
                                 "VALUES(@SælgerID, @Pris, @M2, @By, @PostNr, @Adresse, @Etager, @Byggeår, @Boligtype, @Værelser, @Energimærke, CURRENT_Date);";


                    MySqlCommand cmd = new MySqlCommand(sql, conn);


                    cmd.Parameters.AddWithValue("@SælgerID", Convert.ToInt32(comboBox6.Text));
                    cmd.Parameters.AddWithValue("@Pris", Convert.ToInt32(textBox3.Text));
                    cmd.Parameters.AddWithValue("@M2", Convert.ToInt32(textBox4.Text));
                    cmd.Parameters.AddWithValue("@By", textBox5.Text);
                    cmd.Parameters.AddWithValue("@PostNr", textBox6.Text);
                    cmd.Parameters.AddWithValue("@Adresse", textBox7.Text);
                    cmd.Parameters.AddWithValue("@Etager", Convert.ToInt32(comboBox1.Text));
                    cmd.Parameters.AddWithValue("@Byggeår", Convert.ToInt32(comboBox2.Text));
                    cmd.Parameters.AddWithValue("@Boligtype", comboBox3.Text);
                    cmd.Parameters.AddWithValue("@Værelser", comboBox5.Text);
                    cmd.Parameters.AddWithValue("@Energimærke", Convert.ToString(comboBox4.Text));

                    conn.Open();
                    if (comboBox6.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "" && comboBox4.Text != "" && comboBox5.Text != "")
                    {
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("[Udfyld Alle Felter]");
                    }

                    #region PassToGrid
                    DataTable tbl = new DataTable();
                    string sqlshow = "SELECT * FROM BoligTilSalg;";
                    MySqlCommand cmd1 = new MySqlCommand(sqlshow, conn);
                    tbl.Load(cmd1.ExecuteReader());
                    dataGridView1.DataSource = tbl;
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
                MessageBox.Show($"Udfyld alle felter");
            }

            
        }

        private void Ejendomsmægler_OpretBolig_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ejendomsmæglerDataSet.Sælger' table. You can move, or remove it, as needed.
            this.sælgerTableAdapter.Fill(this.ejendomsmæglerDataSet.Sælger);

        }
    }
}
