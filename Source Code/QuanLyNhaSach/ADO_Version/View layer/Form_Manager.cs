using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_Version.View_layer
{
    public partial class Form_Manager : Form
    {
        public Form_Manager()
        {
            InitializeComponent();
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            Form fmQLKH = new Form_Customer();
            fmQLKH.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            Form fmQLNV = new Form_QLNV();
            fmQLNV.ShowDialog();
        }

        private void Form_Manager_Load(object sender, EventArgs e)
        {

        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            Form form = new Form_Thong_Ke_Doanh_Thu();
            form.ShowDialog();
        }
    }
}
