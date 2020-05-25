using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvtoMagazin
{
    public partial class Personal_Profile_Klient : Form
    {
        public string s;
        public Personal_Profile_Klient()
        {
            InitializeComponent();
        }

        //Переменные для вывода данных в поля ввод и проверки на 
        //уникальность и изменение записей
        string 
            Klient_First_Name = "", Klient_Name = "",
            Klinet_Middle_Name = "", Login = "", Password = "";

        private void button1_Click(object sender, EventArgs e)
        {
            Procedure_Class procedure = new Procedure_Class();
            ArrayList Klient_delete = new ArrayList();
            Klient_delete.Add(Program.intID);
            procedure.procedure_Execution("Klient_delete", Klient_delete);
            MessageBox.Show("Ваш аккаунт был удален(((");
            this.Close();
 
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            //Объявление экземпляра класса работы с хранимыми процедурами
            Procedure_Class procedure = new Procedure_Class();
            //Объявляем не типизировапаный лист
            ArrayList Klient_Update = new ArrayList();
            //Добавляем значение первичного ключа клиента в список
            Klient_Update.Add(Program.intID);
            //Проверка заполнения полей ввода данных
            switch (tbFirst_Name.Text == "")
            {
                case true:
                    // Если поле пустое прерываем работу функции
                    //помечаем поле красным цветом
                    tbFirst_Name.BackColor = Color.Red;
                    break;
                case false:
                    //Если заполнено то, добавляем значение поля в список
                    //Выполняем проверку следующего поля ввода
                    Klient_Update.Add(tbFirst_Name.Text);
                    procedure.procedure_Execution("Klient_update", Klient_Update);
                    switch (tbName.Text == "")
                    {
                        case true:
                            tbName.BackColor = Color.Red;
                            break;
                        case false:
                            Klient_Update.Add(tbName.Text);
                            procedure.procedure_Execution("Klient_update", Klient_Update);
                            switch (tbMiddle_Name.Text == "")
                            {
                                case true:
                                    tbMiddle_Name.BackColor = Color.Red;
                                    break;
                                case false:
                                    Klient_Update.Add(tbMiddle_Name.Text);
                                    procedure.procedure_Execution("Klient_update", Klient_Update);
                                    switch (tbLogin.Text == "")
                                    {
                                        case true:
                                            tbLogin.BackColor = Color.Red;
                                            break;
                                        case false:
                                            Klient_Update.Add(tbLogin.Text);
                                            procedure.procedure_Execution("Klient_update", Klient_Update);
                                            switch (tbPassword.Text == Password ||
                                                (tbPassword.Text == "" & tbConfermPassword.Text == ""))
                                            {
                                                case true:
                                                    Klient_Update.Add(Password);
                                                    procedure.procedure_Execution("Klient_update", Klient_Update);
                                                    break;
                                                case false:
                                                    switch (tbConfermPassword.Text == tbPassword.Text)
                                                    {
                                                        case true:
                                                            Klient_Update.Add(tbConfermPassword.Text);
                                                            procedure.procedure_Execution("Klient_update", Klient_Update);
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


        private void btOtpravit_Click(object sender, EventArgs e)
        {
            Procedure_Class procedure = new Procedure_Class();
            procedure.spKPredzakazi_insert(tbtovar.Text.ToString(),
                Klient_First_Name,
                Klient_Name,
                Klinet_Middle_Name); 
            MessageBox.Show("Товар для вас зарезервирован");
            tbtovar.Text = "";
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            
                for (int i = 0; i < dataGridView3.RowCount; i++)
                {
                dataGridView3.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView3.ColumnCount; j++)
                        if (dataGridView3.Rows[i].Cells[j].Value != null)
                            if (dataGridView3.Rows[i].Cells[j].Value.ToString().Contains(tbFindValue.Text))
                            {
                            dataGridView3.Rows[i].Selected = true;
                                break;
                            }
                }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView3.RowCount; i++)
            {
                dataGridView3.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView3.ColumnCount; j++)
                    if (dataGridView3.Rows[i].Cells[j].Value != null)
                        if (dataGridView3.Rows[i].Cells[j].Value.ToString().Contains(tbFindValue.Text))
                        {
                            dataGridView3.Rows[i].Selected = true;
                            dataGridView3.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                            break;
                        }
                        else
                        {
                            dataGridView3.Rows[i].DefaultCellStyle.BackColor = Color.White;
                        }
                if (dataGridView3.Rows[i].DefaultCellStyle.BackColor == Color.White)
                {
                    dataGridView3.Rows[i].Visible = false;
                }


            }
        }


        private void dataGridView3_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentCell != null && dataGridView3.CurrentCell.RowIndex >= 0)
            {
                tbtovar.Text = dataGridView3.Rows[dataGridView3.CurrentCell.RowIndex].Cells["Товар"].Value.ToString();
            }
        }

        private void Personal_Profile_Klient_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (MessageBox.
                Show("Вы действительно хотите выйти из профиля " +
                "и\nперейти в авторизацию?", "Продажа товара",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    //Вывод формы авторизации из режима Hide
                    ((Authorization_Form)Owner).Show();
                    e.Cancel = false;
                    //Обнуление данных по сессии пользователя
                    Program.intID = "";
                    Program.strStatus = "";
                    Program.intDropStatis = 0;
                    break;
                case DialogResult.No:
                    e.Cancel = true;
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TovarFill();
        }

        private void Personal_Profile_Klient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtomagazin_Data_BaseDataSet2.Tovar". При необходимости она может быть перемещена или удалена.
            Thread thread = new Thread(Klient_Data_Fill);
            thread.Start();

            TovarFill();
        }

        public void TovarFill()
        {
            string connectionString = "Data Source=DESKTOP-ERGQ9ON\\SQLEXPRESS;Initial Catalog=Avtomagazin_Data_Base;Integrated Security=True";
            string sql = "SELECT [Name_of_Tovar] as \"Товар\" from [dbo].[Tovar]";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataTable ds = new DataTable();
            connection.Open();
            dataadapter.Fill(ds);
            connection.Close();
            dataGridView3.DataSource = ds;
            //dataGridView3.Columns[0].Visible = false;
        }

        public void Klient_Data_Fill()
        {
            Action action = () =>
            {
                //Выгрузка данных о авторизоаванном клиенте
                Table_Class table_Class = new Table_Class("select " +
                    "[First_Name_Klient], [Name_Klient], " +
                "[Middle_Name_Klient], " +
                " [Klient_Login], [Klient_Password] " +
                "from [dbo].[Klient] where [dbo].[Klient].[ID_Klient] = "
                + Program.intID);

                //Организация прослушивания сервера
                table_Class.Dependency.OnChange += Dependency_OnChange;
                //Присвоение значений из table класса DataTable 
                //Значений 0 строки и с 0 по шестой столбец
                Klient_First_Name = table_Class.table.Rows[0][0].ToString();
                Klient_Name = table_Class.table.Rows[0][1].ToString();
                Klinet_Middle_Name = table_Class.table.Rows[0][2].ToString();
                Login = table_Class.table.Rows[0][3].ToString();
                Password = table_Class.table.Rows[0][4].ToString();

                //Перезапись значений в надписях на форме
                lblKlinet_Surname.Text = "Фамилия: " + Klient_First_Name;
                lblKlinet_Name.Text = "Имя: " + Klient_Name;
                lblKlinet_Middlename.Text = "Отчество: "
                + Klinet_Middle_Name;
                tbFirst_Name.Text = Klient_First_Name;
                tbName.Text = Klient_Name;
                tbMiddle_Name.Text = Klinet_Middle_Name;
                tbLogin.Text = Login;
            };
            Invoke(action);
            
        }

        private void Dependency_OnChange(object sender, System.Data.SqlClient.SqlNotificationEventArgs e)
        {
            //Если отклик не равен бездействию, то перевыполняем метод
            //Заполения данных о клиенте
            if (e.Info != System.Data.SqlClient.SqlNotificationInfo.Invalid)
                Klient_Data_Fill();
        }
    }
}
