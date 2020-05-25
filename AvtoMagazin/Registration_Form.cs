using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvtoMagazin
{
    public partial class Registration_Form : Form
    {
        public Registration_Form()
        {
            InitializeComponent();
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            Procedure_Class procedure = new Procedure_Class();


            procedure.spKlient_insert(tbFirst_Name.Text.ToString(), tbName.Text.ToString(), tbMiddle_Name.Text.ToString(),
                tbLogin.Text.ToString(), tbPassword.Text.ToString());
            MessageBox.Show("Вы успешно зарегистрировались в системе, ваш логин: " + tbLogin.Text + ", ваш пароль: " + tbPassword.Text);
            this.Close();
        }
    }
}
