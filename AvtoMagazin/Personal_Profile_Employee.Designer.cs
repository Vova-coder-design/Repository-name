namespace AvtoMagazin
{
    partial class Personal_Profile_Employee
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
            this.gbEmployee_Info = new System.Windows.Forms.GroupBox();
            this.dtpWorked_Hours = new System.Windows.Forms.DateTimePicker();
            this.lblWorked_Hours = new System.Windows.Forms.Label();
            this.lblEmployee_Enterence = new System.Windows.Forms.Label();
            this.lblEmployee_Middle_Name = new System.Windows.Forms.Label();
            this.lblEmpoyee_Name = new System.Windows.Forms.Label();
            this.lblEmployee_First_Name = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.tbConfermPassword = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lblConfermPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLohgin = new System.Windows.Forms.Label();
            this.tblltpnEmployee = new System.Windows.Forms.TableLayoutPanel();
            this.pnCancel = new System.Windows.Forms.Panel();
            this.btCancel = new System.Windows.Forms.Button();
            this.btExport = new System.Windows.Forms.Button();
            this.btPredzakaz = new System.Windows.Forms.Button();
            this.gbEmployee_Info.SuspendLayout();
            this.tblltpnEmployee.SuspendLayout();
            this.pnCancel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEmployee_Info
            // 
            this.gbEmployee_Info.Controls.Add(this.btPredzakaz);
            this.gbEmployee_Info.Controls.Add(this.tblltpnEmployee);
            this.gbEmployee_Info.Controls.Add(this.dtpWorked_Hours);
            this.gbEmployee_Info.Controls.Add(this.lblWorked_Hours);
            this.gbEmployee_Info.Controls.Add(this.lblEmployee_Enterence);
            this.gbEmployee_Info.Controls.Add(this.lblEmployee_Middle_Name);
            this.gbEmployee_Info.Controls.Add(this.lblEmpoyee_Name);
            this.gbEmployee_Info.Controls.Add(this.lblEmployee_First_Name);
            this.gbEmployee_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbEmployee_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbEmployee_Info.Location = new System.Drawing.Point(0, 0);
            this.gbEmployee_Info.Name = "gbEmployee_Info";
            this.gbEmployee_Info.Size = new System.Drawing.Size(659, 347);
            this.gbEmployee_Info.TabIndex = 2;
            this.gbEmployee_Info.TabStop = false;
            this.gbEmployee_Info.Text = "Персональные данные";
            // 
            // dtpWorked_Hours
            // 
            this.dtpWorked_Hours.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpWorked_Hours.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWorked_Hours.Location = new System.Drawing.Point(3, 122);
            this.dtpWorked_Hours.Name = "dtpWorked_Hours";
            this.dtpWorked_Hours.Size = new System.Drawing.Size(653, 26);
            this.dtpWorked_Hours.TabIndex = 5;
            // 
            // lblWorked_Hours
            // 
            this.lblWorked_Hours.AutoSize = true;
            this.lblWorked_Hours.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWorked_Hours.Location = new System.Drawing.Point(3, 102);
            this.lblWorked_Hours.Name = "lblWorked_Hours";
            this.lblWorked_Hours.Size = new System.Drawing.Size(294, 20);
            this.lblWorked_Hours.TabIndex = 4;
            this.lblWorked_Hours.Text = "Количество отработанных часов: 0 ч.";
            // 
            // lblEmployee_Enterence
            // 
            this.lblEmployee_Enterence.AutoSize = true;
            this.lblEmployee_Enterence.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEmployee_Enterence.Location = new System.Drawing.Point(3, 82);
            this.lblEmployee_Enterence.Name = "lblEmployee_Enterence";
            this.lblEmployee_Enterence.Size = new System.Drawing.Size(132, 20);
            this.lblEmployee_Enterence.TabIndex = 3;
            this.lblEmployee_Enterence.Text = "Дата принятия: ";
            // 
            // lblEmployee_Middle_Name
            // 
            this.lblEmployee_Middle_Name.AutoSize = true;
            this.lblEmployee_Middle_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEmployee_Middle_Name.Location = new System.Drawing.Point(3, 62);
            this.lblEmployee_Middle_Name.Name = "lblEmployee_Middle_Name";
            this.lblEmployee_Middle_Name.Size = new System.Drawing.Size(91, 20);
            this.lblEmployee_Middle_Name.TabIndex = 2;
            this.lblEmployee_Middle_Name.Text = "Отчество: ";
            // 
            // lblEmpoyee_Name
            // 
            this.lblEmpoyee_Name.AutoSize = true;
            this.lblEmpoyee_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEmpoyee_Name.Location = new System.Drawing.Point(3, 42);
            this.lblEmpoyee_Name.Name = "lblEmpoyee_Name";
            this.lblEmpoyee_Name.Size = new System.Drawing.Size(48, 20);
            this.lblEmpoyee_Name.TabIndex = 1;
            this.lblEmpoyee_Name.Text = "Имя: ";
            // 
            // lblEmployee_First_Name
            // 
            this.lblEmployee_First_Name.AutoSize = true;
            this.lblEmployee_First_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEmployee_First_Name.Location = new System.Drawing.Point(3, 22);
            this.lblEmployee_First_Name.Name = "lblEmployee_First_Name";
            this.lblEmployee_First_Name.Size = new System.Drawing.Size(89, 20);
            this.lblEmployee_First_Name.TabIndex = 0;
            this.lblEmployee_First_Name.Text = "Фамилия: ";
            // 
            // btSave
            // 
            this.btSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSave.Location = new System.Drawing.Point(3, 150);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(320, 43);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // tbConfermPassword
            // 
            this.tbConfermPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbConfermPassword.Location = new System.Drawing.Point(329, 101);
            this.tbConfermPassword.Name = "tbConfermPassword";
            this.tbConfermPassword.PasswordChar = '*';
            this.tbConfermPassword.Size = new System.Drawing.Size(321, 26);
            this.tbConfermPassword.TabIndex = 5;
            this.tbConfermPassword.Enter += new System.EventHandler(this.back_Color);
            // 
            // tbPassword
            // 
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPassword.Location = new System.Drawing.Point(329, 52);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(321, 26);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.Enter += new System.EventHandler(this.back_Color);
            // 
            // tbLogin
            // 
            this.tbLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbLogin.Location = new System.Drawing.Point(329, 3);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(321, 26);
            this.tbLogin.TabIndex = 3;
            this.tbLogin.Enter += new System.EventHandler(this.back_Color);
            // 
            // lblConfermPassword
            // 
            this.lblConfermPassword.AutoSize = true;
            this.lblConfermPassword.Location = new System.Drawing.Point(3, 98);
            this.lblConfermPassword.Name = "lblConfermPassword";
            this.lblConfermPassword.Size = new System.Drawing.Size(178, 20);
            this.lblConfermPassword.TabIndex = 2;
            this.lblConfermPassword.Text = "Подтвердить пароль:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(3, 49);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(71, 20);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Пароль:";
            // 
            // lblLohgin
            // 
            this.lblLohgin.AutoSize = true;
            this.lblLohgin.Location = new System.Drawing.Point(3, 0);
            this.lblLohgin.Name = "lblLohgin";
            this.lblLohgin.Size = new System.Drawing.Size(59, 20);
            this.lblLohgin.TabIndex = 0;
            this.lblLohgin.Text = "Логин:";
            // 
            // tblltpnEmployee
            // 
            this.tblltpnEmployee.ColumnCount = 2;
            this.tblltpnEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblltpnEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblltpnEmployee.Controls.Add(this.pnCancel, 0, 3);
            this.tblltpnEmployee.Controls.Add(this.lblLohgin, 0, 0);
            this.tblltpnEmployee.Controls.Add(this.lblPassword, 0, 1);
            this.tblltpnEmployee.Controls.Add(this.lblConfermPassword, 0, 2);
            this.tblltpnEmployee.Controls.Add(this.tbLogin, 1, 0);
            this.tblltpnEmployee.Controls.Add(this.tbPassword, 1, 1);
            this.tblltpnEmployee.Controls.Add(this.tbConfermPassword, 1, 2);
            this.tblltpnEmployee.Controls.Add(this.btSave, 0, 3);
            this.tblltpnEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblltpnEmployee.Location = new System.Drawing.Point(3, 148);
            this.tblltpnEmployee.Name = "tblltpnEmployee";
            this.tblltpnEmployee.RowCount = 4;
            this.tblltpnEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblltpnEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblltpnEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblltpnEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblltpnEmployee.Size = new System.Drawing.Size(653, 196);
            this.tblltpnEmployee.TabIndex = 6;
            // 
            // pnCancel
            // 
            this.pnCancel.Controls.Add(this.btExport);
            this.pnCancel.Controls.Add(this.btCancel);
            this.pnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCancel.Location = new System.Drawing.Point(329, 150);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Size = new System.Drawing.Size(321, 43);
            this.pnCancel.TabIndex = 7;
            // 
            // btCancel
            // 
            this.btCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCancel.Location = new System.Drawing.Point(162, 0);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(159, 43);
            this.btCancel.TabIndex = 0;
            this.btCancel.Text = "Закрыть";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btExport
            // 
            this.btExport.Dock = System.Windows.Forms.DockStyle.Right;
            this.btExport.Location = new System.Drawing.Point(3, 0);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(159, 43);
            this.btExport.TabIndex = 1;
            this.btExport.Text = "Экспорт";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // btPredzakaz
            // 
            this.btPredzakaz.Location = new System.Drawing.Point(542, 0);
            this.btPredzakaz.Name = "btPredzakaz";
            this.btPredzakaz.Size = new System.Drawing.Size(114, 44);
            this.btPredzakaz.TabIndex = 7;
            this.btPredzakaz.Text = "Предзаказы";
            this.btPredzakaz.UseVisualStyleBackColor = true;
            this.btPredzakaz.Click += new System.EventHandler(this.btPredzakaz_Click);
            // 
            // Personal_Profile_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 347);
            this.Controls.Add(this.gbEmployee_Info);
            this.Name = "Personal_Profile_Employee";
            this.Text = "Personal_Profile_Employee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Personal_Profile_Employee_FormClosing);
            this.Load += new System.EventHandler(this.Personal_Profile_Employee_Load);
            this.gbEmployee_Info.ResumeLayout(false);
            this.gbEmployee_Info.PerformLayout();
            this.tblltpnEmployee.ResumeLayout(false);
            this.tblltpnEmployee.PerformLayout();
            this.pnCancel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEmployee_Info;
        private System.Windows.Forms.DateTimePicker dtpWorked_Hours;
        private System.Windows.Forms.Label lblWorked_Hours;
        private System.Windows.Forms.Label lblEmployee_Enterence;
        private System.Windows.Forms.Label lblEmployee_Middle_Name;
        private System.Windows.Forms.Label lblEmpoyee_Name;
        private System.Windows.Forms.Label lblEmployee_First_Name;
        private System.Windows.Forms.TableLayoutPanel tblltpnEmployee;
        private System.Windows.Forms.Label lblLohgin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfermPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbConfermPassword;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Panel pnCancel;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btPredzakaz;
    }
}