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
    public partial class Ejendomsmægler_OpdaterSælger : Form
    {
        public Ejendomsmægler_OpdaterSælger()
        {
            InitializeComponent();
            this.sælgerTableAdapter.Fill(this.ejendomsmæglerDataSet.Sælger);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ID = "";
            string Tlf = "";
            string Fornavn = "";
            string Efternavn = "";

            try
            {
                DB db = new DB();

                MySqlConnection conn = new MySqlConnection(db.ConnStr);


                string sql = "SELECT * FROM Sælger WHERE ID = @BoligID;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@BoligID", int.Parse(textBox1.Text));

                conn.Open();
                cmd.ExecuteNonQuery();

                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ID = Convert.ToString(rdr[0]);
                    Tlf = Convert.ToString(rdr[1]);
                    Fornavn = Convert.ToString(rdr[2]);
                    Efternavn = Convert.ToString(rdr[3]);
                }
                rdr.Close();
                conn.Close();
                textBox1.Text = ID;
                textBox2.Text = Tlf;
                textBox3.Text = Fornavn;
                textBox4.Text = Efternavn;
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

                string sql = "UPDATE Sælger SET Tlf = @Tlf, Fornavn = @Fornavn, Efternavn = @Efternavn WHERE ID = @ID;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@Tlf", int.Parse(textBox2.Text));
                cmd.Parameters.AddWithValue("@Fornavn", int.Parse(textBox3.Text));
                cmd.Parameters.AddWithValue("@Efternavn", int.Parse(textBox4.Text));

                conn.Open();
                cmd.ExecuteNonQuery();

                #region PassToGrid
                DataTable tbl = new DataTable();
                string sqlshow = "SELECT * FROM Sælger";
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

        private void Ejendomsmægler_OpdaterSælger_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ejendomsmæglerDataSet2.Sælger' table. You can move, or remove it, as needed.
            this.sælgerTableAdapter2.Fill(this.ejendomsmæglerDataSet2.Sælger);
            // TODO: This line of code loads data into the 'ejendomsmæglerDataSet1.Sælger' table. You can move, or remove it, as needed.
            this.sælgerTableAdapter1.Fill(this.ejendomsmæglerDataSet1.Sælger);
            // TODO: This line of code loads data into the 'ejendomsmæglerDataSet.Sælger' table. You can move, or remove it, as needed.
            this.sælgerTableAdapter.Fill(this.ejendomsmæglerDataSet.Sælger);

        }
    }
}
