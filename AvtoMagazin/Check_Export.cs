using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace AvtoMagazin
{
    public partial class Check_Export : Form
    {
        public Check_Export()
        {
            InitializeComponent();
        }

        private void Check_Export_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtomagazin_Data_BaseDataSet.Check_Predstavlenie". При необходимости она может быть перемещена или удалена.
            this.check_PredstavlenieTableAdapter.Fill(this.avtomagazin_Data_BaseDataSet.Check_Predstavlenie);

        }

        private void btCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            if (gridwiew.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < gridwiew.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = gridwiew.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < gridwiew.Rows.Count; i++)
                {
                    for (int j = 0; j < gridwiew.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = gridwiew.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }
    }
}
