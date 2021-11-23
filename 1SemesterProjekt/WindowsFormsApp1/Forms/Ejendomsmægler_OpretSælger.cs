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
    public partial class Ejendomsmægler_OpretSælger : Form
    {
        public Ejendomsmægler_OpretSælger()
        {
            InitializeComponent();
            this.boligTilSalgTableAdapter.Fill(this.ejendomsmæglerDataSet.BoligTilSalg);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string BoligID = "";
            string SælgerID = "";
            string Pris = "";
            string M2 = "";
            string PostNr = "";
            string Dato = "";
            try
            {
                DB db = new DB();
                MySqlConnection conn = new MySqlConnection(db.ConnStr);

                string sql = "SELECT * FROM BoligTilSalg;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();
                cmd.ExecuteNonQuery();

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    BoligID = Convert.ToString(rdr[0]);
                    SælgerID = Convert.ToString(rdr[1]);
                    Pris = Convert.ToString(rdr[2]);
                    M2 = Convert.ToString(rdr[3]);
                    PostNr = Convert.ToString(rdr[4]);
                    Dato = Convert.ToString(rdr[5]);
                }
                rdr.Close();

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
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();

                MySqlConnection conn = new MySqlConnection(db.ConnStr);


                string sql = "INSERT INTO Sælger(ID, Tlf, Fornavn, Efternavn) " +
                             "VALUES(@ID, @Tlf, @Fornavn, @Efternavn);";


                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@Tlf", int.Parse(textBox2.Text));
                cmd.Parameters.AddWithValue("@Fornavn", int.Parse(textBox3.Text));
                cmd.Parameters.AddWithValue("@Efternavn", int.Parse(textBox4.Text));

                conn.Open();
                cmd.ExecuteNonQuery();

                #region PassToGrid
                DataTable tbl = new DataTable();
                string sqlshow = "SELECT * FROM BoligTilSalg;";
                MySqlCommand cmd1 = new MySqlCommand(sqlshow, conn);
                cmd1.Parameters.AddWithValue("@Id1", int.Parse(textBox1.Text));
                tbl.Load(cmd1.ExecuteReader());
                dataGridView1.DataSource = tbl;
                MessageBox.Show("Done");
                conn.Close();
                #endregion PassToGrid
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }
    }
}
