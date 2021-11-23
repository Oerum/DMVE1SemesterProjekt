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

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Ejendomsmægler_SletBolig SletBolig = new Ejendomsmægler_SletBolig();
            SletBolig.TopLevel = false;
            SletBolig.AutoScroll = true;
            panel1.Controls.Add(SletBolig);
            SletBolig.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Ejendomsmægler_OpretSælger OpretSælger = new Ejendomsmægler_OpretSælger();
            OpretSælger.TopLevel = false;
            OpretSælger.AutoScroll = true;
            panel1.Controls.Add(OpretSælger);
            OpretSælger.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Ejendomsmægler_OpdaterSælger OpdaterSælger = new Ejendomsmægler_OpdaterSælger();
            OpdaterSælger.TopLevel = false;
            OpdaterSælger.AutoScroll = true;
            panel1.Controls.Add(OpdaterSælger);
            OpdaterSælger.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Ejendomsmægler_SletSælger SletSælger = new Ejendomsmægler_SletSælger();
            SletSælger.TopLevel = false;
            SletSælger.AutoScroll = true;
            panel1.Controls.Add(SletSælger);
            SletSælger.Show();
        }
    }
}
