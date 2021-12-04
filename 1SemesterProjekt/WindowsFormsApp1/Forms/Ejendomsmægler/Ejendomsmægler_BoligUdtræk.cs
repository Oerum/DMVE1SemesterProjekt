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
    public partial class Ejendomsmægler_BoligUdtræk : Form
    {
        public Ejendomsmægler_BoligUdtræk()
        {
            InitializeComponent();
            try
            {
                #region PassToGrid
                foreach (var v in Ejendomsmægler_InputDato.BoligUdtrækList)
                {
                    dataGridView1.Columns.Add("Keys", $"SælgerID: {v.SælgerID}\n\nBoligID: {v.BoligID}\nKøberID: {v.KøberID}\nPris: {v.Pris}\nM2: {v.M2}\nBy: {v.By}\nPostNr: {v.PostNr}\nAdresse: {v.Adresse}\nEtager: {v.Etager}\nByggeår: {v.Byggeår}\nBoligtype: {v.Boligtype}\nVærelser: {v.Værelser}\nEnergimærke: {v.Energimærke}\nOprettelsesDato: {v.OprettelsesDato}\nHandelsDato: {v.HandelsDato}");
                }
                #endregion PassToGrid
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ejendomsmægler_BoligUdtrækPris boligUdtrækPris = new Ejendomsmægler_BoligUdtrækPris();
            boligUdtrækPris.Show();
            this.Hide();
        }
    }
}
