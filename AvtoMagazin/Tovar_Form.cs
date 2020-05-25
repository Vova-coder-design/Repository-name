using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary2;

namespace AvtoMagazin
{
    public partial class Tovar_Form : Form
    {
        public Tovar_Form()
        {
            InitializeComponent();
        }

        private void Tovar_Form_Load(object sender, EventArgs e)
        {
            TovarFill();
        }

        ClassLibrary2.Class1 class1 = new Class1();



        public void TovarFill()
        {
            //string connectionString = "Data Source=DESKTOP-ERGQ9ON\\SQLEXPRESS;Initial Catalog=Avtomagazin_Data_Base;Integrated Security=True";
            //string sql = "SELECT [ID_Tovar], [Name_of_Tovar] as \"Товар\" from [dbo].[Tovar]";
            
            SqlConnection connection = new SqlConnection(class1.connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(class1.sql, connection);
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
                tbTovar.Text = dataGridView3.Rows[dataGridView3.CurrentCell.RowIndex].Cells["Товар"].Value.ToString();
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


            procedure.spTovar_insert(tbTovar.Text.ToString());
            TovarFill();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Procedure_Class procedure = new Procedure_Class();

            ArrayList Tovar_update = new ArrayList();
            Program.intID = dataGridView3.CurrentCell.RowIndex.ToString();
            Tovar_update.Add(Program.intID);
            Tovar_update.Add(tbTovar.Text);
            procedure.procedure_Execution("Tovar_update", Tovar_update);
            TovarFill();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Procedure_Class procedure = new Procedure_Class();
            Program.intID = dataGridView3.CurrentCell.RowIndex.ToString();
            ArrayList Tovar_delete = new ArrayList();
            Tovar_delete.Add(Program.intID);
            procedure.procedure_Execution("Tovar_delete", Tovar_delete);
            TovarFill();
        }

        private void Tovar_Form_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
