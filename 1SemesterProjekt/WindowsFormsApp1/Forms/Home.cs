using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Forms.Køber;
using WindowsFormsApp1.Forms.Sælger;

namespace WindowsFormsApp1.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ejendomsmægler_Login login = new Ejendomsmægler_Login();
            login.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sælger_Login login = new Sælger_Login();
            login.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Køber_Login login = new Køber_Login();
            login.Show();
            this.Hide();
        }
    }
}
