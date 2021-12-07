
namespace WindowsFormsApp1.Forms
{
    partial class Ejendomsmægler_SletBolig
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
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.boligTilSalgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ejendomsmæglerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ejendomsmæglerDataSet = new WindowsFormsApp1.EjendomsmæglerDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.boligTilSalgTableAdapter = new WindowsFormsApp1.EjendomsmæglerDataSetTableAdapters.BoligTilSalgTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Etager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boligIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.boligTilSalgBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(621, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 31);
            this.label6.TabIndex = 41;
            this.label6.Text = "Sletning Af Bolig";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 42);
            this.button1.TabIndex = 39;
            this.button1.Text = "Eksekver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 363);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 20);
            this.textBox1.TabIndex = 34;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // boligTilSalgBindingSource
            // 
            this.boligTilSalgBindingSource.DataMember = "BoligTilSalg";
            this.boligTilSalgBindingSource.DataSource = this.ejendomsmæglerDataSetBindingSource;
            this.boligTilSalgBindingSource.CurrentChanged += new System.EventHandler(this.boligTilSalgBindingSource_CurrentChanged);
            // 
            // ejendomsmæglerDataSetBindingSource
            // 
            this.ejendomsmæglerDataSetBindingSource.DataSource = this.ejendomsmæglerDataSet;
            this.ejendomsmæglerDataSetBindingSource.Position = 0;
            this.ejendomsmæglerDataSetBindingSource.CurrentChanged += new System.EventHandler(this.ejendomsmæglerDataSetBindingSource_CurrentChanged);
            // 
            // ejendomsmæglerDataSet
            // 
            this.ejendomsmæglerDataSet.DataSetName = "EjendomsmæglerDataSet";
            this.ejendomsmæglerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "BoligID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // boligTilSalgTableAdapter
            // 
            this.boligTilSalgTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Etager,
            this.boligIDDataGridViewTextBoxColumn,
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
            this.oprettelsesDatoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.boligTilSalgBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(142, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1346, 704);
            this.dataGridView1.TabIndex = 78;
            // 
            // Etager
            // 
            this.Etager.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Etager.DataPropertyName = "Etager";
            this.Etager.HeaderText = "Etager";
            this.Etager.Name = "Etager";
            this.Etager.Width = 63;
            // 
            // boligIDDataGridViewTextBoxColumn
            // 
            this.boligIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.boligIDDataGridViewTextBoxColumn.DataPropertyName = "BoligID";
            this.boligIDDataGridViewTextBoxColumn.HeaderText = "BoligID";
            this.boligIDDataGridViewTextBoxColumn.Name = "boligIDDataGridViewTextBoxColumn";
            this.boligIDDataGridViewTextBoxColumn.Width = 66;
            // 
            // sælgerIDDataGridViewTextBoxColumn
            // 
            this.sælgerIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sælgerIDDataGridViewTextBoxColumn.DataPropertyName = "SælgerID";
            this.sælgerIDDataGridViewTextBoxColumn.HeaderText = "SælgerID";
            this.sælgerIDDataGridViewTextBoxColumn.Name = "sælgerIDDataGridViewTextBoxColumn";
            this.sælgerIDDataGridViewTextBoxColumn.Width = 77;
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
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.Width = 200;
            // 
            // etagerDataGridViewTextBoxColumn
            // 
            this.etagerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.etagerDataGridViewTextBoxColumn.DataPropertyName = "Etager";
            this.etagerDataGridViewTextBoxColumn.HeaderText = "Etager";
            this.etagerDataGridViewTextBoxColumn.Name = "etagerDataGridViewTextBoxColumn";
            this.etagerDataGridViewTextBoxColumn.Width = 63;
            // 
            // byggeårDataGridViewTextBoxColumn
            // 
            this.byggeårDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.byggeårDataGridViewTextBoxColumn.DataPropertyName = "Byggeår";
            this.byggeårDataGridViewTextBoxColumn.HeaderText = "Byggeår";
            this.byggeårDataGridViewTextBoxColumn.Name = "byggeårDataGridViewTextBoxColumn";
            this.byggeårDataGridViewTextBoxColumn.Width = 71;
            // 
            // boligtypeDataGridViewTextBoxColumn
            // 
            this.boligtypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.boligtypeDataGridViewTextBoxColumn.DataPropertyName = "Boligtype";
            this.boligtypeDataGridViewTextBoxColumn.HeaderText = "Boligtype";
            this.boligtypeDataGridViewTextBoxColumn.Name = "boligtypeDataGridViewTextBoxColumn";
            this.boligtypeDataGridViewTextBoxColumn.Width = 75;
            // 
            // værelserDataGridViewTextBoxColumn
            // 
            this.værelserDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.værelserDataGridViewTextBoxColumn.DataPropertyName = "Værelser";
            this.værelserDataGridViewTextBoxColumn.HeaderText = "Værelser";
            this.værelserDataGridViewTextBoxColumn.Name = "værelserDataGridViewTextBoxColumn";
            this.værelserDataGridViewTextBoxColumn.Width = 74;
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
            this.oprettelsesDatoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.oprettelsesDatoDataGridViewTextBoxColumn.DataPropertyName = "OprettelsesDato";
            this.oprettelsesDatoDataGridViewTextBoxColumn.HeaderText = "OprettelsesDato";
            this.oprettelsesDatoDataGridViewTextBoxColumn.Name = "oprettelsesDatoDataGridViewTextBoxColumn";
            // 
            // Ejendomsmægler_SletBolig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 779);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ejendomsmægler_SletBolig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejendomsmægler_SletBolig";
            ((System.ComponentModel.ISupportInitialize)(this.boligTilSalgBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource boligTilSalgBindingSource;
        private System.Windows.Forms.BindingSource ejendomsmæglerDataSetBindingSource;
        private EjendomsmæglerDataSet ejendomsmæglerDataSet;
        private System.Windows.Forms.Label label1;
        private EjendomsmæglerDataSetTableAdapters.BoligTilSalgTableAdapter boligTilSalgTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etager;
        private System.Windows.Forms.DataGridViewTextBoxColumn boligIDDataGridViewTextBoxColumn;
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
    }
}