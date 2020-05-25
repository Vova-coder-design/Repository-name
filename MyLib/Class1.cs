using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Class1
    {
        string connectionString = "Data Source=DESKTOP-ERGQ9ON\\SQLEXPRESS;Initial Catalog=Avtomagazin_Data_Base;Integrated Security=True";
        string sql = "SELECT [ID_Tovar], [Name_of_Tovar] as \"Товар\" from [dbo].[Tovar]";
    }
}
