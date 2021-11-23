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
    public partial class Ejendomsmægler_SletSælger : Form
    {
        public Ejendomsmægler_SletSælger()
        {
            InitializeComponent();
            this.sælgerTableAdapter.Fill(this.ejendomsmæglerDataSet.Sælger);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                MySqlConnection conn = new MySqlConnection(db.ConnStr);

                string sql = "DELETE FROM Sælger WHERE ID = @ID;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));

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

        private void Ejendomsmægler_SletSælger_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ejendomsmæglerDataSet1.Sælger' table. You can move, or remove it, as needed.
            this.sælgerTableAdapter1.Fill(this.ejendomsmæglerDataSet1.Sælger);

        }
    }
}
