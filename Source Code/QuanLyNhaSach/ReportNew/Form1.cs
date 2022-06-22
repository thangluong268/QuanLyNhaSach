using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportNew
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLNhaSachDataSet.ThongKeDoanhThu' table. You can move, or remove it, as needed.
            this.ThongKeDoanhThuTableAdapter.FillBy(this.QLNhaSachDataSet.ThongKeDoanhThu, this.dtpTimeStart.Value.Year);

            this.reportViewer1.RefreshReport();
        }
    }
}
