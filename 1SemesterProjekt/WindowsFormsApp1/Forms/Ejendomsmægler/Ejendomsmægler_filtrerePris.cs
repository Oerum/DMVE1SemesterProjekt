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
        char test { get; set; }
        public Ejendomsmægler_filtrerePris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region PassToGrid
            List<string> BoligUdtræk = Ejendomsmægler_InputDato.BoligUdtræk;

            int choice = Convert.ToInt32(textBox1.Text);

            int index = BoligUdtræk.FindIndex(str => str.Contains("Pris = "));
            var value = BoligUdtræk.Find(str => str == "Pris = ");

            Console.WriteLine(value);

            foreach (var v in BoligUdtræk[index])
            {  
                Console.Write(v);
            }

            Ejendomsmægler_BoligUdtrækPris boligUdtrækPris = new Ejendomsmægler_BoligUdtrækPris();
            boligUdtrækPris.Show();

            Console.WriteLine(test);
            #endregion PassToGrid
        }
    }
}
