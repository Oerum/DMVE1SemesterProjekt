
namespace WindowsFormsApp1.Forms.Ejendomsmægler
{
    partial class Ejendomsmægler_BoligUdtrækPris
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
            this.ejendomsmæglerDataSet = new WindowsFormsApp1.EjendomsmæglerDataSet();
            this.solgteBoligTableAdapter = new WindowsFormsApp1.EjendomsmæglerDataSetTableAdapters.SolgteBoligTableAdapter();
            this.solgteBoligBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.solgteBoligBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solgteBoligBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solgteBoligBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(621, 289);
            this.dataGridView1.TabIndex = 48;
            // 
            // solgteBoligBindingSource
            // 
            this.solgteBoligBindingSource.DataMember = "SolgteBolig";
            this.solgteBoligBindingSource.DataSource = this.ejendomsmæglerDataSet;
            // 
            // Ejendomsmægler_BoligUdtrækPris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 309);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Ejendomsmægler_BoligUdtrækPris";
            this.Text = "Ejendomsmægler_BoligUdtrækPris";
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solgteBoligBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solgteBoligBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private EjendomsmæglerDataSet ejendomsmæglerDataSet;
        private EjendomsmæglerDataSetTableAdapters.SolgteBoligTableAdapter solgteBoligTableAdapter;
        private System.Windows.Forms.BindingSource solgteBoligBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource solgteBoligBindingSource;
    }
}