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
    public partial class Ejendomsmægler_SinglePage : Form
    {
        public Ejendomsmægler_SinglePage()
        {
            InitializeComponent();
            panel1.Controls.Clear();
            Ejendomsmægler_OpretBolig OpretBolig = new Ejendomsmægler_OpretBolig();
            OpretBolig.TopLevel = false;
            OpretBolig.AutoScroll = true;
            panel1.Controls.Add(OpretBolig);
            OpretBolig.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Ejendomsmægler_OpretBolig OpretBolig = new Ejendomsmægler_OpretBolig();
            OpretBolig.TopLevel = false;
            OpretBolig.AutoScroll = true;
            panel1.Controls.Add(OpretBolig);
            OpretBolig.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Ejendomsmægler_OpdaterBolig OpdaterBolig = new Ejendomsmægler_OpdaterBolig();
            OpdaterBolig.TopLevel = false;
            OpdaterBolig.AutoScroll = true;
            panel1.Controls.Add(OpdaterBolig);
            OpdaterBolig.Show();
        }
    }
}
