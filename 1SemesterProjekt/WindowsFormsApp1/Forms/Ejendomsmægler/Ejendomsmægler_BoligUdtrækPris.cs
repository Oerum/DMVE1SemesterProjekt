﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms.Ejendomsmægler
{
    public partial class Ejendomsmægler_BoligUdtrækPris : Form
    {
        int Choice { get; set; }
        public Ejendomsmægler_BoligUdtrækPris()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            Choice = Convert.ToInt32(textBox1.Text);

            foreach (var v in Ejendomsmægler_InputDato.BoligUdtrækList)
            {
                if (v.Pris >= Choice)
                {
                    dataGridView1.Columns.Add("Keys", $"SælgerID: {v.SælgerID}\n\nBoligID: {v.BoligID}\nKøberID: {v.KøberID}\nPris: {v.Pris}\nM2: {v.M2}\nBy: {v.By}\nPostNr: {v.PostNr}\nAdresse: {v.Adresse}\nEtager: {v.Etager}\nByggeår: {v.Byggeår}\nBoligtype: {v.Boligtype}\nVærelser: {v.Værelser}\nEnergimærke: {v.Energimærke}\nOprettelsesDato: {v.OprettelsesDato}\nHandelsDato: {v.HandelsDato}");
                }
            }
        }
    }
}
