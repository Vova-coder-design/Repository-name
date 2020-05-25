using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace AvtoMagazin
{
    public class Procedure_Class
    {
        SqlCommand command = new SqlCommand("", Configuration_class.connection);
        /// <summary>
        /// Метод обращения к любой хранимой процедуре Microsoft SQL Server
        /// </summary>
        /// <param name="Procedure_name">Водимое название процедуры из БД</param>
        /// <param name="fileld_value">Не типизированная коллекция значений приложения</param>
        public void procedure_Execution(string Procedure_name, ArrayList fileld_value)
        {
            //Запрос на вывод списка параметров, конкретной хранимолй процедуры
            //в зависимости от введённого разработчиком названия Stored Procedure
            Table_Class table = new Table_Class(string.Format("select name from sys.parameters " +
                "where " +
                "object_id =" +
                " (select object_id from sys.procedures where name = '{0}')", Procedure_name));
            try
            {
                //Настройка SQLCommand для работы с хранимыми процедурами
                command.CommandType = CommandType.StoredProcedure;
                //Присвоение в текст команды названия хранимой процедуры
                command.CommandText = string.Format("[dbo].[{0}]", Procedure_name);
                //Отчистка параметров
                command.Parameters.Clear();
                for (int i = 0; i < table.table.Rows.Count; i++)
                {
                    //Сопоставление значений коллекций в значения параметров
                    command.Parameters.AddWithValue(table.table.Rows[i][0].ToString(),
                        fileld_value[i]);
                }
                //Объявление события на перехват сообщений из БД
                Configuration_class.connection.InfoMessage += Connection_InfoMessage;
                //Открытие подключения
                Configuration_class.connection.Open();
                //Выполнение запроса процедуры
                command.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                //Закрытие подключения
                Configuration_class.connection.Close();
            }
        }
        /// <summary>
        /// Обработчик события о получении собщения с сервера БД
        /// </summary>
        /// <param name="sender">Ссылка на объект</param>
        /// <param name="e">Аргумет сообщения сервера</param>
        private void Connection_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            //Вывод сообщения с сервера в диалоговое окно
            System.Windows.Forms.MessageBox.Show(e.Message);
            //Снятиек с события обработчика метода
            Configuration_class.connection.InfoMessage -= Connection_InfoMessage;
        }


        private void commandconfig(string config)
        {
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "[dbo].[" + config + "]";
            command.Parameters.Clear();
        }

        public void spKlient_insert(string First_Name_Klient, string Name_Klient, string Middle_Name_Klient, string Klient_Login, string Klient_Password)
        {
            commandconfig("Klient_insert");
            command.Parameters.AddWithValue("@First_Name_Klient", First_Name_Klient);
            command.Parameters.AddWithValue("@Name_Klient", Name_Klient);
            command.Parameters.AddWithValue("@Middle_Name_Klient", Middle_Name_Klient);
            command.Parameters.AddWithValue("@Klient_Login", Klient_Login);
            command.Parameters.AddWithValue("@Klient_Password", Klient_Password);
            Configuration_class.connection.Open();
            command.ExecuteNonQuery();
            Configuration_class.connection.Close();
        }


        public void spKPredzakazi_insert(string Naimanovanie_Tovara, string Fam_Klient, string Nam_Klient, string Otch_Klient)
        {
            commandconfig("Predzakazi_insert");
            command.Parameters.AddWithValue("@Naimanovanie_Tovara", Naimanovanie_Tovara);
            command.Parameters.AddWithValue("@Fam_Klient", Fam_Klient);
            command.Parameters.AddWithValue("@Nam_Klient", Nam_Klient);
            command.Parameters.AddWithValue("@Otch_Klient", Otch_Klient);
            Configuration_class.connection.Open();
            command.ExecuteNonQuery();
            Configuration_class.connection.Close();
        }

        public void spTovar_insert(string Name_of_Tovar)
        {
            commandconfig("Tovar_insert");
            command.Parameters.AddWithValue("@Name_of_Tovar", Name_of_Tovar);
            Configuration_class.connection.Open();
            command.ExecuteNonQuery();
            Configuration_class.connection.Close();
        }

        public void spTovar_delete(Int32 ID_Tovar)
        {
            commandconfig("Tovar_delete");
            command.Parameters.AddWithValue("@ID_Tovar", ID_Tovar);
            Configuration_class.connection.Open();
            command.ExecuteNonQuery();
            Configuration_class.connection.Close();
        }


        public void spCheck_insert(string Nomer_Check, string Date_Check)
        {
            commandconfig("Check_insert");
            command.Parameters.AddWithValue("@Nomer_Check", Nomer_Check);
            command.Parameters.AddWithValue("@Date_Check", Date_Check);
            Configuration_class.connection.Open();
            command.ExecuteNonQuery();
            Configuration_class.connection.Close();
        }


        public void spTovar_Klient_Check_insert(Int32 Tovar_ID, Int32 Klient_ID, Int32 Check_ID)
        {
            commandconfig("Tovar_Klient_Check_insert");
            command.Parameters.AddWithValue("@Tovar_ID", Tovar_ID);
            command.Parameters.AddWithValue("@Klient_ID", Klient_ID);
            command.Parameters.AddWithValue("@Check_ID", Check_ID);
            Configuration_class.connection.Open();
            command.ExecuteNonQuery();
            Configuration_class.connection.Close();
        }


    }
}
