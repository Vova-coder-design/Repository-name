namespace AvtoMagazin
{
    partial class Tovar_Klient_Check
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbFindValue = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbKlient = new System.Windows.Forms.ComboBox();
            this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avtomagazin_Data_BaseDataSet3 = new AvtoMagazin.Avtomagazin_Data_BaseDataSet3();
            this.cbTovar = new System.Windows.Forms.ComboBox();
            this.tovarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avtomagazin_Data_BaseDataSet4 = new AvtoMagazin.Avtomagazin_Data_BaseDataSet4();
            this.cbCheck = new System.Windows.Forms.ComboBox();
            this.checkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avtomagazin_Data_BaseDataSet5 = new AvtoMagazin.Avtomagazin_Data_BaseDataSet5();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.klientTableAdapter = new AvtoMagazin.Avtomagazin_Data_BaseDataSet3TableAdapters.KlientTableAdapter();
            this.tovarTableAdapter = new AvtoMagazin.Avtomagazin_Data_BaseDataSet4TableAdapters.TovarTableAdapter();
            this.checkTableAdapter = new AvtoMagazin.Avtomagazin_Data_BaseDataSet5TableAdapters.CheckTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtomagazin_Data_BaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtomagazin_Data_BaseDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtomagazin_Data_BaseDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView3.Location = new System.Drawing.Point(13, 14);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(680, 311);
            this.dataGridView3.TabIndex = 13;
            this.dataGridView3.CurrentCellChanged += new System.EventHandler(this.dataGridView3_CurrentCellChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(697, 121);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(289, 46);
            this.button3.TabIndex = 22;
            this.button3.Text = "Отмена";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(842, 75);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 46);
            this.button2.TabIndex = 21;
            this.button2.Text = "Фильтр";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(697, 75);
            this.btSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(147, 46);
            this.btSearch.TabIndex = 20;
            this.btSearch.Text = "Поиск";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(719, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(240, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Значение поиска\\фильтрации";
            // 
            // tbFindValue
            // 
            this.tbFindValue.Location = new System.Drawing.Point(697, 39);
            this.tbFindValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFindValue.Name = "tbFindValue";
            this.tbFindValue.Size = new System.Drawing.Size(289, 26);
            this.tbFindValue.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 335);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 46);
            this.button1.TabIndex = 23;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbKlient
            // 
            this.cbKlient.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.klientBindingSource, "First_Name_Klient", true));
            this.cbKlient.DataSource = this.klientBindingSource;
            this.cbKlient.DisplayMember = "First_Name_Klient";
            this.cbKlient.FormattingEnabled = true;
            this.cbKlient.Location = new System.Drawing.Point(697, 205);
            this.cbKlient.Name = "cbKlient";
            this.cbKlient.Size = new System.Drawing.Size(289, 28);
            this.cbKlient.TabIndex = 26;
            this.cbKlient.ValueMember = "First_Name_Klient";
            // 
            // klientBindingSource
            // 
            this.klientBindingSource.DataMember = "Klient";
            this.klientBindingSource.DataSource = this.avtomagazin_Data_BaseDataSet3;
            // 
            // avtomagazin_Data_BaseDataSet3
            // 
            this.avtomagazin_Data_BaseDataSet3.DataSetName = "Avtomagazin_Data_BaseDataSet3";
            this.avtomagazin_Data_BaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbTovar
            // 
            this.cbTovar.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tovarBindingSource, "Name_of_Tovar", true));
            this.cbTovar.DataSource = this.tovarBindingSource;
            this.cbTovar.DisplayMember = "Name_of_Tovar";
            this.cbTovar.FormattingEnabled = true;
            this.cbTovar.Location = new System.Drawing.Point(697, 273);
            this.cbTovar.Name = "cbTovar";
            this.cbTovar.Size = new System.Drawing.Size(289, 28);
            this.cbTovar.TabIndex = 27;
            this.cbTovar.ValueMember = "Name_of_Tovar";
            // 
            // tovarBindingSource
            // 
            this.tovarBindingSource.DataMember = "Tovar";
            this.tovarBindingSource.DataSource = this.avtomagazin_Data_BaseDataSet4;
            // 
            // avtomagazin_Data_BaseDataSet4
            // 
            this.avtomagazin_Data_BaseDataSet4.DataSetName = "Avtomagazin_Data_BaseDataSet4";
            this.avtomagazin_Data_BaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbCheck
            // 
            this.cbCheck.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.checkBindingSource, "Nomer_Check", true));
            this.cbCheck.DataSource = this.checkBindingSource;
            this.cbCheck.DisplayMember = "Nomer_Check";
            this.cbCheck.FormattingEnabled = true;
            this.cbCheck.Location = new System.Drawing.Point(697, 335);
            this.cbCheck.Name = "cbCheck";
            this.cbCheck.Size = new System.Drawing.Size(289, 28);
            this.cbCheck.TabIndex = 28;
            this.cbCheck.ValueMember = "Nomer_Check";
            // 
            // checkBindingSource
            // 
            this.checkBindingSource.DataMember = "Check";
            this.checkBindingSource.DataSource = this.avtomagazin_Data_BaseDataSet5;
            // 
            // avtomagazin_Data_BaseDataSet5
            // 
            this.avtomagazin_Data_BaseDataSet5.DataSetName = "Avtomagazin_Data_BaseDataSet5";
            this.avtomagazin_Data_BaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(693, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Клиент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(693, 250);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Товар";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(693, 312);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Чек";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(13, 335);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(147, 46);
            this.button6.TabIndex = 32;
            this.button6.Text = "Товары";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(13, 382);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(147, 46);
            this.button7.TabIndex = 33;
            this.button7.Text = "Клиенты";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(158, 335);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(69, 93);
            this.button8.TabIndex = 34;
            this.button8.Text = "Чеки";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // klientTableAdapter
            // 
            this.klientTableAdapter.ClearBeforeFill = true;
            // 
            // tovarTableAdapter
            // 
            this.tovarTableAdapter.ClearBeforeFill = true;
            // 
            // checkTableAdapter
            // 
            this.checkTableAdapter.ClearBeforeFill = true;
            // 
            // Tovar_Klient_Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 433);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCheck);
            this.Controls.Add(this.cbTovar);
            this.Controls.Add(this.cbKlient);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbFindValue);
            this.Controls.Add(this.dataGridView3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Tovar_Klient_Check";
            this.Text = "Tovar_Klient_Check";
            this.Load += new System.EventHandler(this.Tovar_Klient_Check_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtomagazin_Data_BaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtomagazin_Data_BaseDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtomagazin_Data_BaseDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbFindValue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbKlient;
        private System.Windows.Forms.ComboBox cbTovar;
        private System.Windows.Forms.ComboBox cbCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private Avtomagazin_Data_BaseDataSet3 avtomagazin_Data_BaseDataSet3;
        private System.Windows.Forms.BindingSource klientBindingSource;
        private Avtomagazin_Data_BaseDataSet3TableAdapters.KlientTableAdapter klientTableAdapter;
        private Avtomagazin_Data_BaseDataSet4 avtomagazin_Data_BaseDataSet4;
        private System.Windows.Forms.BindingSource tovarBindingSource;
        private Avtomagazin_Data_BaseDataSet4TableAdapters.TovarTableAdapter tovarTableAdapter;
        private Avtomagazin_Data_BaseDataSet5 avtomagazin_Data_BaseDataSet5;
        private System.Windows.Forms.BindingSource checkBindingSource;
        private Avtomagazin_Data_BaseDataSet5TableAdapters.CheckTableAdapter checkTableAdapter;
    }
}