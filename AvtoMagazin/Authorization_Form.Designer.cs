namespace AvtoMagazin
{
    partial class Authorization_Form
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
            this.lblUser_Login = new System.Windows.Forms.Label();
            this.tbUser_Login = new System.Windows.Forms.TextBox();
            this.lbl_User_Password = new System.Windows.Forms.Label();
            this.tbUser_Password = new System.Windows.Forms.TextBox();
            this.btEnter = new System.Windows.Forms.Button();
            this.btLeave = new System.Windows.Forms.Button();
            this.btRegistration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUser_Login
            // 
            this.lblUser_Login.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUser_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUser_Login.Location = new System.Drawing.Point(0, 0);
            this.lblUser_Login.Name = "lblUser_Login";
            this.lblUser_Login.Size = new System.Drawing.Size(472, 26);
            this.lblUser_Login.TabIndex = 1;
            this.lblUser_Login.Text = "Логин";
            this.lblUser_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbUser_Login
            // 
            this.tbUser_Login.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbUser_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUser_Login.Location = new System.Drawing.Point(0, 26);
            this.tbUser_Login.Name = "tbUser_Login";
            this.tbUser_Login.PasswordChar = '*';
            this.tbUser_Login.Size = new System.Drawing.Size(472, 32);
            this.tbUser_Login.TabIndex = 2;
            this.tbUser_Login.Text = "Volk12345";
            this.tbUser_Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbUser_Login.Enter += new System.EventHandler(this.back_Color);
            // 
            // lbl_User_Password
            // 
            this.lbl_User_Password.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_User_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_User_Password.Location = new System.Drawing.Point(0, 58);
            this.lbl_User_Password.Name = "lbl_User_Password";
            this.lbl_User_Password.Size = new System.Drawing.Size(472, 26);
            this.lbl_User_Password.TabIndex = 3;
            this.lbl_User_Password.Text = "Пароль";
            this.lbl_User_Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbUser_Password
            // 
            this.tbUser_Password.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbUser_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUser_Password.Location = new System.Drawing.Point(0, 84);
            this.tbUser_Password.Name = "tbUser_Password";
            this.tbUser_Password.PasswordChar = '*';
            this.tbUser_Password.Size = new System.Drawing.Size(472, 32);
            this.tbUser_Password.TabIndex = 4;
            this.tbUser_Password.Text = "Qwerty_01";
            this.tbUser_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbUser_Password.Enter += new System.EventHandler(this.back_Color);
            // 
            // btEnter
            // 
            this.btEnter.Dock = System.Windows.Forms.DockStyle.Left;
            this.btEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btEnter.Location = new System.Drawing.Point(0, 116);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(163, 73);
            this.btEnter.TabIndex = 5;
            this.btEnter.Text = "Вход";
            this.btEnter.UseVisualStyleBackColor = true;
            this.btEnter.Enter += new System.EventHandler(this.BtEnter_Click);
            // 
            // btLeave
            // 
            this.btLeave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btLeave.Location = new System.Drawing.Point(340, 116);
            this.btLeave.Name = "btLeave";
            this.btLeave.Size = new System.Drawing.Size(132, 73);
            this.btLeave.TabIndex = 6;
            this.btLeave.Text = "Выход";
            this.btLeave.UseVisualStyleBackColor = true;
            this.btLeave.Click += new System.EventHandler(this.BtLeave_Click);
            this.btLeave.Enter += new System.EventHandler(this.back_Color);
            // 
            // btRegistration
            // 
            this.btRegistration.Dock = System.Windows.Forms.DockStyle.Left;
            this.btRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btRegistration.Location = new System.Drawing.Point(163, 116);
            this.btRegistration.Name = "btRegistration";
            this.btRegistration.Size = new System.Drawing.Size(179, 73);
            this.btRegistration.TabIndex = 7;
            this.btRegistration.Text = "Зарегистрироваться";
            this.btRegistration.UseVisualStyleBackColor = true;
            this.btRegistration.Click += new System.EventHandler(this.btRegistration_Click);
            // 
            // Authorization_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 189);
            this.Controls.Add(this.btRegistration);
            this.Controls.Add(this.btLeave);
            this.Controls.Add(this.btEnter);
            this.Controls.Add(this.tbUser_Password);
            this.Controls.Add(this.lbl_User_Password);
            this.Controls.Add(this.tbUser_Login);
            this.Controls.Add(this.lblUser_Login);
            this.Name = "Authorization_Form";
            this.Text = "Authorization_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser_Login;
        private System.Windows.Forms.TextBox tbUser_Login;
        private System.Windows.Forms.Label lbl_User_Password;
        private System.Windows.Forms.TextBox tbUser_Password;
        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.Button btLeave;
        private System.Windows.Forms.Button btRegistration;
    }
}