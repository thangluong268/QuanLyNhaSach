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
    public partial class Form_Buy : Form
    {
        DataTable dtBuy = null;
        string err;
        BLBuy dbBuy = new BLBuy();
        public Form_Buy()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dtBuy = new DataTable();
                dtBuy.Clear();

                DataSet ds = dbBuy.LayDuLieu();
                dtBuy = ds.Tables[0];

                dgvBUY.DataSource = dtBuy;
                dgvBUY.AutoResizeColumns();

                dgvBUY_CellClick(null, null);

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table BUY. Lỗi!!!");
            }
        }
        void LoadcmbBookID()
        {
            dtBuy = new DataTable();
            dtBuy.Clear();

            DataSet ds = dbBuy.LayMaCuon();
            dtBuy = ds.Tables[0];

            cmbBookID.ValueMember = "MaCuon";
            cmbBookID.DataSource = dtBuy;
        }
        void LoadcmbCustomerID()
        {
            dtBuy = new DataTable();
            dtBuy.Clear();

            DataSet ds = dbBuy.LayMaKhachHang();
            dtBuy = ds.Tables[0];

            cmbCustomerID.ValueMember = "MaKH";
            cmbCustomerID.DataSource = dtBuy;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Buy_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadcmbBookID();
            LoadcmbCustomerID();
        }

        private void dgvBUY_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvBUY.CurrentCell.RowIndex;

            cmbBookID.SelectedValue = dgvBUY.Rows[r].Cells[0].Value.ToString();
            cmbCustomerID.SelectedValue = dgvBUY.Rows[r].Cells[2].Value.ToString();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            try
            {
                BLBuy blBuy = new BLBuy();
                bool flag = true;
                DateTime ngaymua = DateTime.Today;
                if(this.cmbBookID.SelectedValue == null)
                {
                    MessageBox.Show("Đã hết sách");
                    return;
                }    
                blBuy.MuaSach(this.cmbBookID.SelectedValue.ToString(), this.cmbCustomerID.SelectedValue.ToString(), ngaymua.ToString(), flag.ToString(), ref err);
                blBuy.CapNhatCuonSach(this.cmbBookID.SelectedValue.ToString(), flag.ToString(), ref err);
                LoadData();
                LoadcmbBookID();
                MessageBox.Show("Đã mua xong!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Không tìm thấy thông tin!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.cmbBookID.ResetText();
            this.cmbCustomerID.ResetText();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
            LoadcmbBookID();
        }
    }
}
