
namespace WindowsFormsApp1.Forms
{
    partial class Ejendomsmægler_OpretBolig
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.boligIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sælgerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postNrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oprettelsesDatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boligTilSalgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ejendomsmæglerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ejendomsmæglerDataSet1 = new WindowsFormsApp1.EjendomsmæglerDataSet();
            this.boligTilSalgBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.boligTilSalgTableAdapter1 = new WindowsFormsApp1.EjendomsmæglerDataSetTableAdapters.BoligTilSalgTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligTilSalgBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligTilSalgBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.DataSource = this.boligTilSalgBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(136, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 391);
            this.dataGridView1.TabIndex = 0;
            // 
            // boligIDDataGridViewTextBoxColumn
            // 
            this.boligIDDataGridViewTextBoxColumn.DataPropertyName = "BoligID";
            this.boligIDDataGridViewTextBoxColumn.HeaderText = "BoligID";
            this.boligIDDataGridViewTextBoxColumn.Name = "boligIDDataGridViewTextBoxColumn";
            // 
            // sælgerIDDataGridViewTextBoxColumn
            // 
            this.sælgerIDDataGridViewTextBoxColumn.DataPropertyName = "SælgerID";
            this.sælgerIDDataGridViewTextBoxColumn.HeaderText = "SælgerID";
            this.sælgerIDDataGridViewTextBoxColumn.Name = "sælgerIDDataGridViewTextBoxColumn";
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
            // postNrDataGridViewTextBoxColumn
            // 
            this.postNrDataGridViewTextBoxColumn.DataPropertyName = "PostNr";
            this.postNrDataGridViewTextBoxColumn.HeaderText = "PostNr";
            this.postNrDataGridViewTextBoxColumn.Name = "postNrDataGridViewTextBoxColumn";
            // 
            // oprettelsesDatoDataGridViewTextBoxColumn
            // 
            this.oprettelsesDatoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.oprettelsesDatoDataGridViewTextBoxColumn.DataPropertyName = "OprettelsesDato";
            this.oprettelsesDatoDataGridViewTextBoxColumn.HeaderText = "OprettelsesDato";
            this.oprettelsesDatoDataGridViewTextBoxColumn.Name = "oprettelsesDatoDataGridViewTextBoxColumn";
            // 
            // boligTilSalgBindingSource
            // 
            this.boligTilSalgBindingSource.DataMember = "BoligTilSalg";
            this.boligTilSalgBindingSource.DataSource = this.ejendomsmæglerDataSetBindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "BoligID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "SælgerID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pris";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "M2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "PostNr";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(17, 145);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(104, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(17, 208);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(104, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(17, 277);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(104, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(17, 347);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(104, 20);
            this.textBox5.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 49);
            this.button1.TabIndex = 11;
            this.button1.Text = "Eksekver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(313, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "Oprettelse Af Bolig";
            // 
            // ejendomsmæglerDataSet1
            // 
            this.ejendomsmæglerDataSet1.DataSetName = "EjendomsmæglerDataSet";
            this.ejendomsmæglerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boligTilSalgBindingSource1
            // 
            this.boligTilSalgBindingSource1.DataMember = "BoligTilSalg";
            this.boligTilSalgBindingSource1.DataSource = this.ejendomsmæglerDataSet1;
            // 
            // boligTilSalgTableAdapter1
            // 
            this.boligTilSalgTableAdapter1.ClearBeforeFill = true;
            // 
            // Ejendomsmægler_OpretBolig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
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
            this.Name = "Ejendomsmægler_OpretBolig";
            this.Text = "Ejendomsmægler";
            this.Load += new System.EventHandler(this.Ejendomsmægler_OpretBolig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligTilSalgBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligTilSalgBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource ejendomsmæglerDataSetBindingSource;
        private EjendomsmæglerDataSet ejendomsmæglerDataSet;
        private System.Windows.Forms.BindingSource boligTilSalgBindingSource;
        private EjendomsmæglerDataSetTableAdapters.BoligTilSalgTableAdapter boligTilSalgTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn boligIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sælgerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postNrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oprettelsesDatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private EjendomsmæglerDataSet ejendomsmæglerDataSet1;
        private System.Windows.Forms.BindingSource boligTilSalgBindingSource1;
        private EjendomsmæglerDataSetTableAdapters.BoligTilSalgTableAdapter boligTilSalgTableAdapter1;
    }
}