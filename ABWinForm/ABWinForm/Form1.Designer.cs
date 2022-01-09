
namespace ABWinForm
{
    partial class Form1
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
            this.szepsegszalonDataSet = new ABWinForm.szepsegszalonDataSet();
            this.szepsegszalonDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alkalmazottakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alkalmazottakTableAdapter = new ABWinForm.szepsegszalonDataSetTableAdapters.alkalmazottakTableAdapter();
            this.kezelesekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kezelesekTableAdapter = new ABWinForm.szepsegszalonDataSetTableAdapters.kezelesekTableAdapter();
            this.szakmakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.szakmakTableAdapter = new ABWinForm.szepsegszalonDataSetTableAdapters.szakmakTableAdapter();
            this.vendegekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendegekTableAdapter = new ABWinForm.szepsegszalonDataSetTableAdapters.vendegekTableAdapter();
            this.export = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.kezelesIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alkalmazottIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendegIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szepsegszalonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szepsegszalonDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alkalmazottakBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kezelesekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szakmakBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendegekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kezelesIdDataGridViewTextBoxColumn,
            this.alkalmazottIdDataGridViewTextBoxColumn,
            this.vendegIDDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.arDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kezelesekBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(608, 383);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // szepsegszalonDataSet
            // 
            this.szepsegszalonDataSet.DataSetName = "szepsegszalonDataSet";
            this.szepsegszalonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // szepsegszalonDataSetBindingSource
            // 
            this.szepsegszalonDataSetBindingSource.DataSource = this.szepsegszalonDataSet;
            this.szepsegszalonDataSetBindingSource.Position = 0;
            // 
            // alkalmazottakBindingSource
            // 
            this.alkalmazottakBindingSource.DataMember = "alkalmazottak";
            this.alkalmazottakBindingSource.DataSource = this.szepsegszalonDataSetBindingSource;
            // 
            // alkalmazottakTableAdapter
            // 
            this.alkalmazottakTableAdapter.ClearBeforeFill = true;
            // 
            // kezelesekBindingSource
            // 
            this.kezelesekBindingSource.DataMember = "kezelesek";
            this.kezelesekBindingSource.DataSource = this.szepsegszalonDataSetBindingSource;
            // 
            // kezelesekTableAdapter
            // 
            this.kezelesekTableAdapter.ClearBeforeFill = true;
            // 
            // szakmakBindingSource
            // 
            this.szakmakBindingSource.DataMember = "szakmak";
            this.szakmakBindingSource.DataSource = this.szepsegszalonDataSetBindingSource;
            // 
            // szakmakTableAdapter
            // 
            this.szakmakTableAdapter.ClearBeforeFill = true;
            // 
            // vendegekBindingSource
            // 
            this.vendegekBindingSource.DataMember = "vendegek";
            this.vendegekBindingSource.DataSource = this.szepsegszalonDataSetBindingSource;
            // 
            // vendegekTableAdapter
            // 
            this.vendegekTableAdapter.ClearBeforeFill = true;
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(667, 309);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(97, 37);
            this.export.TabIndex = 1;
            this.export.Text = "3. feladat Export";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // kezelesIdDataGridViewTextBoxColumn
            // 
            this.kezelesIdDataGridViewTextBoxColumn.DataPropertyName = "kezelesId";
            this.kezelesIdDataGridViewTextBoxColumn.HeaderText = "kezelesId";
            this.kezelesIdDataGridViewTextBoxColumn.Name = "kezelesIdDataGridViewTextBoxColumn";
            this.kezelesIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alkalmazottIdDataGridViewTextBoxColumn
            // 
            this.alkalmazottIdDataGridViewTextBoxColumn.DataPropertyName = "alkalmazottId";
            this.alkalmazottIdDataGridViewTextBoxColumn.HeaderText = "alkalmazottId";
            this.alkalmazottIdDataGridViewTextBoxColumn.Name = "alkalmazottIdDataGridViewTextBoxColumn";
            // 
            // vendegIDDataGridViewTextBoxColumn
            // 
            this.vendegIDDataGridViewTextBoxColumn.DataPropertyName = "vendegID";
            this.vendegIDDataGridViewTextBoxColumn.HeaderText = "vendegID";
            this.vendegIDDataGridViewTextBoxColumn.Name = "vendegIDDataGridViewTextBoxColumn";
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // arDataGridViewTextBoxColumn
            // 
            this.arDataGridViewTextBoxColumn.DataPropertyName = "ar";
            this.arDataGridViewTextBoxColumn.HeaderText = "ar";
            this.arDataGridViewTextBoxColumn.Name = "arDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.export);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szepsegszalonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szepsegszalonDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alkalmazottakBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kezelesekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szakmakBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendegekBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource szepsegszalonDataSetBindingSource;
        private szepsegszalonDataSet szepsegszalonDataSet;
        private System.Windows.Forms.BindingSource alkalmazottakBindingSource;
        private szepsegszalonDataSetTableAdapters.alkalmazottakTableAdapter alkalmazottakTableAdapter;
        private System.Windows.Forms.BindingSource kezelesekBindingSource;
        private szepsegszalonDataSetTableAdapters.kezelesekTableAdapter kezelesekTableAdapter;
        private System.Windows.Forms.BindingSource szakmakBindingSource;
        private szepsegszalonDataSetTableAdapters.szakmakTableAdapter szakmakTableAdapter;
        private System.Windows.Forms.BindingSource vendegekBindingSource;
        private szepsegszalonDataSetTableAdapters.vendegekTableAdapter vendegekTableAdapter;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kezelesIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alkalmazottIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendegIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arDataGridViewTextBoxColumn;
    }
}

