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
    public partial class Personal_Profile_Employee : Form
    {

        //Объявление переменных о сохранении стороковых значений сотрудника
        string Employee_First_Name = "",
            Employee_Name = "", Employee_Middle_Name = "",
            Employee_Login = "", Employee_Password = "";

        private void Personal_Profile_Employee_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(Employee_Fill);
            thread.Start();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Procedure_Class procedure = new Procedure_Class();
            ArrayList array = new ArrayList();
            array.Add(Program.intID);
            array.Add(Employee_First_Name);
            array.Add(Employee_Name);
            array.Add(Employee_Middle_Name);
            switch (tbLogin.Text == "")
            {
                case true:
                    tbLogin.BackColor = Color.Red;
                    break;
                case false:
                    array.Add(tbLogin.Text);
                    switch (tbPassword.Text == Employee_Password ||
                        (tbPassword.Text == "" & tbConfermPassword.Text == ""))
                    {
                        case true:
                            array.Add(Employee_Password);
                            procedure.procedure_Execution("Employee_update", array);
                            break;
                        case false:
                            switch (tbConfermPassword.Text == tbPassword.Text)
                            {
                                case true:
                                    array.Add(tbConfermPassword.Text);
                                    procedure.procedure_Execution("Employee_update", array);
                                    MessageBox.Show("Выши данные были успешно изменены");
                                    tbPassword.Text = "";
                                    tbConfermPassword.Text = "";
                                    break;
                                case false:
                                    tbPassword.Clear();
                                    tbConfermPassword.Clear();
                                    tbPassword.BackColor = Color.Orange;
                                    tbConfermPassword.BackColor = Color.Orange;
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }

        private void back_Color(object sender, EventArgs e)
        {
            if (sender is TextBox)
                (sender as TextBox).BackColor = Color.White;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            ExportMenu export1 = new ExportMenu();
            export1.ShowDialog();
        }

        private void btPredzakaz_Click(object sender, EventArgs e)
        {
            Predzakaz_Form predzakaz = new Predzakaz_Form();
            predzakaz.ShowDialog();
        }

        private void Employee_Fill()
        {
            Action action = () =>
            {
                //Формирование запроса на вывод данных из таблицы сотрудников
                Table_Class table =
                new Table_Class(string.Format("select [First_Name_Employee], " +
                    "[Name_Employee], [Middle_Name_Employee], " +
                    "[Employee_Login], [Employee_Password] from [dbo].[Employee] " +
                    "where [ID_Employee]={0}",
                    Program.intID));
                //Организацйия прослушивания сервера
                table.Dependency.OnChange += Dependency_OnChange;
                //Присвоение полученной инормации о Сотруднике из БД в переменные
                Employee_First_Name = table.table.Rows[0][0].ToString();
                Employee_Name = table.table.Rows[0][1].ToString();
                Employee_Middle_Name = table.table.Rows[0][2].ToString();
                //Employee_Date_Create = table.table.Rows[0][3].ToString();
                Employee_Login = table.table.Rows[0][3].ToString();
                Employee_Password = table.table.Rows[0][4].ToString();
                //Присвоение инормации из переменных в визуальные компоненты
                lblEmployee_First_Name.Text =
                string.Format("Фамилия: {0}", Employee_First_Name);
                lblEmpoyee_Name.Text =
                string.Format("Имя: {0}", Employee_Name);
                lblEmployee_Middle_Name.Text =
                string.Format("Отчество: {0}", Employee_Middle_Name);
                //lblEmployee_Enterence.Text =
                //string.Format("Дата принятия: {0}", Employee_Date_Create);
                tbLogin.Text = Employee_Login;
            };
            Invoke(action);
        }

        /// <summary>
        /// Метод по событию отклика от сервера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dependency_OnChange(object sender, System.Data.SqlClient.SqlNotificationEventArgs e)
        {
            if (e.Info != System.Data.SqlClient.SqlNotificationInfo.Invalid)
                Employee_Fill();
        }

        private void Personal_Profile_Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (MessageBox.
               Show("Вы действительно хотите выйти из профиля " +
               "и\nперейти в авторизацию?", "Продажа товара",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    ((Authorization_Form)Owner).Show();
                    e.Cancel = false;
                    Program.intID = "";
                    Program.strStatus = "";
                    Program.intDropStatis = 0;
                    break;
                case DialogResult.No:
                    e.Cancel = true;
                    break;
            }
        }
        /// <summary>
        /// Метод проверки и сохранения данных о профиле сотрудника
        /// в базу данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        public Personal_Profile_Employee()
        {
            InitializeComponent();
        }



    }
}
