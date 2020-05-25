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
    public partial class Klient_Form : Form
    {
        public Klient_Form()
        {
            InitializeComponent();
        }

        private void Klient_Form_Load(object sender, EventArgs e)
        {
            TovarFill();
        }

        public void TovarFill()
        {
            string connectionString = "Data Source=DESKTOP-ERGQ9ON\\SQLEXPRESS;Initial Catalog=Avtomagazin_Data_Base;Integrated Security=True";
            string sql = "SELECT [ID_Klient] , " +
                "[First_Name_Klient] as \"Фамилия\" , " +
                "[Name_Klient] as \"Имя\" , " +
                "[Middle_Name_Klient] as \"Отчество\" , " +
                "[Klient_Login] as \"Логин\" , " +
                "[Klient_Password] as \"Пароль\" , " +
                "[Klinet_Logical_Delete] as \"Удаление\" from [dbo].[Klient]";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataTable ds = new DataTable();
            connection.Open();
            dataadapter.Fill(ds);
            connection.Close();
            dataGridView3.DataSource = ds;
            dataGridView3.Columns[0].Visible = false;
        }

        private void dataGridView3_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentCell != null && dataGridView3.CurrentCell.RowIndex >= 0)
            {
                textBox1.Text = dataGridView3.Rows[dataGridView3.CurrentCell.RowIndex].Cells["Фамилия"].Value.ToString();
                textBox2.Text = dataGridView3.Rows[dataGridView3.CurrentCell.RowIndex].Cells["Имя"].Value.ToString();
                textBox3.Text = dataGridView3.Rows[dataGridView3.CurrentCell.RowIndex].Cells["Отчество"].Value.ToString();
                textBox4.Text = dataGridView3.Rows[dataGridView3.CurrentCell.RowIndex].Cells["Логин"].Value.ToString();
                textBox5.Text = dataGridView3.Rows[dataGridView3.CurrentCell.RowIndex].Cells["Пароль"].Value.ToString();
                textBox6.Text = dataGridView3.Rows[dataGridView3.CurrentCell.RowIndex].Cells["Удаление"].Value.ToString();
            }
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

        private void button4_Click(object sender, EventArgs e)
        {
            Procedure_Class procedure = new Procedure_Class();

            ArrayList Logical_delete_Klient = new ArrayList();
            Program.intID = dataGridView3.CurrentCell.RowIndex.ToString();
            Logical_delete_Klient.Add(Program.intID);
            Logical_delete_Klient.Add(textBox6.Text);
            procedure.procedure_Execution("Logical_delete_Klient", Logical_delete_Klient);
            TovarFill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Procedure_Class procedure = new Procedure_Class();

            ArrayList Logical_delete_Klient1 = new ArrayList();
            Program.intID = dataGridView3.CurrentCell.RowIndex.ToString();
            Logical_delete_Klient1.Add(Program.intID);
            Logical_delete_Klient1.Add(textBox6.Text);
            procedure.procedure_Execution("Logical_delete_Klient1", Logical_delete_Klient1);
            TovarFill();
        }
    }
}
