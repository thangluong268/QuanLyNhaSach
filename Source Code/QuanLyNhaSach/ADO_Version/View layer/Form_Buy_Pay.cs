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
using ADO_Version.BS_layer;

namespace ADO_Version.View_layer
{
    public partial class Form_Buy_Pay : Form
    {
        DataTable dtPay = null;

        public static string maKH { get; set; }
        public static string ngaymua { get; set; }

        BLBuyPay dbPay = new BLBuyPay();
        public Form_Buy_Pay()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dtPay = new DataTable();
                dtPay.Clear();

                DataSet ds = dbPay.LayDuLieu();
                dtPay = ds.Tables[0];

                dgvPAY.DataSource = dtPay;
                dgvPAY.AutoResizeColumns();

                dgvPAY_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table PAY. Lỗi!!!");
            }
        }

        private void Form_Pay_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadcmbCustomerID();
        }
        void LoadcmbCustomerID()
        {
            dtPay = new DataTable();
            dtPay.Clear();

            DataSet ds = dbPay.LayMaKhachHang();
            dtPay = ds.Tables[0];

            cmbCustomerID.ValueMember = "MaKH";
            cmbCustomerID.DataSource = dtPay;
        }

        private void dgvPAY_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvPAY.CurrentCell.RowIndex;

            cmbCustomerID.SelectedValue = dgvPAY.Rows[r].Cells[0].Value.ToString();
            dtpDayOfBuy.Value = (DateTime)dgvPAY.Rows[r].Cells[2].Value;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                BLBuyPay blPay = new BLBuyPay();
                dtPay = new DataTable();
                dtPay.Clear();

                DataSet ds = blPay.TimKiemThanhToan(this.cmbCustomerID.SelectedValue.ToString(), this.dtpDayOfBuy.Value.ToShortDateString().ToString());
                dtPay = ds.Tables[0];

                dgvPAY.DataSource = dtPay;
                dgvPAY.AutoResizeColumns();

            }
            catch (SqlException)
            {
                MessageBox.Show("Không tìm thấy thông tin!");
            }
        }

        private void btnOutputBill_Click(object sender, EventArgs e)
        {
            maKH = cmbCustomerID.SelectedValue.ToString();
            ngaymua = dtpDayOfBuy.Value.ToShortDateString();

            Form form = new Form_Buy_Bill();
            form.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
