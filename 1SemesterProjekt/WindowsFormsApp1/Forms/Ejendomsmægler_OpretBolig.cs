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
        public static Ejendomsmægler_OpretBolig instance;
        public Ejendomsmægler_OpretBolig()
        {
            InitializeComponent();
            instance = this;
            this.boligTilSalgTableAdapter.Fill(this.ejendomsmæglerDataSet.BoligTilSalg);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();

                MySqlConnection conn = new MySqlConnection(db.ConnStr);


                string sql = "INSERT INTO BoligTilSalg(BoligID, SælgerID, Pris, M2, PostNr, OprettelsesDato) " +
                             "VALUES(@BoligID, @SælgerID, @Pris, @M2, @PostNr, CURRENT_TIMESTAMP);";


                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@BoligID", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@SælgerID", int.Parse(textBox2.Text));
                cmd.Parameters.AddWithValue("@Pris", int.Parse(textBox3.Text));
                cmd.Parameters.AddWithValue("@M2", int.Parse(textBox4.Text));
                cmd.Parameters.AddWithValue("@PostNr", textBox5.Text);

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
    }
}
