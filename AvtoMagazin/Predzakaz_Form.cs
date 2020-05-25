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
    public partial class Predzakaz_Form : Form
    {
        public Predzakaz_Form()
        {
            InitializeComponent();
        }

        private void Predzakaz_Form_Load(object sender, EventArgs e)
        {
            TovarFill();

        }

        public void TovarFill()
        {
            string connectionString = "Data Source=DESKTOP-ERGQ9ON\\SQLEXPRESS;Initial Catalog=Avtomagazin_Data_Base;Integrated Security=True";
            string sql = "SELECT [Naimanovanie_Tovara] as \"Товар\" ,  " +
                "[Fam_Klient] as \"Фамилия_Клиента\" , " +
                "[Nam_Klient] as \"Имя_Клиента\" , " +
                "[Otch_Klient] as \"Отчество_Клиента\" from [dbo].[Predzakazi]";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataTable ds = new DataTable();
            connection.Open();
            dataadapter.Fill(ds);
            connection.Close();
            dataGridView3.DataSource = ds;
            //dataGridView3.Columns[0].Visible = false;
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

        private void button3_Click(object sender, EventArgs e)
        {
            TovarFill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tovar_Klient_Check tovar_ = new Tovar_Klient_Check();
            tovar_.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
