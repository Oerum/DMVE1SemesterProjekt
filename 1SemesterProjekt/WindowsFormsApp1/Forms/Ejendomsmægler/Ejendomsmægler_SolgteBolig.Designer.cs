
namespace WindowsFormsApp1.Forms.Ejendomsmægler
{
    partial class Ejendomsmægler_SolgteBolig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.solgteBoligTableAdapter = new WindowsFormsApp1.EjendomsmæglerDataSetTableAdapters.SolgteBoligTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.ejendomsmæglerDataSet = new WindowsFormsApp1.EjendomsmæglerDataSet();
            this.solgteBoligBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.solgteBoligBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.boligIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.køberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sælgerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.byDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postNrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etagerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.byggeårDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boligtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.værelserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.energimærkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oprettelsesDatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.handelsDatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solgteBoligBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solgteBoligBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // solgteBoligTableAdapter
            // 
            this.solgteBoligTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 712);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(712, 20);
            this.button1.TabIndex = 44;
            this.button1.Text = "Hent informationer for PostNr";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ejendomsmæglerDataSet
            // 
            this.ejendomsmæglerDataSet.DataSetName = "EjendomsmæglerDataSet";
            this.ejendomsmæglerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // solgteBoligBindingSource
            // 
            this.solgteBoligBindingSource.DataMember = "SolgteBolig";
            this.solgteBoligBindingSource.DataSource = this.ejendomsmæglerDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.boligIDDataGridViewTextBoxColumn,
            this.køberIDDataGridViewTextBoxColumn,
            this.sælgerIDDataGridViewTextBoxColumn,
            this.prisDataGridViewTextBoxColumn,
            this.m2DataGridViewTextBoxColumn,
            this.byDataGridViewTextBoxColumn,
            this.postNrDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.etagerDataGridViewTextBoxColumn,
            this.byggeårDataGridViewTextBoxColumn,
            this.boligtypeDataGridViewTextBoxColumn,
            this.værelserDataGridViewTextBoxColumn,
            this.energimærkeDataGridViewTextBoxColumn,
            this.oprettelsesDatoDataGridViewTextBoxColumn,
            this.handelsDatoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.solgteBoligBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1451, 699);
            this.dataGridView1.TabIndex = 43;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(730, 712);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(733, 20);
            this.button2.TabIndex = 45;
            this.button2.Text = "Hent informationer for Dato";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // solgteBoligBindingSource1
            // 
            this.solgteBoligBindingSource1.DataMember = "SolgteBolig";
            this.solgteBoligBindingSource1.DataSource = this.ejendomsmæglerDataSet;
            // 
            // boligIDDataGridViewTextBoxColumn
            // 
            this.boligIDDataGridViewTextBoxColumn.DataPropertyName = "BoligID";
            this.boligIDDataGridViewTextBoxColumn.HeaderText = "BoligID";
            this.boligIDDataGridViewTextBoxColumn.Name = "boligIDDataGridViewTextBoxColumn";
            this.boligIDDataGridViewTextBoxColumn.Width = 75;
            // 
            // køberIDDataGridViewTextBoxColumn
            // 
            this.køberIDDataGridViewTextBoxColumn.DataPropertyName = "KøberID";
            this.køberIDDataGridViewTextBoxColumn.HeaderText = "KøberID";
            this.køberIDDataGridViewTextBoxColumn.Name = "køberIDDataGridViewTextBoxColumn";
            this.køberIDDataGridViewTextBoxColumn.Width = 75;
            // 
            // sælgerIDDataGridViewTextBoxColumn
            // 
            this.sælgerIDDataGridViewTextBoxColumn.DataPropertyName = "SælgerID";
            this.sælgerIDDataGridViewTextBoxColumn.HeaderText = "SælgerID";
            this.sælgerIDDataGridViewTextBoxColumn.Name = "sælgerIDDataGridViewTextBoxColumn";
            this.sælgerIDDataGridViewTextBoxColumn.Width = 75;
            // 
            // prisDataGridViewTextBoxColumn
            // 
            this.prisDataGridViewTextBoxColumn.DataPropertyName = "Pris";
            this.prisDataGridViewTextBoxColumn.HeaderText = "Pris";
            this.prisDataGridViewTextBoxColumn.Name = "prisDataGridViewTextBoxColumn";
            // 
            // m2DataGridViewTextBoxColumn
            // 
            this.m2DataGridViewTextBoxColumn.DataPropertyName = "M2";
            this.m2DataGridViewTextBoxColumn.HeaderText = "M2";
            this.m2DataGridViewTextBoxColumn.Name = "m2DataGridViewTextBoxColumn";
            this.m2DataGridViewTextBoxColumn.Width = 75;
            // 
            // byDataGridViewTextBoxColumn
            // 
            this.byDataGridViewTextBoxColumn.DataPropertyName = "By";
            this.byDataGridViewTextBoxColumn.HeaderText = "By";
            this.byDataGridViewTextBoxColumn.Name = "byDataGridViewTextBoxColumn";
            // 
            // postNrDataGridViewTextBoxColumn
            // 
            this.postNrDataGridViewTextBoxColumn.DataPropertyName = "PostNr";
            this.postNrDataGridViewTextBoxColumn.HeaderText = "PostNr";
            this.postNrDataGridViewTextBoxColumn.Name = "postNrDataGridViewTextBoxColumn";
            this.postNrDataGridViewTextBoxColumn.Width = 75;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            // 
            // etagerDataGridViewTextBoxColumn
            // 
            this.etagerDataGridViewTextBoxColumn.DataPropertyName = "Etager";
            this.etagerDataGridViewTextBoxColumn.HeaderText = "Etager";
            this.etagerDataGridViewTextBoxColumn.Name = "etagerDataGridViewTextBoxColumn";
            this.etagerDataGridViewTextBoxColumn.Width = 75;
            // 
            // byggeårDataGridViewTextBoxColumn
            // 
            this.byggeårDataGridViewTextBoxColumn.DataPropertyName = "Byggeår";
            this.byggeårDataGridViewTextBoxColumn.HeaderText = "Byggeår";
            this.byggeårDataGridViewTextBoxColumn.Name = "byggeårDataGridViewTextBoxColumn";
            this.byggeårDataGridViewTextBoxColumn.Width = 75;
            // 
            // boligtypeDataGridViewTextBoxColumn
            // 
            this.boligtypeDataGridViewTextBoxColumn.DataPropertyName = "Boligtype";
            this.boligtypeDataGridViewTextBoxColumn.HeaderText = "Boligtype";
            this.boligtypeDataGridViewTextBoxColumn.Name = "boligtypeDataGridViewTextBoxColumn";
            this.boligtypeDataGridViewTextBoxColumn.Width = 75;
            // 
            // værelserDataGridViewTextBoxColumn
            // 
            this.værelserDataGridViewTextBoxColumn.DataPropertyName = "Værelser";
            this.værelserDataGridViewTextBoxColumn.HeaderText = "Værelser";
            this.værelserDataGridViewTextBoxColumn.Name = "værelserDataGridViewTextBoxColumn";
            this.værelserDataGridViewTextBoxColumn.Width = 75;
            // 
            // energimærkeDataGridViewTextBoxColumn
            // 
            this.energimærkeDataGridViewTextBoxColumn.DataPropertyName = "Energimærke";
            this.energimærkeDataGridViewTextBoxColumn.HeaderText = "Energimærke";
            this.energimærkeDataGridViewTextBoxColumn.Name = "energimærkeDataGridViewTextBoxColumn";
            this.energimærkeDataGridViewTextBoxColumn.Width = 75;
            // 
            // oprettelsesDatoDataGridViewTextBoxColumn
            // 
            this.oprettelsesDatoDataGridViewTextBoxColumn.DataPropertyName = "OprettelsesDato";
            this.oprettelsesDatoDataGridViewTextBoxColumn.HeaderText = "OprettelsesDato";
            this.oprettelsesDatoDataGridViewTextBoxColumn.Name = "oprettelsesDatoDataGridViewTextBoxColumn";
            // 
            // handelsDatoDataGridViewTextBoxColumn
            // 
            this.handelsDatoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.handelsDatoDataGridViewTextBoxColumn.DataPropertyName = "HandelsDato";
            this.handelsDatoDataGridViewTextBoxColumn.HeaderText = "HandelsDato";
            this.handelsDatoDataGridViewTextBoxColumn.Name = "handelsDatoDataGridViewTextBoxColumn";
            // 
            // Ejendomsmægler_SolgteBolig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 744);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ejendomsmægler_SolgteBolig";
            this.Text = "Ejendomsmægler_SolgteBolig";
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solgteBoligBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solgteBoligBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EjendomsmæglerDataSetTableAdapters.SolgteBoligTableAdapter solgteBoligTableAdapter;
        private System.Windows.Forms.Button button1;
        private EjendomsmæglerDataSet ejendomsmæglerDataSet;
        private System.Windows.Forms.BindingSource solgteBoligBindingSource;
        private  System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource solgteBoligBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn boligIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn køberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sælgerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn byDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postNrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etagerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn byggeårDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boligtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn værelserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn energimærkeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oprettelsesDatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn handelsDatoDataGridViewTextBoxColumn;
    }
}