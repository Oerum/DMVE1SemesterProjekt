
namespace WindowsFormsApp1.Forms.Køber
{
    partial class Køber_Ordre
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
            this.køberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sælgerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postNrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OprettelsesDato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.handelsDatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solgteBoligBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ejendomsmæglerDataSet = new WindowsFormsApp1.EjendomsmæglerDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.solgteBoligTableAdapter = new WindowsFormsApp1.EjendomsmæglerDataSetTableAdapters.SolgteBoligTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solgteBoligBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.postNrDataGridViewTextBoxColumn,
            this.OprettelsesDato,
            this.handelsDatoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.solgteBoligBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(125, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(663, 410);
            this.dataGridView1.TabIndex = 0;
            // 
            // boligIDDataGridViewTextBoxColumn
            // 
            this.boligIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.boligIDDataGridViewTextBoxColumn.DataPropertyName = "BoligID";
            this.boligIDDataGridViewTextBoxColumn.HeaderText = "BoligID";
            this.boligIDDataGridViewTextBoxColumn.Name = "boligIDDataGridViewTextBoxColumn";
            // 
            // køberIDDataGridViewTextBoxColumn
            // 
            this.køberIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.køberIDDataGridViewTextBoxColumn.DataPropertyName = "KøberID";
            this.køberIDDataGridViewTextBoxColumn.HeaderText = "KøberID";
            this.køberIDDataGridViewTextBoxColumn.Name = "køberIDDataGridViewTextBoxColumn";
            // 
            // sælgerIDDataGridViewTextBoxColumn
            // 
            this.sælgerIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sælgerIDDataGridViewTextBoxColumn.DataPropertyName = "SælgerID";
            this.sælgerIDDataGridViewTextBoxColumn.HeaderText = "SælgerID";
            this.sælgerIDDataGridViewTextBoxColumn.Name = "sælgerIDDataGridViewTextBoxColumn";
            // 
            // prisDataGridViewTextBoxColumn
            // 
            this.prisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prisDataGridViewTextBoxColumn.DataPropertyName = "Pris";
            this.prisDataGridViewTextBoxColumn.HeaderText = "Pris";
            this.prisDataGridViewTextBoxColumn.Name = "prisDataGridViewTextBoxColumn";
            // 
            // m2DataGridViewTextBoxColumn
            // 
            this.m2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m2DataGridViewTextBoxColumn.DataPropertyName = "M2";
            this.m2DataGridViewTextBoxColumn.HeaderText = "M2";
            this.m2DataGridViewTextBoxColumn.Name = "m2DataGridViewTextBoxColumn";
            // 
            // postNrDataGridViewTextBoxColumn
            // 
            this.postNrDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.postNrDataGridViewTextBoxColumn.DataPropertyName = "PostNr";
            this.postNrDataGridViewTextBoxColumn.HeaderText = "PostNr";
            this.postNrDataGridViewTextBoxColumn.Name = "postNrDataGridViewTextBoxColumn";
            // 
            // OprettelsesDato
            // 
            this.OprettelsesDato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OprettelsesDato.DataPropertyName = "OprettelsesDato";
            this.OprettelsesDato.HeaderText = "OprettelsesDato";
            this.OprettelsesDato.Name = "OprettelsesDato";
            // 
            // handelsDatoDataGridViewTextBoxColumn
            // 
            this.handelsDatoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.handelsDatoDataGridViewTextBoxColumn.DataPropertyName = "HandelsDato";
            this.handelsDatoDataGridViewTextBoxColumn.HeaderText = "HandelsDato";
            this.handelsDatoDataGridViewTextBoxColumn.Name = "handelsDatoDataGridViewTextBoxColumn";
            // 
            // solgteBoligBindingSource
            // 
            this.solgteBoligBindingSource.DataMember = "SolgteBolig";
            this.solgteBoligBindingSource.DataSource = this.ejendomsmæglerDataSet;
            // 
            // ejendomsmæglerDataSet
            // 
            this.ejendomsmæglerDataSet.DataSetName = "EjendomsmæglerDataSet";
            this.ejendomsmæglerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(663, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Download txt fil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Slet Ordre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 42);
            this.button2.TabIndex = 41;
            this.button2.Text = "Eksekver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "BoligID";
            // 
            // solgteBoligTableAdapter
            // 
            this.solgteBoligTableAdapter.ClearBeforeFill = true;
            // 
            // Køber_Ordre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Køber_Ordre";
            this.Text = "Køber_Ordre";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solgteBoligBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private EjendomsmæglerDataSet ejendomsmæglerDataSet;
        private System.Windows.Forms.BindingSource solgteBoligBindingSource;
        private EjendomsmæglerDataSetTableAdapters.SolgteBoligTableAdapter solgteBoligTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn boligIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn køberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sælgerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postNrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OprettelsesDato;
        private System.Windows.Forms.DataGridViewTextBoxColumn handelsDatoDataGridViewTextBoxColumn;
    }
}