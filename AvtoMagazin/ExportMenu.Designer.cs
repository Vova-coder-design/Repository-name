namespace AvtoMagazin
{
    partial class ExportMenu
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
            this.btCheck_Export_Link = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btReservation_Link = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCheck_Export_Link
            // 
            this.btCheck_Export_Link.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btCheck_Export_Link.Dock = System.Windows.Forms.DockStyle.Left;
            this.btCheck_Export_Link.Location = new System.Drawing.Point(0, 0);
            this.btCheck_Export_Link.Name = "btCheck_Export_Link";
            this.btCheck_Export_Link.Size = new System.Drawing.Size(159, 121);
            this.btCheck_Export_Link.TabIndex = 1;
            this.btCheck_Export_Link.Text = "Вывод списка чеков";
            this.btCheck_Export_Link.UseVisualStyleBackColor = false;
            this.btCheck_Export_Link.Click += new System.EventHandler(this.btCheck_Export_Link_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.Location = new System.Drawing.Point(384, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 121);
            this.button3.TabIndex = 2;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btReservation_Link
            // 
            this.btReservation_Link.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btReservation_Link.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btReservation_Link.Location = new System.Drawing.Point(159, 0);
            this.btReservation_Link.Margin = new System.Windows.Forms.Padding(2);
            this.btReservation_Link.Name = "btReservation_Link";
            this.btReservation_Link.Size = new System.Drawing.Size(225, 121);
            this.btReservation_Link.TabIndex = 3;
            this.btReservation_Link.Text = "Экспорт накладных";
            this.btReservation_Link.UseVisualStyleBackColor = false;
            this.btReservation_Link.Click += new System.EventHandler(this.btReservation_Link_Click);
            // 
            // ExportMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 121);
            this.Controls.Add(this.btReservation_Link);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btCheck_Export_Link);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ExportMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExportMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCheck_Export_Link;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btReservation_Link;
    }
}