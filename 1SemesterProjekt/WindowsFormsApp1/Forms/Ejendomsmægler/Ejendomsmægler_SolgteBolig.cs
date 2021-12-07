using DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms.Ejendomsmægler
{
    public partial class Ejendomsmægler_SolgteBolig : Form
    {
        
        public Ejendomsmægler_SolgteBolig()
        {
            InitializeComponent();
            try
            {
                #region PassToGrid
                DB db = new DB();
                DataTable tbl = db.Ejendomsmægler_SolgteBolig_PassToGrid();
                dataGridView1.DataSource = tbl;
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
                Ejendomsmægler_InputPostNr PostNr = new Ejendomsmægler_InputPostNr();
                PostNr.Show();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"{ex}");
            }
              
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Ejendomsmægler_InputDato Dato = new Ejendomsmægler_InputDato();
                Dato.Show();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"{ex}");
            }
        }
    }
}
