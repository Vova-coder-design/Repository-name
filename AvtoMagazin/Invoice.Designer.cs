namespace AvtoMagazin
{
    partial class Invoice
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
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.btExport = new System.Windows.Forms.Button();
            this.btCansel = new System.Windows.Forms.Button();
            this.avtomagazin_Data_BaseDataSet1 = new AvtoMagazin.Avtomagazin_Data_BaseDataSet1();
            this.nackladnayaPredstavlenieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nackladnaya_PredstavlenieTableAdapter = new AvtoMagazin.Avtomagazin_Data_BaseDataSet1TableAdapters.Nackladnaya_PredstavlenieTableAdapter();
            this.номерНакладнойDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поставщикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ответственныйСотрудникDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.товарDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtomagazin_Data_BaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nackladnayaPredstavlenieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AllowUserToAddRows = false;
            this.dgvInvoice.AutoGenerateColumns = false;
            this.dgvInvoice.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерНакладнойDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.поставщикDataGridViewTextBoxColumn,
            this.ответственныйСотрудникDataGridViewTextBoxColumn,
            this.товарDataGridViewTextBoxColumn,
            this.суммаЗаказаDataGridViewTextBoxColumn});
            this.dgvInvoice.DataSource = this.nackladnayaPredstavlenieBindingSource;
            this.dgvInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvInvoice.Location = new System.Drawing.Point(0, 0);
            this.dgvInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.RowHeadersWidth = 51;
            this.dgvInvoice.RowTemplate.Height = 24;
            this.dgvInvoice.Size = new System.Drawing.Size(684, 261);
            this.dgvInvoice.TabIndex = 2;
            // 
            // btExport
            // 
            this.btExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btExport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btExport.Location = new System.Drawing.Point(0, 261);
            this.btExport.Margin = new System.Windows.Forms.Padding(2);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(222, 121);
            this.btExport.TabIndex = 3;
            this.btExport.Text = "Сформировать документ";
            this.btExport.UseVisualStyleBackColor = false;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // btCansel
            // 
            this.btCansel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btCansel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCansel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCansel.Location = new System.Drawing.Point(449, 261);
            this.btCansel.Margin = new System.Windows.Forms.Padding(2);
            this.btCansel.Name = "btCansel";
            this.btCansel.Size = new System.Drawing.Size(235, 121);
            this.btCansel.TabIndex = 4;
            this.btCansel.Text = "Назад";
            this.btCansel.UseVisualStyleBackColor = false;
            this.btCansel.Click += new System.EventHandler(this.btCansel_Click);
            // 
            // avtomagazin_Data_BaseDataSet1
            // 
            this.avtomagazin_Data_BaseDataSet1.DataSetName = "Avtomagazin_Data_BaseDataSet1";
            this.avtomagazin_Data_BaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nackladnayaPredstavlenieBindingSource
            // 
            this.nackladnayaPredstavlenieBindingSource.DataMember = "Nackladnaya_Predstavlenie";
            this.nackladnayaPredstavlenieBindingSource.DataSource = this.avtomagazin_Data_BaseDataSet1;
            // 
            // nackladnaya_PredstavlenieTableAdapter
            // 
            this.nackladnaya_PredstavlenieTableAdapter.ClearBeforeFill = true;
            // 
            // номерНакладнойDataGridViewTextBoxColumn
            // 
            this.номерНакладнойDataGridViewTextBoxColumn.DataPropertyName = "Номер накладной";
            this.номерНакладнойDataGridViewTextBoxColumn.HeaderText = "Номер накладной";
            this.номерНакладнойDataGridViewTextBoxColumn.Name = "номерНакладнойDataGridViewTextBoxColumn";
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // поставщикDataGridViewTextBoxColumn
            // 
            this.поставщикDataGridViewTextBoxColumn.DataPropertyName = "Поставщик";
            this.поставщикDataGridViewTextBoxColumn.HeaderText = "Поставщик";
            this.поставщикDataGridViewTextBoxColumn.Name = "поставщикDataGridViewTextBoxColumn";
            // 
            // ответственныйСотрудникDataGridViewTextBoxColumn
            // 
            this.ответственныйСотрудникDataGridViewTextBoxColumn.DataPropertyName = "Ответственный сотрудник";
            this.ответственныйСотрудникDataGridViewTextBoxColumn.HeaderText = "Ответственный сотрудник";
            this.ответственныйСотрудникDataGridViewTextBoxColumn.Name = "ответственныйСотрудникDataGridViewTextBoxColumn";
            this.ответственныйСотрудникDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // товарDataGridViewTextBoxColumn
            // 
            this.товарDataGridViewTextBoxColumn.DataPropertyName = "Товар";
            this.товарDataGridViewTextBoxColumn.HeaderText = "Товар";
            this.товарDataGridViewTextBoxColumn.Name = "товарDataGridViewTextBoxColumn";
            // 
            // суммаЗаказаDataGridViewTextBoxColumn
            // 
            this.суммаЗаказаDataGridViewTextBoxColumn.DataPropertyName = "Сумма заказа";
            this.суммаЗаказаDataGridViewTextBoxColumn.HeaderText = "Сумма заказа";
            this.суммаЗаказаDataGridViewTextBoxColumn.Name = "суммаЗаказаDataGridViewTextBoxColumn";
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 382);
            this.Controls.Add(this.btCansel);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.dgvInvoice);
            this.Name = "Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtomagazin_Data_BaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nackladnayaPredstavlenieBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.Button btCansel;
        private Avtomagazin_Data_BaseDataSet1 avtomagazin_Data_BaseDataSet1;
        private System.Windows.Forms.BindingSource nackladnayaPredstavlenieBindingSource;
        private Avtomagazin_Data_BaseDataSet1TableAdapters.Nackladnaya_PredstavlenieTableAdapter nackladnaya_PredstavlenieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерНакладнойDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn поставщикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ответственныйСотрудникDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn товарDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаЗаказаDataGridViewTextBoxColumn;
    }
}