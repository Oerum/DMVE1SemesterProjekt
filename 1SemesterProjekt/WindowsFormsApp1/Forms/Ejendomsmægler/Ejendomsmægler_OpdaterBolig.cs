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
                    PostNr = Convert.ToString(rdr[4]);
                    Dato = Convert.ToString(rdr[5]);
                }
                rdr.Close();
                conn.Close();
                textBox1.Text = BoligID;
                textBox2.Text = SælgerID;
                textBox3.Text = Pris;
                textBox4.Text = M2;
                textBox5.Text = PostNr;

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

                string sql = "UPDATE BoligTilSalg SET SælgerID = @SælgerID, Pris = @Pris, M2 = @M2, PostNr = @PostNr WHERE BoligID = @BoligID;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@BoligID", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@SælgerID", int.Parse(textBox2.Text));
                cmd.Parameters.AddWithValue("@Pris", int.Parse(textBox3.Text));
                cmd.Parameters.AddWithValue("@M2", int.Parse(textBox4.Text));
                cmd.Parameters.AddWithValue("@PostNr", int.Parse(textBox5.Text));

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
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ejendomsmæglerDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void boligTilSalgBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
