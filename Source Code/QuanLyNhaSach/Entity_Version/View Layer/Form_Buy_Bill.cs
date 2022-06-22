using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using EntityFramework_Version.BS_Layer;

namespace EntityFramework_Version.View_Layer
{
    public partial class Form_Buy_Bill : Form
    {
        Pay_Buy pay = new Pay_Buy();
        string MaKH;
        public Form_Buy_Bill()
        {
            InitializeComponent();
        }

        void Thanh_Toan ()
        {
            try
            {
                pay.DaThanhToan(MaKH);
                MessageBox.Show("Đã thanh toán thành công");
            }
            catch
            {
                MessageBox.Show("Thanh toán không thành công");
            }
        }
        public Form_Buy_Bill(string MaKH)
        {
            InitializeComponent();
            this.MaKH = MaKH;
        }

        private void Form_Bill_Load(object sender, EventArgs e)
        {
            
            var result = pay.Pay_Bill_Buy(MaKH);
            dgvBill.DataSource = result.Item1;
            lbSoLuong.Text = result.Item2.ToString().Trim();
            lbThanhTien.Text = result.Item3.ToString().Trim();

            Thanh_Toan();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
