
namespace WindowsFormsApp1.Forms
{
    partial class Ejendomsmægler_OpretSælger
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boligTilSalgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ejendomsmæglerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ejendomsmæglerDataSet = new WindowsFormsApp1.EjendomsmæglerDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efternavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brugernavn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kodeord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sælgerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.sælgerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.boligTilSalgTableAdapter = new WindowsFormsApp1.EjendomsmæglerDataSetTableAdapters.BoligTilSalgTableAdapter();
            this.sælgerTableAdapter = new WindowsFormsApp1.EjendomsmæglerDataSetTableAdapters.SælgerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.boligTilSalgBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sælgerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sælgerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(316, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(287, 31);
            this.label6.TabIndex = 27;
            this.label6.Text = "Oprettelse Af Sælger";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 42);
            this.button1.TabIndex = 25;
            this.button1.Text = "Eksekver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(13, 174);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(104, 20);
            this.textBox4.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(13, 124);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(104, 20);
            this.textBox3.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(104, 20);
            this.textBox2.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(9, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Efternavn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(9, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Fornavn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tlf";
            // 
            // boligTilSalgBindingSource
            // 
            this.boligTilSalgBindingSource.DataMember = "BoligTilSalg";
            this.boligTilSalgBindingSource.DataSource = this.ejendomsmæglerDataSetBindingSource;
            // 
            // ejendomsmæglerDataSetBindingSource
            // 
            this.ejendomsmæglerDataSetBindingSource.DataSource = this.ejendomsmæglerDataSet;
            this.ejendomsmæglerDataSetBindingSource.Position = 0;
            // 
            // ejendomsmæglerDataSet
            // 
            this.ejendomsmæglerDataSet.DataSetName = "EjendomsmæglerDataSet";
            this.ejendomsmæglerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.tlfDataGridViewTextBoxColumn,
            this.fornavnDataGridViewTextBoxColumn,
            this.efternavnDataGridViewTextBoxColumn,
            this.Brugernavn,
            this.Kodeord});
            this.dataGridView1.DataSource = this.sælgerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(139, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 391);
            this.dataGridView1.TabIndex = 14;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // tlfDataGridViewTextBoxColumn
            // 
            this.tlfDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tlfDataGridViewTextBoxColumn.DataPropertyName = "Tlf";
            this.tlfDataGridViewTextBoxColumn.HeaderText = "Tlf";
            this.tlfDataGridViewTextBoxColumn.Name = "tlfDataGridViewTextBoxColumn";
            // 
            // fornavnDataGridViewTextBoxColumn
            // 
            this.fornavnDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fornavnDataGridViewTextBoxColumn.DataPropertyName = "Fornavn";
            this.fornavnDataGridViewTextBoxColumn.HeaderText = "Fornavn";
            this.fornavnDataGridViewTextBoxColumn.Name = "fornavnDataGridViewTextBoxColumn";
            // 
            // efternavnDataGridViewTextBoxColumn
            // 
            this.efternavnDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.efternavnDataGridViewTextBoxColumn.DataPropertyName = "Efternavn";
            this.efternavnDataGridViewTextBoxColumn.HeaderText = "Efternavn";
            this.efternavnDataGridViewTextBoxColumn.Name = "efternavnDataGridViewTextBoxColumn";
            // 
            // Brugernavn
            // 
            this.Brugernavn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Brugernavn.DataPropertyName = "Brugernavn";
            this.Brugernavn.HeaderText = "Brugernavn";
            this.Brugernavn.Name = "Brugernavn";
            // 
            // Kodeord
            // 
            this.Kodeord.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kodeord.DataPropertyName = "Kodeord";
            this.Kodeord.HeaderText = "Kodeord";
            this.Kodeord.Name = "Kodeord";
            // 
            // sælgerBindingSource
            // 
            this.sælgerBindingSource.DataMember = "Sælger";
            this.sælgerBindingSource.DataSource = this.ejendomsmæglerDataSetBindingSource;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "Brugernavn";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(13, 224);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(104, 20);
            this.textBox5.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(12, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 24);
            this.label7.TabIndex = 30;
            this.label7.Text = "Kodeord";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(13, 274);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(104, 20);
            this.textBox6.TabIndex = 31;
            // 
            // sælgerBindingSource1
            // 
            this.sælgerBindingSource1.DataMember = "Sælger";
            this.sælgerBindingSource1.DataSource = this.ejendomsmæglerDataSetBindingSource;
            // 
            // boligTilSalgTableAdapter
            // 
            this.boligTilSalgTableAdapter.ClearBeforeFill = true;
            // 
            // sælgerTableAdapter
            // 
            this.sælgerTableAdapter.ClearBeforeFill = true;
            // 
            // Ejendomsmægler_OpretSælger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ejendomsmægler_OpretSælger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejendomsmægler_OpretSælger";
            ((System.ComponentModel.ISupportInitialize)(this.boligTilSalgBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sælgerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sælgerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private EjendomsmæglerDataSet ejendomsmæglerDataSet;
        private System.Windows.Forms.BindingSource ejendomsmæglerDataSetBindingSource;
        private System.Windows.Forms.BindingSource boligTilSalgBindingSource;
        private EjendomsmæglerDataSetTableAdapters.BoligTilSalgTableAdapter boligTilSalgTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.BindingSource sælgerBindingSource;
        private EjendomsmæglerDataSetTableAdapters.SælgerTableAdapter sælgerTableAdapter;
        private System.Windows.Forms.BindingSource sælgerBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn efternavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brugernavn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kodeord;
    }
}