﻿namespace AvtoMagazin
{
    partial class Check_Form
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
            this.tbDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbFindValue = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tbNomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(678, 279);
            this.tbDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(289, 26);
            this.tbDate.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(674, 254);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "Дата чека";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(678, 349);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(289, 46);
            this.button4.TabIndex = 52;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(674, 125);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(289, 46);
            this.button3.TabIndex = 50;
            this.button3.Text = "Отмена";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(819, 79);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 46);
            this.button2.TabIndex = 49;
            this.button2.Text = "Фильтр";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(674, 79);
            this.btSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(147, 46);
            this.btSearch.TabIndex = 48;
            this.btSearch.Text = "Поиск";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(696, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(240, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "Значение поиска\\фильтрации";
            // 
            // tbFindValue
            // 
            this.tbFindValue.Location = new System.Drawing.Point(674, 43);
            this.tbFindValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFindValue.Name = "tbFindValue";
            this.tbFindValue.Size = new System.Drawing.Size(289, 26);
            this.tbFindValue.TabIndex = 46;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView3.Location = new System.Drawing.Point(13, 18);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(641, 424);
            this.dataGridView3.TabIndex = 45;
            this.dataGridView3.CurrentCellChanged += new System.EventHandler(this.dataGridView3_CurrentCellChanged);
            // 
            // tbNomer
            // 
            this.tbNomer.Location = new System.Drawing.Point(678, 227);
            this.tbNomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNomer.Name = "tbNomer";
            this.tbNomer.Size = new System.Drawing.Size(289, 26);
            this.tbNomer.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(674, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "Номер чека";
            // 
            // Check_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 461);
            this.Controls.Add(this.tbNomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbFindValue);
            this.Controls.Add(this.dataGridView3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Check_Form";
            this.Text = "Check_Form";
            this.Load += new System.EventHandler(this.Check_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbFindValue;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox tbNomer;
        private System.Windows.Forms.Label label2;
    }
}