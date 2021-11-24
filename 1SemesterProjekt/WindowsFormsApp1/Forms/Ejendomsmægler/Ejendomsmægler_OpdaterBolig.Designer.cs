
namespace WindowsFormsApp1.Forms
{
    partial class Ejendomsmægler_OpdaterBolig
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ejendomsmæglerDataSet = new WindowsFormsApp1.EjendomsmæglerDataSet();
            this.ejendomsmæglerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boligTilSalgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oprettelsesDatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postNrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sælgerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boligIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boligTilSalgTableAdapter = new WindowsFormsApp1.EjendomsmæglerDataSetTableAdapters.BoligTilSalgTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligTilSalgBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(316, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 31);
            this.label6.TabIndex = 27;
            this.label6.Text = "Opdatering Af Bolig";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 31);
            this.button2.TabIndex = 26;
            this.button2.Text = "Hent";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 42);
            this.button1.TabIndex = 25;
            this.button1.Text = "Eksekver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(15, 370);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(104, 20);
            this.textBox5.TabIndex = 24;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(15, 309);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(104, 20);
            this.textBox4.TabIndex = 23;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(15, 249);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(104, 20);
            this.textBox3.TabIndex = 22;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 185);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(104, 20);
            this.textBox2.TabIndex = 21;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "PostNr";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "M2";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Pris";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(11, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "SælgerID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "BoligID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ejendomsmæglerDataSet
            // 
            this.ejendomsmæglerDataSet.DataSetName = "EjendomsmæglerDataSet";
            this.ejendomsmæglerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ejendomsmæglerDataSetBindingSource
            // 
            this.ejendomsmæglerDataSetBindingSource.DataSource = this.ejendomsmæglerDataSet;
            this.ejendomsmæglerDataSetBindingSource.Position = 0;
            this.ejendomsmæglerDataSetBindingSource.CurrentChanged += new System.EventHandler(this.ejendomsmæglerDataSetBindingSource_CurrentChanged);
            // 
            // boligTilSalgBindingSource
            // 
            this.boligTilSalgBindingSource.DataMember = "BoligTilSalg";
            this.boligTilSalgBindingSource.DataSource = this.ejendomsmæglerDataSetBindingSource;
            this.boligTilSalgBindingSource.CurrentChanged += new System.EventHandler(this.boligTilSalgBindingSource_CurrentChanged);
            // 
            // oprettelsesDatoDataGridViewTextBoxColumn
            // 
            this.oprettelsesDatoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.oprettelsesDatoDataGridViewTextBoxColumn.DataPropertyName = "OprettelsesDato";
            this.oprettelsesDatoDataGridViewTextBoxColumn.HeaderText = "OprettelsesDato";
            this.oprettelsesDatoDataGridViewTextBoxColumn.Name = "oprettelsesDatoDataGridViewTextBoxColumn";
            // 
            // postNrDataGridViewTextBoxColumn
            // 
            this.postNrDataGridViewTextBoxColumn.DataPropertyName = "PostNr";
            this.postNrDataGridViewTextBoxColumn.HeaderText = "PostNr";
            this.postNrDataGridViewTextBoxColumn.Name = "postNrDataGridViewTextBoxColumn";
            // 
            // m2DataGridViewTextBoxColumn
            // 
            this.m2DataGridViewTextBoxColumn.DataPropertyName = "M2";
            this.m2DataGridViewTextBoxColumn.HeaderText = "M2";
            this.m2DataGridViewTextBoxColumn.Name = "m2DataGridViewTextBoxColumn";
            // 
            // prisDataGridViewTextBoxColumn
            // 
            this.prisDataGridViewTextBoxColumn.DataPropertyName = "Pris";
            this.prisDataGridViewTextBoxColumn.HeaderText = "Pris";
            this.prisDataGridViewTextBoxColumn.Name = "prisDataGridViewTextBoxColumn";
            // 
            // sælgerIDDataGridViewTextBoxColumn
            // 
            this.sælgerIDDataGridViewTextBoxColumn.DataPropertyName = "SælgerID";
            this.sælgerIDDataGridViewTextBoxColumn.HeaderText = "SælgerID";
            this.sælgerIDDataGridViewTextBoxColumn.Name = "sælgerIDDataGridViewTextBoxColumn";
            // 
            // boligIDDataGridViewTextBoxColumn
            // 
            this.boligIDDataGridViewTextBoxColumn.DataPropertyName = "BoligID";
            this.boligIDDataGridViewTextBoxColumn.HeaderText = "BoligID";
            this.boligIDDataGridViewTextBoxColumn.Name = "boligIDDataGridViewTextBoxColumn";
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
            this.boligIDDataGridViewTextBoxColumn,
            this.sælgerIDDataGridViewTextBoxColumn,
            this.prisDataGridViewTextBoxColumn,
            this.m2DataGridViewTextBoxColumn,
            this.postNrDataGridViewTextBoxColumn,
            this.oprettelsesDatoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.boligTilSalgBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(139, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 391);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Ejendomsmægler_OpdaterBolig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ejendomsmægler_OpdaterBolig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejendomsmægler_OpdaterBolig";
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligTilSalgBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private EjendomsmæglerDataSet ejendomsmæglerDataSet;
        private System.Windows.Forms.BindingSource ejendomsmæglerDataSetBindingSource;
        private System.Windows.Forms.BindingSource boligTilSalgBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn oprettelsesDatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postNrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sælgerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boligIDDataGridViewTextBoxColumn;
        private EjendomsmæglerDataSetTableAdapters.BoligTilSalgTableAdapter boligTilSalgTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}