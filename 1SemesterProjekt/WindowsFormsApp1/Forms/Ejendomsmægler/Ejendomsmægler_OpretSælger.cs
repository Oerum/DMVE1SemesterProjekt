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
            #region PassToGrid
            DB db = new DB();
            MySqlConnection conn = new MySqlConnection(db.ConnStr);
            DataTable tbl = new DataTable();
            string sqlshow = "SELECT * FROM Sælger;";
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
                DB db = new DB();

                MySqlConnection conn = new MySqlConnection(db.ConnStr);


                string sql = "INSERT INTO Sælger(Tlf, Fornavn, Efternavn, Brugernavn, Kodeord) " +
                             "VALUES (@Tlf, @Fornavn, @Efternavn, @Brugernavn, HEX(AES_ENCRYPT(@Kodeord, 'somethingfunnyhere')));";


                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Tlf", textBox2.Text);
                cmd.Parameters.AddWithValue("@Fornavn", textBox3.Text);
                cmd.Parameters.AddWithValue("@Efternavn", textBox4.Text);
                cmd.Parameters.AddWithValue("@Brugernavn", textBox5.Text);
                cmd.Parameters.AddWithValue("@Kodeord", textBox6.Text);

                conn.Open();
                cmd.ExecuteNonQuery();

                #region PassToGrid
                DataTable tbl = new DataTable();
                string sqlshow = "SELECT * FROM Sælger;";
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
