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
    public partial class Tovar_Klient_Check : Form
    {
        public Tovar_Klient_Check()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Tovar_Form tovar = new Tovar_Form();
            tovar.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Klient_Form klient = new Klient_Form();
            klient.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Check_Form check = new Check_Form();
            check.ShowDialog();
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

        private void Tovar_Klient_Check_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtomagazin_Data_BaseDataSet5.Check". При необходимости она может быть перемещена или удалена.
            this.checkTableAdapter.Fill(this.avtomagazin_Data_BaseDataSet5.Check);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtomagazin_Data_BaseDataSet4.Tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.avtomagazin_Data_BaseDataSet4.Tovar);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtomagazin_Data_BaseDataSet3.Klient". При необходимости она может быть перемещена или удалена.
            this.klientTableAdapter.Fill(this.avtomagazin_Data_BaseDataSet3.Klient);
            TovarFill();
        }


        public void TovarFill()
        {
            string connectionString = "Data Source=DESKTOP-ERGQ9ON\\SQLEXPRESS;Initial Catalog=Avtomagazin_Data_Base;Integrated Security=True";
            string sql = "SELECT [ID_Tovar_Klient_Check] , " +
                "[Tovar_ID] , " +
                "[Klient_ID] , " +
                "[Check_ID] , " +
                "[Name_of_Tovar] as \"Товар\" , " +
                "[First_Name_Klient]+' '+[Name_Klient]+' '+[Middle_Name_Klient] as \"Клиент\" , " +
                "[Nomer_Check] as \"Чек\" from [dbo].[Tovar_Klient_Check] " +
                "inner join [dbo].[Klient] on [dbo].[Klient].[ID_Klient] = [dbo].[Tovar_Klient_Check].[Klient_ID] " +
                "inner join [dbo].[Tovar] on [dbo].[Tovar].[ID_Tovar] = [dbo].[Tovar_Klient_Check].[Tovar_ID] " +
                "inner join [dbo].[Check] on [dbo].[Check].[ID_Check] = [dbo].[Tovar_Klient_Check].[Check_ID] ";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataTable ds = new DataTable();
            connection.Open();
            dataadapter.Fill(ds);
            connection.Close();
            dataGridView3.DataSource = ds;
            dataGridView3.Columns[0].Visible = false;
            dataGridView3.Columns[1].Visible = false;
            dataGridView3.Columns[2].Visible = false;
            dataGridView3.Columns[3].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Procedure_Class procedure = new Procedure_Class();

            //procedure.spTovar_Klient_Check_insert(
            //    Convert.ToInt32(cbTovar.SelectedValue.ToString()),
            //    Convert.ToInt32(cbKlient.SelectedValue.ToString()),
            //    Convert.ToInt32(cbCheck.SelectedValue.ToString()));
        }

        private void dataGridView3_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentCell != null && dataGridView3.CurrentCell.RowIndex >= 0)
            {
                cbKlient.Text = dataGridView3.Rows[dataGridView3.CurrentCell.RowIndex].Cells["Клиент"].Value.ToString();
                cbTovar.Text = dataGridView3.Rows[dataGridView3.CurrentCell.RowIndex].Cells["Товар"].Value.ToString();
                cbCheck.Text = dataGridView3.Rows[dataGridView3.CurrentCell.RowIndex].Cells["Чек"].Value.ToString();
            }
        }

    }
}
