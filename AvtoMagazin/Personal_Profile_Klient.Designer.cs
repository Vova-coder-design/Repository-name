namespace AvtoMagazin
{
    partial class Personal_Profile_Klient
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
            this.gbKlient_Personal = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbctrlKlient = new System.Windows.Forms.TabControl();
            this.tbpgKlientProfile = new System.Windows.Forms.TabPage();
            this.tblltpnKLinet_Information = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFirst_Name = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbMiddle_Name = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbConfermPassword = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbpgBusinessProcess1 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbFindValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btOtpravit = new System.Windows.Forms.Button();
            this.tbtovar = new System.Windows.Forms.TextBox();
            this.lblKlient_Card_Number = new System.Windows.Forms.Label();
            this.lblKlinet_Middlename = new System.Windows.Forms.Label();
            this.lblKlinet_Name = new System.Windows.Forms.Label();
            this.lblKlinet_Surname = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.gbKlient_Personal.SuspendLayout();
            this.tbctrlKlient.SuspendLayout();
            this.tbpgKlientProfile.SuspendLayout();
            this.tblltpnKLinet_Information.SuspendLayout();
            this.tbpgBusinessProcess1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // gbKlient_Personal
            // 
            this.gbKlient_Personal.Controls.Add(this.button1);
            this.gbKlient_Personal.Controls.Add(this.tbctrlKlient);
            this.gbKlient_Personal.Controls.Add(this.lblKlient_Card_Number);
            this.gbKlient_Personal.Controls.Add(this.lblKlinet_Middlename);
            this.gbKlient_Personal.Controls.Add(this.lblKlinet_Name);
            this.gbKlient_Personal.Controls.Add(this.lblKlinet_Surname);
            this.gbKlient_Personal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbKlient_Personal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbKlient_Personal.Location = new System.Drawing.Point(0, 0);
            this.gbKlient_Personal.Name = "gbKlient_Personal";
            this.gbKlient_Personal.Size = new System.Drawing.Size(794, 450);
            this.gbKlient_Personal.TabIndex = 2;
            this.gbKlient_Personal.TabStop = false;
            this.gbKlient_Personal.Text = "Персональные данные";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(658, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Удалить аккаунт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbctrlKlient
            // 
            this.tbctrlKlient.Controls.Add(this.tbpgKlientProfile);
            this.tbctrlKlient.Controls.Add(this.tbpgBusinessProcess1);
            this.tbctrlKlient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbctrlKlient.Location = new System.Drawing.Point(3, 132);
            this.tbctrlKlient.Name = "tbctrlKlient";
            this.tbctrlKlient.SelectedIndex = 0;
            this.tbctrlKlient.Size = new System.Drawing.Size(788, 315);
            this.tbctrlKlient.TabIndex = 5;
            // 
            // tbpgKlientProfile
            // 
            this.tbpgKlientProfile.Controls.Add(this.tblltpnKLinet_Information);
            this.tbpgKlientProfile.Location = new System.Drawing.Point(4, 34);
            this.tbpgKlientProfile.Name = "tbpgKlientProfile";
            this.tbpgKlientProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgKlientProfile.Size = new System.Drawing.Size(780, 277);
            this.tbpgKlientProfile.TabIndex = 3;
            this.tbpgKlientProfile.Text = "Личный профиль";
            this.tbpgKlientProfile.UseVisualStyleBackColor = true;
            // 
            // tblltpnKLinet_Information
            // 
            this.tblltpnKLinet_Information.ColumnCount = 2;
            this.tblltpnKLinet_Information.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblltpnKLinet_Information.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblltpnKLinet_Information.Controls.Add(this.label1, 0, 0);
            this.tblltpnKLinet_Information.Controls.Add(this.label2, 0, 1);
            this.tblltpnKLinet_Information.Controls.Add(this.label3, 0, 2);
            this.tblltpnKLinet_Information.Controls.Add(this.label4, 0, 3);
            this.tblltpnKLinet_Information.Controls.Add(this.label5, 0, 4);
            this.tblltpnKLinet_Information.Controls.Add(this.tbFirst_Name, 1, 0);
            this.tblltpnKLinet_Information.Controls.Add(this.tbName, 1, 1);
            this.tblltpnKLinet_Information.Controls.Add(this.tbMiddle_Name, 1, 2);
            this.tblltpnKLinet_Information.Controls.Add(this.tbLogin, 1, 3);
            this.tblltpnKLinet_Information.Controls.Add(this.tbPassword, 1, 4);
            this.tblltpnKLinet_Information.Controls.Add(this.tbConfermPassword, 1, 5);
            this.tblltpnKLinet_Information.Controls.Add(this.btSave, 0, 6);
            this.tblltpnKLinet_Information.Controls.Add(this.label6, 0, 5);
            this.tblltpnKLinet_Information.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblltpnKLinet_Information.Location = new System.Drawing.Point(3, 3);
            this.tblltpnKLinet_Information.Name = "tblltpnKLinet_Information";
            this.tblltpnKLinet_Information.RowCount = 7;
            this.tblltpnKLinet_Information.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblltpnKLinet_Information.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblltpnKLinet_Information.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblltpnKLinet_Information.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblltpnKLinet_Information.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblltpnKLinet_Information.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblltpnKLinet_Information.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblltpnKLinet_Information.Size = new System.Drawing.Size(774, 271);
            this.tblltpnKLinet_Information.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Логин:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Пароль:";
            // 
            // tbFirst_Name
            // 
            this.tbFirst_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbFirst_Name.Location = new System.Drawing.Point(390, 3);
            this.tbFirst_Name.Name = "tbFirst_Name";
            this.tbFirst_Name.Size = new System.Drawing.Size(381, 32);
            this.tbFirst_Name.TabIndex = 6;
            this.tbFirst_Name.Enter += new System.EventHandler(this.back_Color);
            // 
            // tbName
            // 
            this.tbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbName.Location = new System.Drawing.Point(390, 41);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(381, 32);
            this.tbName.TabIndex = 7;
            this.tbName.Enter += new System.EventHandler(this.back_Color);
            // 
            // tbMiddle_Name
            // 
            this.tbMiddle_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbMiddle_Name.Location = new System.Drawing.Point(390, 79);
            this.tbMiddle_Name.Name = "tbMiddle_Name";
            this.tbMiddle_Name.Size = new System.Drawing.Size(381, 32);
            this.tbMiddle_Name.TabIndex = 8;
            this.tbMiddle_Name.Enter += new System.EventHandler(this.back_Color);
            // 
            // tbLogin
            // 
            this.tbLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbLogin.Location = new System.Drawing.Point(390, 117);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(381, 32);
            this.tbLogin.TabIndex = 9;
            this.tbLogin.Enter += new System.EventHandler(this.back_Color);
            // 
            // tbPassword
            // 
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPassword.Location = new System.Drawing.Point(390, 155);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(381, 32);
            this.tbPassword.TabIndex = 10;
            this.tbPassword.Enter += new System.EventHandler(this.back_Color);
            // 
            // tbConfermPassword
            // 
            this.tbConfermPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbConfermPassword.Location = new System.Drawing.Point(390, 193);
            this.tbConfermPassword.Name = "tbConfermPassword";
            this.tbConfermPassword.PasswordChar = '*';
            this.tbConfermPassword.Size = new System.Drawing.Size(381, 32);
            this.tbConfermPassword.TabIndex = 11;
            this.tbConfermPassword.Enter += new System.EventHandler(this.back_Color);
            // 
            // btSave
            // 
            this.btSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSave.Location = new System.Drawing.Point(3, 231);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(381, 37);
            this.btSave.TabIndex = 12;
            this.btSave.Text = "Сохранить данные";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Подтверждение пароля:";
            // 
            // tbpgBusinessProcess1
            // 
            this.tbpgBusinessProcess1.Controls.Add(this.button3);
            this.tbpgBusinessProcess1.Controls.Add(this.dataGridView3);
            this.tbpgBusinessProcess1.Controls.Add(this.button2);
            this.tbpgBusinessProcess1.Controls.Add(this.btSearch);
            this.tbpgBusinessProcess1.Controls.Add(this.label8);
            this.tbpgBusinessProcess1.Controls.Add(this.tbFindValue);
            this.tbpgBusinessProcess1.Controls.Add(this.label7);
            this.tbpgBusinessProcess1.Controls.Add(this.btOtpravit);
            this.tbpgBusinessProcess1.Controls.Add(this.tbtovar);
            this.tbpgBusinessProcess1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbpgBusinessProcess1.Location = new System.Drawing.Point(4, 34);
            this.tbpgBusinessProcess1.Name = "tbpgBusinessProcess1";
            this.tbpgBusinessProcess1.Size = new System.Drawing.Size(780, 277);
            this.tbpgBusinessProcess1.TabIndex = 4;
            this.tbpgBusinessProcess1.Text = "Ассортимент магазина";
            this.tbpgBusinessProcess1.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView3.Location = new System.Drawing.Point(5, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(280, 269);
            this.dataGridView3.TabIndex = 11;
            this.dataGridView3.CurrentCellChanged += new System.EventHandler(this.dataGridView3_CurrentCellChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(464, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 42);
            this.button2.TabIndex = 10;
            this.button2.Text = "Фильтр";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(328, 65);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(130, 42);
            this.btSearch.TabIndex = 6;
            this.btSearch.Text = "Поиск";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(374, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(280, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "Значение поиска\\фильтрации";
            // 
            // tbFindValue
            // 
            this.tbFindValue.Location = new System.Drawing.Point(395, 30);
            this.tbFindValue.Name = "tbFindValue";
            this.tbFindValue.Size = new System.Drawing.Size(242, 29);
            this.tbFindValue.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Наименование товара";
            // 
            // btOtpravit
            // 
            this.btOtpravit.Location = new System.Drawing.Point(416, 212);
            this.btOtpravit.Name = "btOtpravit";
            this.btOtpravit.Size = new System.Drawing.Size(208, 60);
            this.btOtpravit.TabIndex = 2;
            this.btOtpravit.Text = "Сделать предзаказ";
            this.btOtpravit.UseVisualStyleBackColor = true;
            this.btOtpravit.Click += new System.EventHandler(this.btOtpravit_Click);
            // 
            // tbtovar
            // 
            this.tbtovar.Location = new System.Drawing.Point(416, 177);
            this.tbtovar.Name = "tbtovar";
            this.tbtovar.Size = new System.Drawing.Size(208, 29);
            this.tbtovar.TabIndex = 1;
            // 
            // lblKlient_Card_Number
            // 
            this.lblKlient_Card_Number.AutoSize = true;
            this.lblKlient_Card_Number.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKlient_Card_Number.Location = new System.Drawing.Point(3, 106);
            this.lblKlient_Card_Number.Name = "lblKlient_Card_Number";
            this.lblKlient_Card_Number.Size = new System.Drawing.Size(113, 26);
            this.lblKlient_Card_Number.TabIndex = 4;
            this.lblKlient_Card_Number.Text = "Карта №: ";
            // 
            // lblKlinet_Middlename
            // 
            this.lblKlinet_Middlename.AutoSize = true;
            this.lblKlinet_Middlename.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKlinet_Middlename.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKlinet_Middlename.Location = new System.Drawing.Point(3, 80);
            this.lblKlinet_Middlename.Name = "lblKlinet_Middlename";
            this.lblKlinet_Middlename.Size = new System.Drawing.Size(120, 26);
            this.lblKlinet_Middlename.TabIndex = 2;
            this.lblKlinet_Middlename.Text = "Отчество: ";
            // 
            // lblKlinet_Name
            // 
            this.lblKlinet_Name.AutoSize = true;
            this.lblKlinet_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKlinet_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKlinet_Name.Location = new System.Drawing.Point(3, 54);
            this.lblKlinet_Name.Name = "lblKlinet_Name";
            this.lblKlinet_Name.Size = new System.Drawing.Size(68, 26);
            this.lblKlinet_Name.TabIndex = 1;
            this.lblKlinet_Name.Text = "Имя: ";
            // 
            // lblKlinet_Surname
            // 
            this.lblKlinet_Surname.AutoSize = true;
            this.lblKlinet_Surname.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKlinet_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKlinet_Surname.Location = new System.Drawing.Point(3, 28);
            this.lblKlinet_Surname.Name = "lblKlinet_Surname";
            this.lblKlinet_Surname.Size = new System.Drawing.Size(120, 26);
            this.lblKlinet_Surname.TabIndex = 0;
            this.lblKlinet_Surname.Text = "Фамилия: ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(600, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 42);
            this.button3.TabIndex = 12;
            this.button3.Text = "Отмена";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Personal_Profile_Klient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.gbKlient_Personal);
            this.Name = "Personal_Profile_Klient";
            this.Text = "Personal_Profile_Klient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Personal_Profile_Klient_FormClosing);
            this.Load += new System.EventHandler(this.Personal_Profile_Klient_Load);
            this.gbKlient_Personal.ResumeLayout(false);
            this.gbKlient_Personal.PerformLayout();
            this.tbctrlKlient.ResumeLayout(false);
            this.tbpgKlientProfile.ResumeLayout(false);
            this.tblltpnKLinet_Information.ResumeLayout(false);
            this.tblltpnKLinet_Information.PerformLayout();
            this.tbpgBusinessProcess1.ResumeLayout(false);
            this.tbpgBusinessProcess1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKlient_Personal;
        private System.Windows.Forms.Label lblKlinet_Middlename;
        private System.Windows.Forms.Label lblKlinet_Name;
        private System.Windows.Forms.Label lblKlinet_Surname;
        private System.Windows.Forms.Label lblKlient_Card_Number;
        private System.Windows.Forms.TabControl tbctrlKlient;
        private System.Windows.Forms.TabPage tbpgKlientProfile;
        private System.Windows.Forms.TableLayoutPanel tblltpnKLinet_Information;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFirst_Name;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbMiddle_Name;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbConfermPassword;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tbpgBusinessProcess1;
        private System.Windows.Forms.TextBox tbtovar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btOtpravit;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbFindValue;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button3;
    }
}