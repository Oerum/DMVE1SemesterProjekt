
namespace WindowsFormsApp1.Forms
{
    partial class Ejendomsmægler_OpdaterSælger
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boligTilSalgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ejendomsmæglerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Brugernavn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kodeord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sælgerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sælgerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ejendomsmæglerDataSet2 = new WindowsFormsApp1.EjendomsmæglerDataSet();
            this.sælgerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sælgerTableAdapter2 = new WindowsFormsApp1.EjendomsmæglerDataSetTableAdapters.SælgerTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brugernavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.boligTilSalgBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sælgerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sælgerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sælgerBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(315, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(295, 31);
            this.label6.TabIndex = 41;
            this.label6.Text = "Opdatering Af Sælger";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 41);
            this.button2.TabIndex = 40;
            this.button2.Text = "Hent";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 49);
            this.button1.TabIndex = 39;
            this.button1.Text = "Eksekver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(13, 344);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(104, 20);
            this.textBox4.TabIndex = 37;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(14, 275);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(104, 20);
            this.textBox3.TabIndex = 36;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 201);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(104, 20);
            this.textBox2.TabIndex = 35;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 20);
            this.textBox1.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(10, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 32;
            this.label4.Text = "Efternavn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(11, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 31;
            this.label3.Text = "Fornavn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tlf";
            // 
            // boligTilSalgBindingSource
            // 
            this.boligTilSalgBindingSource.DataMember = "BoligTilSalg";
            this.boligTilSalgBindingSource.DataSource = this.ejendomsmæglerDataSetBindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Brugernavn,
            this.Kodeord,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.brugernavnDataGridViewTextBoxColumn,
            this.kodeordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sælgerBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(138, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 391);
            this.dataGridView1.TabIndex = 28;
            // 
            // Brugernavn
            // 
            this.Brugernavn.DataPropertyName = "Brugernavn";
            this.Brugernavn.HeaderText = "Brugernavn";
            this.Brugernavn.Name = "Brugernavn";
            // 
            // Kodeord
            // 
            this.Kodeord.DataPropertyName = "Kodeord";
            this.Kodeord.HeaderText = "Kodeord";
            this.Kodeord.Name = "Kodeord";
            // 
            // sælgerBindingSource1
            // 
            this.sælgerBindingSource1.DataMember = "Sælger";
            // 
            // sælgerBindingSource
            // 
            this.sælgerBindingSource.DataMember = "Sælger";
            this.sælgerBindingSource.DataSource = this.ejendomsmæglerDataSetBindingSource;
            // 
            // ejendomsmæglerDataSet2
            // 
            this.ejendomsmæglerDataSet2.DataSetName = "EjendomsmæglerDataSet";
            this.ejendomsmæglerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sælgerBindingSource2
            // 
            this.sælgerBindingSource2.DataMember = "Sælger";
            this.sælgerBindingSource2.DataSource = this.ejendomsmæglerDataSet2;
            // 
            // sælgerTableAdapter2
            // 
            this.sælgerTableAdapter2.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Tlf";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tlf";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Fornavn";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fornavn";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Efternavn";
            this.dataGridViewTextBoxColumn4.HeaderText = "Efternavn";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // brugernavnDataGridViewTextBoxColumn
            // 
            this.brugernavnDataGridViewTextBoxColumn.DataPropertyName = "Brugernavn";
            this.brugernavnDataGridViewTextBoxColumn.HeaderText = "Brugernavn";
            this.brugernavnDataGridViewTextBoxColumn.Name = "brugernavnDataGridViewTextBoxColumn";
            // 
            // kodeordDataGridViewTextBoxColumn
            // 
            this.kodeordDataGridViewTextBoxColumn.DataPropertyName = "Kodeord";
            this.kodeordDataGridViewTextBoxColumn.HeaderText = "Kodeord";
            this.kodeordDataGridViewTextBoxColumn.Name = "kodeordDataGridViewTextBoxColumn";
            // 
            // Ejendomsmægler_OpdaterSælger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ejendomsmægler_OpdaterSælger";
            this.Text = "Ejendomsmægler_OpdaterSælger";
            this.Load += new System.EventHandler(this.Ejendomsmægler_OpdaterSælger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boligTilSalgBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sælgerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sælgerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sælgerBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource boligTilSalgBindingSource;
        private System.Windows.Forms.BindingSource ejendomsmæglerDataSetBindingSource;
        private EjendomsmæglerDataSet ejendomsmæglerDataSet;
        private System.Windows.Forms.Label label1;
        private EjendomsmæglerDataSetTableAdapters.BoligTilSalgTableAdapter boligTilSalgTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sælgerBindingSource;
        private EjendomsmæglerDataSetTableAdapters.SælgerTableAdapter sælgerTableAdapter;
        private EjendomsmæglerDataSet ejendomsmæglerDataSet1;
        private System.Windows.Forms.BindingSource sælgerBindingSource1;
        private EjendomsmæglerDataSetTableAdapters.SælgerTableAdapter sælgerTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn efternavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brugernavn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kodeord;
        private EjendomsmæglerDataSet ejendomsmæglerDataSet2;
        private System.Windows.Forms.BindingSource sælgerBindingSource2;
        private EjendomsmæglerDataSetTableAdapters.SælgerTableAdapter sælgerTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn brugernavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeordDataGridViewTextBoxColumn;
    }
}