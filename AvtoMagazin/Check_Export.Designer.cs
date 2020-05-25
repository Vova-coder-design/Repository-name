namespace AvtoMagazin
{
    partial class Check_Export
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
            this.gridwiew = new System.Windows.Forms.DataGridView();
            this.btExport = new System.Windows.Forms.Button();
            this.btCansel = new System.Windows.Forms.Button();
            this.avtomagazin_Data_BaseDataSet = new AvtoMagazin.Avtomagazin_Data_BaseDataSet();
            this.checkPredstavlenieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.check_PredstavlenieTableAdapter = new AvtoMagazin.Avtomagazin_Data_BaseDataSetTableAdapters.Check_PredstavlenieTableAdapter();
            this.фИОКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерЧекаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridwiew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtomagazin_Data_BaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPredstavlenieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridwiew
            // 
            this.gridwiew.AllowUserToAddRows = false;
            this.gridwiew.AutoGenerateColumns = false;
            this.gridwiew.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridwiew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridwiew.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОКлиентаDataGridViewTextBoxColumn,
            this.названиеТовараDataGridViewTextBoxColumn,
            this.номерЧекаDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn});
            this.gridwiew.DataSource = this.checkPredstavlenieBindingSource;
            this.gridwiew.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridwiew.Location = new System.Drawing.Point(0, 0);
            this.gridwiew.Margin = new System.Windows.Forms.Padding(2);
            this.gridwiew.Name = "gridwiew";
            this.gridwiew.RowHeadersWidth = 51;
            this.gridwiew.RowTemplate.Height = 24;
            this.gridwiew.Size = new System.Drawing.Size(637, 261);
            this.gridwiew.TabIndex = 1;
            // 
            // btExport
            // 
            this.btExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btExport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btExport.Location = new System.Drawing.Point(0, 261);
            this.btExport.Margin = new System.Windows.Forms.Padding(2);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(222, 119);
            this.btExport.TabIndex = 2;
            this.btExport.Text = "Сформировать документ";
            this.btExport.UseVisualStyleBackColor = false;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // btCansel
            // 
            this.btCansel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btCansel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCansel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCansel.Location = new System.Drawing.Point(402, 261);
            this.btCansel.Margin = new System.Windows.Forms.Padding(2);
            this.btCansel.Name = "btCansel";
            this.btCansel.Size = new System.Drawing.Size(235, 119);
            this.btCansel.TabIndex = 3;
            this.btCansel.Text = "Назад";
            this.btCansel.UseVisualStyleBackColor = false;
            this.btCansel.Click += new System.EventHandler(this.btCansel_Click);
            // 
            // avtomagazin_Data_BaseDataSet
            // 
            this.avtomagazin_Data_BaseDataSet.DataSetName = "Avtomagazin_Data_BaseDataSet";
            this.avtomagazin_Data_BaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkPredstavlenieBindingSource
            // 
            this.checkPredstavlenieBindingSource.DataMember = "Check_Predstavlenie";
            this.checkPredstavlenieBindingSource.DataSource = this.avtomagazin_Data_BaseDataSet;
            // 
            // check_PredstavlenieTableAdapter
            // 
            this.check_PredstavlenieTableAdapter.ClearBeforeFill = true;
            // 
            // фИОКлиентаDataGridViewTextBoxColumn
            // 
            this.фИОКлиентаDataGridViewTextBoxColumn.DataPropertyName = "ФИО клиента";
            this.фИОКлиентаDataGridViewTextBoxColumn.HeaderText = "ФИО клиента";
            this.фИОКлиентаDataGridViewTextBoxColumn.Name = "фИОКлиентаDataGridViewTextBoxColumn";
            this.фИОКлиентаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеТовараDataGridViewTextBoxColumn
            // 
            this.названиеТовараDataGridViewTextBoxColumn.DataPropertyName = "Название товара";
            this.названиеТовараDataGridViewTextBoxColumn.HeaderText = "Название товара";
            this.названиеТовараDataGridViewTextBoxColumn.Name = "названиеТовараDataGridViewTextBoxColumn";
            // 
            // номерЧекаDataGridViewTextBoxColumn
            // 
            this.номерЧекаDataGridViewTextBoxColumn.DataPropertyName = "Номер чека";
            this.номерЧекаDataGridViewTextBoxColumn.HeaderText = "Номер чека";
            this.номерЧекаDataGridViewTextBoxColumn.Name = "номерЧекаDataGridViewTextBoxColumn";
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // Check_Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 380);
            this.Controls.Add(this.btCansel);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.gridwiew);
            this.Name = "Check_Export";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Экспорт чеков";
            this.Load += new System.EventHandler(this.Check_Export_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridwiew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtomagazin_Data_BaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPredstavlenieBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridwiew;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.Button btCansel;
        private Avtomagazin_Data_BaseDataSet avtomagazin_Data_BaseDataSet;
        private System.Windows.Forms.BindingSource checkPredstavlenieBindingSource;
        private Avtomagazin_Data_BaseDataSetTableAdapters.Check_PredstavlenieTableAdapter check_PredstavlenieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеТовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерЧекаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
    }
}