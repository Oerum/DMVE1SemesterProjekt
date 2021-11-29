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
    public partial class Sælger_SingePage : Form
    {
        public Sælger_SingePage()
        {
            InitializeComponent();
            panel1.Controls.Clear();
            Sælger_OpdaterBolig OpdaterBolig = new Sælger_OpdaterBolig();
            OpdaterBolig.TopLevel = false;
            OpdaterBolig.AutoScroll = true;
            panel1.Controls.Add(OpdaterBolig);
            OpdaterBolig.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }


    }
}
