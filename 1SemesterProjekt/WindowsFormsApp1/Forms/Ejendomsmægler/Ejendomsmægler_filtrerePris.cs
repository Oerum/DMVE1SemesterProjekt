using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utf8Json;

namespace WindowsFormsApp1.Forms.Ejendomsmægler
{
    public partial class Ejendomsmægler_filtrerePris : Form
    {
        public static int Choice { get; set; }
        public Ejendomsmægler_filtrerePris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Choice = Convert.ToInt32(textBox1.Text);
            Ejendomsmægler_BoligUdtrækPris boligUdtrækPris = new Ejendomsmægler_BoligUdtrækPris();
            boligUdtrækPris.Show();
        }
    }
}
