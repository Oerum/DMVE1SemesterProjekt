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
    public partial class Ejendomsmægler_InputPostNr : Form
    {
        public static string InputPostNr { get; set; }
        public static bool IsActive { get; set; }
        public Ejendomsmægler_InputPostNr()
        {
            InitializeComponent();
            IsActive = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InputPostNr = textBox1.Text;
            IsActive = false;

            try
            {
                try
                {
                    if (InputPostNr != null)
                    {
                        DB db = new DB();
                        db.Ejendomsmægler_InputPostNrSQL();
                    }
                    this.Hide();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"{ex}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ugyldigt PostNr");
            }
            
            
        }
    }
}
