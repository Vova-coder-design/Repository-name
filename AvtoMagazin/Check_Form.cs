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
    public partial class Check_Form : Form
    {
        
        public Check_Form()
        {
            InitializeComponent();
        }

        private void Check_Form_Load(object sender, EventArgs e)
        {
            TovarFill();
        }

        public void TovarFill()
        {
            string connectionString = "Data Source=DESKTOP-ERGQ9ON\\SQLEXPRESS;Initial Catalog=Avtomagazin_Data_Base;Integrated Security=True";
            string sql = "SELECT [ID_Check], [Nomer_Check] as \"Номер_Чека\" , " +
                "[Date_Check] as \"Дата_Чека\" from [dbo].[Check]";
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
                tbNomer.Text = dataGridView3.Rows[dataGridView3.CurrentCell.RowIndex].Cells["Номер_Чека"].Value.ToString();
                tbDate.Text = dataGridView3.Rows[dataGridView3.CurrentCell.RowIndex].Cells["Дата_Чека"].Value.ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Procedure_Class procedure = new Procedure_Class();


            procedure.spCheck_insert(tbNomer.Text.ToString(), tbDate.Text.ToString());
            TovarFill();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Procedure_Class procedure = new Procedure_Class();

            ArrayList Check_update = new ArrayList();
            Program.intID = dataGridView3.CurrentCell.RowIndex.ToString();
            Check_update.Add(Program.intID);
            Check_update.Add(tbNomer.Text);
            procedure.procedure_Execution("Check_update", Check_update);
            Check_update.Add(tbDate.Text);
            procedure.procedure_Execution("Check_update", Check_update);
            TovarFill();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Procedure_Class procedure = new Procedure_Class();
            Program.intID = dataGridView3.CurrentCell.RowIndex.ToString();
            ArrayList Check_delete = new ArrayList();
            Check_delete.Add(Program.intID);
            procedure.procedure_Execution("Check_delete", Check_delete);
            TovarFill();
        }
    }
}
