using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvtoMagazin
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtomagazin_Data_BaseDataSet1.Nackladnaya_Predstavlenie". При необходимости она может быть перемещена или удалена.
            this.nackladnaya_PredstavlenieTableAdapter.Fill(this.avtomagazin_Data_BaseDataSet1.Nackladnaya_Predstavlenie);

        }

        private void btCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            if (dgvInvoice.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dgvInvoice.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dgvInvoice.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgvInvoice.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvInvoice.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dgvInvoice.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }
    }
}
