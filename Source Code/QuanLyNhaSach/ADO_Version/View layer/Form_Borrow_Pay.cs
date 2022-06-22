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
    public partial class Form_Borrow_Pay : Form
    {
        DataTable dtPay = null;
        BLBorrowPay dbPay = new BLBorrowPay();
        public static string maCuon { get; set; }
        public static string maKH { get; set; }
        public static string ngaymuon { get; set; }
        public static string hantra { get; set; }
        public static string dongia { get; set; }
        public Form_Borrow_Pay()
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
        void LoadcmbCustomerID()
        {
            dtPay = new DataTable();
            dtPay.Clear();

            DataSet ds = dbPay.LayMaKhachHang();
            dtPay = ds.Tables[0];

            cmbCustomerID.ValueMember = "MaKH";
            cmbCustomerID.DataSource = dtPay;
        }
        void LoadcmbBookID()
        {
            dtPay = new DataTable();
            dtPay.Clear();

            DataSet ds = dbPay.LayMaCuon();
            dtPay = ds.Tables[0];

            cmbBookID.ValueMember = "MaCuon";
            cmbBookID.DataSource = dtPay;
        }

        private void Form_Borrow_Pay_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadcmbCustomerID();
            LoadcmbBookID();
        }

        private void dgvPAY_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvPAY.CurrentCell.RowIndex;

            cmbBookID.SelectedValue = dgvPAY.Rows[r].Cells[0].Value.ToString();
            cmbCustomerID.SelectedValue = dgvPAY.Rows[r].Cells[1].Value.ToString();
            dtpDayOfBorrow.Value = (DateTime)dgvPAY.Rows[r].Cells[2].Value;
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOutputBill_Click(object sender, EventArgs e)
        {
            maCuon = cmbBookID.SelectedValue.ToString();
            maKH = cmbCustomerID.SelectedValue.ToString();
            ngaymuon = dtpDayOfBorrow.Value.ToShortDateString();

            int r = dgvPAY.CurrentCell.RowIndex;

            DateTime tra = (DateTime)dgvPAY.Rows[r].Cells[3].Value;
            hantra = tra.ToShortDateString();
            dongia = dgvPAY.Rows[r].Cells[4].Value.ToString();

            Form form = new Form_Borrow_Bill();
            form.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                BLBorrowPay blPay = new BLBorrowPay();
                dtPay = new DataTable();
                dtPay.Clear();

                DataSet ds = blPay.TimKiemThanhToan(this.cmbCustomerID.SelectedValue.ToString(), this.dtpDayOfBorrow.Value.ToShortDateString().ToString());
                dtPay = ds.Tables[0];

                dgvPAY.DataSource = dtPay;
                dgvPAY.AutoResizeColumns();

            }
            catch (SqlException)
            {
                MessageBox.Show("Không tìm thấy thông tin!");
            }
        }
    }
}
