
namespace WindowsFormsApp1.Forms.Ejendomsmægler
{
    partial class Ejendomsmægler_BoligUdtræk
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
            this.solgteBoligBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ejendomsmæglerDataSet = new WindowsFormsApp1.EjendomsmæglerDataSet();
            this.solgteBoligTableAdapter = new WindowsFormsApp1.EjendomsmæglerDataSetTableAdapters.SolgteBoligTableAdapter();
            this.solgteBoligBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.solgteBoligBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solgteBoligBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // solgteBoligTableAdapter
            // 
            this.solgteBoligTableAdapter.ClearBeforeFill = true;
            // 
            // solgteBoligBindingSource1
            // 
            this.solgteBoligBindingSource1.DataMember = "SolgteBolig";
            this.solgteBoligBindingSource1.DataSource = this.ejendomsmæglerDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(1242, 568);
            this.dataGridView1.TabIndex = 46;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 603);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1240, 44);
            this.button1.TabIndex = 47;
            this.button1.Text = "Filtrere efter pris";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ejendomsmægler_BoligUdtræk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 662);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Ejendomsmægler_BoligUdtræk";
            this.Text = "Ejendomsmægler_BoligUdtræk";
            ((System.ComponentModel.ISupportInitialize)(this.solgteBoligBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solgteBoligBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource solgteBoligBindingSource;
        private EjendomsmæglerDataSet ejendomsmæglerDataSet;
        private EjendomsmæglerDataSetTableAdapters.SolgteBoligTableAdapter solgteBoligTableAdapter;
        private System.Windows.Forms.BindingSource solgteBoligBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}