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
    public partial class Ejendomsmægler_SletBolig : Form
    {
        public Ejendomsmægler_SletBolig()
        {
            InitializeComponent();
            this.boligTilSalgTableAdapter.Fill(this.ejendomsmæglerDataSet.BoligTilSalg);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                MySqlConnection conn = new MySqlConnection(db.ConnStr);

                string sql = "DELETE FROM BoligTilSalg WHERE BoligID = @BoligID;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@BoligID", int.Parse(textBox1.Text));

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
    }
}
