using DAL;
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

namespace WindowsFormsApp1.Forms.Sælger
{
    public partial class Sælger_OpdaterBolig : Form
    {
        public static int SælgerID { get; set; }
        public static int BoligID { get; set; }
        public static int Pris { get; set; }
        public Sælger_OpdaterBolig()
        {

            InitializeComponent();
            #region PassToGrid
            DB db = new DB();
            DataTable tbl = db.Sælger_OpdaterBolig_PassToGrid();
            dataGridView1.DataSource = tbl;
            #endregion PassToGrid  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                BoligID = Convert.ToInt32(textBox1.Text);
                DB db = new DB();

                db.Sælger_OpdaterBoligButton2SQL();

                if (Convert.ToInt32(Sælger_Login.Sælger_ID_LoggedIn) == SælgerID)
                {
                    textBox2.Text = Convert.ToString(SælgerID);
                    textBox3.Text = Convert.ToString(Pris);

                }
                else
                {
                    #region PassToGrid
                    MessageBox.Show("Dit SælgerID er ikke tilknyttet denne bolig");
                    DataTable tbl = db.Sælger_OpdaterBolig_PassToGrid();
                    dataGridView1.DataSource = tbl;
                    #endregion PassToGrid  

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                
                if (Sælger_Login.Sælger_ID_LoggedIn == textBox2.Text)
                {
                    SælgerID = Convert.ToInt32(textBox2.Text);
                    Pris = Convert.ToInt32(textBox3.Text);
                    BoligID = Convert.ToInt32(textBox1.Text);

                    db.Sælger_OpdaterBoligButton1SQL();

                    MessageBox.Show("Fuldført");
                    #region PassToGrid
                    DataTable tbl = db.Sælger_OpdaterBolig_PassToGrid();
                    dataGridView1.DataSource = tbl;
                    #endregion PassToGrid  
                }
                else
                {
                    MessageBox.Show($"Du er ikke tilknyttet boligen du forsøger at ændre");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }
    }
}
