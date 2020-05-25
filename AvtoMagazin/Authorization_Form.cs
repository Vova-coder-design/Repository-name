using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvtoMagazin
{
    public partial class Authorization_Form : Form
    {
        public Authorization_Form()
        {
            InitializeComponent();
        }

        //Выход из окна
        private void BtLeave_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Глобальное событие на любую кнопку
        private void back_Color(object sender, EventArgs e)
        {
            if (sender is TextBox)
                (sender as TextBox).BackColor = Color.White;
        }

        private void BtEnter_Click(object sender, EventArgs e)
        {
            //Проверка на заполнение полей вводав
            switch (tbUser_Login.Text == "")
            {
                case true:
                    tbUser_Login.BackColor = Color.Red;
                    break;
                case false:
                    switch (tbUser_Password.Text == "")
                    {
                        case true:
                            tbUser_Password.BackColor = Color.Red;
                            break;
                        case false:
                            Function_Class function = new Function_Class();
                            //Прохождение авторизации
                            function.Authorization(tbUser_Login.Text,
                                tbUser_Password.Text);
                            switch (Program.intID == null)
                            {
                                //Не верно введёные данные
                                case true:
                                    MessageBox.Show("Введённые данные не верны! " +
                                        "Повторите ввод!",
                                               "Продажа товара", MessageBoxButtons.OK,
                                               MessageBoxIcon.Error);
                                    tbUser_Login.Clear();
                                    tbUser_Password.Clear();
                                    tbUser_Login.Focus();
                                    break;
                                case false:
                                    //Проверка на блокировку учётной записи
                                    switch (Program.intDropStatis)
                                    {
                                        case 1:
                                            MessageBox.Show("Вы временно заблокированы " +
                                                "в системе!\nОбратитесь к администратору!",
                                                "Продажа товара", MessageBoxButtons.OK,
                                                MessageBoxIcon.Warning);
                                            break;
                                        case 0:
                                            //Какого типа учётная запись сотрудник или клиент
                                            switch (Program.strStatus)
                                            {
                                                case "Klient":
                                                    Personal_Profile_Klient profile_Klient
                                                        = new Personal_Profile_Klient();
                                                    profile_Klient.Show(this);
                                                    Hide();
                                                    break;
                                                case "Employee":
                                                    Personal_Profile_Employee Profile_Employee
                                                        = new Personal_Profile_Employee();
                                                    Profile_Employee.Show(this);
                                                    Hide();
                                                    break;
                                            }
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }

        private void btRegistration_Click(object sender, EventArgs e)
        {
            Registration_Form registration = new Registration_Form();
            registration.ShowDialog();
        }
    }
}
