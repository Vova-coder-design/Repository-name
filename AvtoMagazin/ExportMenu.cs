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
    public partial class ExportMenu : Form
    {
        public ExportMenu()
        {
            InitializeComponent();
        }

        private void btCheck_Export_Link_Click(object sender, EventArgs e)
        {
            Check_Export export = new Check_Export();
            export.ShowDialog();
        }

        private void btReservation_Link_Click(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice();
            invoice.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
