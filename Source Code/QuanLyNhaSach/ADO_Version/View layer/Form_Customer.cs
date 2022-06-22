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
    public partial class Form_Customer : Form
    {
        DataTable dtCustomer = null;
        bool Them;
        string err;
        BLCustomer dbCustomer = new BLCustomer();
        public Form_Customer()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dtCustomer = new DataTable();
                dtCustomer.Clear();

                DataSet ds = dbCustomer.LayKhachHang();
                dtCustomer = ds.Tables[0];

                dgvCUSTOMER.DataSource = dtCustomer;
                dgvCUSTOMER.AutoResizeColumns();

                txtCustomerID.ResetText();
                txtFullName.ResetText();
                txtAddress.ResetText();
                txtPhone.ResetText();

                this.btnSave.Enabled = false;
                this.btnCancle.Enabled = false;

                this.btnAdd.Enabled = true;
                this.btnUpdate.Enabled = true;
                this.btnDelete.Enabled = true;
                this.btnBack.Enabled = true;
                this.btnSearch.Enabled = true;

                dgvCUSTOMER_CellClick(null, null);

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table KhachHang. Lỗi!!!");
            }
        }
        int KiemTra(string MaKhachHang, string type)
        {
            dtCustomer = new DataTable();
            dtCustomer.Clear();

            DataSet ds;
            if (type == "tontai")
                ds = dbCustomer.KiemTraKHTonTai(MaKhachHang);
            else if (type == "daxoa")
                ds = dbCustomer.KiemTraKHDaXoa(MaKhachHang);
            else
                ds = dbCustomer.KiemTraKHDangMuon(MaKhachHang);
            dtCustomer = ds.Tables[0];

            int soLuong = 0;

            for (int i = 0; i < dtCustomer.Rows.Count; i++)
            {
                for (int j = 0; j < dtCustomer.Columns.Count; j++)
                {
                    object o = dtCustomer.Rows[i].ItemArray[j];
                    //if you want to get the string
                    string s = (string)(o = dtCustomer.Rows[i].ItemArray[j].ToString());
                    soLuong = Int32.Parse(s);
                }
            }
            return soLuong;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Customer_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Them = true;
            txtCustomerID.Enabled = true;

            txtCustomerID.ResetText();
            txtFullName.ResetText();
            txtAddress.ResetText();
            txtPhone.ResetText();

            this.btnSave.Enabled = true;
            this.btnCancle.Enabled = true;

            this.btnAdd.Enabled = false;
            this.btnUpdate.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnBack.Enabled = false;
            this.btnSearch.Enabled = false;

            this.txtCustomerID.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Them = false;

            dgvCUSTOMER_CellClick(null, null);

            this.btnSave.Enabled = true;
            this.btnCancle.Enabled = true;

            this.btnAdd.Enabled = false;
            this.btnUpdate.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnBack.Enabled = false;
            this.btnSearch.Enabled = false;

            this.txtCustomerID.Enabled = false;
            this.txtFullName.Focus();
        }

        private void dgvCUSTOMER_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvCUSTOMER.CurrentCell.RowIndex;

            txtCustomerID.Text = dgvCUSTOMER.Rows[r].Cells[0].Value.ToString();
            txtFullName.Text = dgvCUSTOMER.Rows[r].Cells[1].Value.ToString();
            txtAddress.Text = dgvCUSTOMER.Rows[r].Cells[2].Value.ToString();
            try
            {
                dtpDayOfBirth.Value = (DateTime)dgvCUSTOMER.Rows[r].Cells[3].Value;
            }
            catch (Exception)
            {
                dtpDayOfBirth.ResetText();
            }
            txtPhone.Text = dgvCUSTOMER.Rows[r].Cells[4].Value.ToString();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            txtCustomerID.ResetText();
            txtFullName.ResetText();
            txtAddress.ResetText();
            txtPhone.ResetText();

            this.btnAdd.Enabled = true;
            this.btnUpdate.Enabled = true;
            this.btnDelete.Enabled = true;
            this.btnBack.Enabled = true;
            this.btnSearch.Enabled = true;

            this.btnSave.Enabled = false;
            this.btnCancle.Enabled = false;

            dgvCUSTOMER_CellClick(null, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    BLCustomer blCustomer = new BLCustomer();
                    bool flag = false;
                    int kiemtratontai = KiemTra(this.txtCustomerID.Text, "tontai");
                    int kiemtradaxoa = KiemTra(this.txtCustomerID.Text, "daxoa");

                    if (kiemtratontai > 0)
                    {
                        MessageBox.Show("Khách Hàng đã tồn tại!");
                        LoadData();
                    }
                    else if (kiemtradaxoa > 0)
                    {
                        blCustomer.CapNhatKhachHangDaXoa(this.txtCustomerID.Text, this.txtFullName.Text, this.txtAddress.Text, this.dtpDayOfBirth.Value.ToString(), this.txtPhone.Text, flag.ToString(), ref err);
                        LoadData();
                        MessageBox.Show("Đã thêm xong!");
                    }
                    else
                    {
                        blCustomer.ThemKhachHang(this.txtCustomerID.Text, this.txtFullName.Text, this.txtAddress.Text, this.dtpDayOfBirth.Value.ToString(), this.txtPhone.Text, flag.ToString(), ref err);
                        LoadData();
                        MessageBox.Show("Đã thêm xong!");
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                BLCustomer blCustomer = new BLCustomer();
                blCustomer.CapNhatKhachHang(this.txtCustomerID.Text, this.txtFullName.Text, this.txtAddress.Text, this.dtpDayOfBirth.Value.ToString(), this.txtPhone.Text, ref err);
                LoadData();
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvCUSTOMER.CurrentCell.RowIndex;

                string strCustomer = dgvCUSTOMER.Rows[r].Cells[0].Value.ToString();
                bool flag = true;
                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    int kiemtradangmuon = KiemTra(this.txtCustomerID.Text, "dangmuon");

                    if (kiemtradangmuon > 0)
                    {
                        MessageBox.Show("Khách Hàng đang mượn sách!");
                        return;
                    }
                    else
                    {
                        dbCustomer.XoaKhachHang(ref err, strCustomer, flag.ToString());
                        LoadData();
                        MessageBox.Show("Đã xóa xong!");
                    }    
                }
                else
                {
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                txtCustomerID.Enabled = true;
                BLCustomer blCus = new BLCustomer();
                dtCustomer = new DataTable();
                dtCustomer.Clear();

                DataSet ds = blCus.TimKiemKhachHang(this.txtCustomerID.Text, this.txtFullName.Text);
                dtCustomer = ds.Tables[0];

                dgvCUSTOMER.DataSource = dtCustomer;
                dgvCUSTOMER.AutoResizeColumns();

            }
            catch (SqlException)
            {
                MessageBox.Show("Không tìm thấy thông tin!");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCLear_Click(object sender, EventArgs e)
        {
            txtCustomerID.Enabled = true;
            txtCustomerID.ResetText();
            txtFullName.ResetText();
            txtAddress.ResetText();
            txtPhone.ResetText();
        }
    }
}
