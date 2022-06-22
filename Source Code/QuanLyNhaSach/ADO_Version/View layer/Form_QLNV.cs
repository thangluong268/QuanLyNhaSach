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
    public partial class Form_QLNV : Form
    {
        DataTable dtQLNV = null;
        bool Them;
        string err;
        BLQLNV dbQLNV = new BLQLNV();
        public Form_QLNV()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dtQLNV = new DataTable();
                dtQLNV.Clear();

                DataSet ds = dbQLNV.LayNhanVien();
                dtQLNV = ds.Tables[0];

                dgvQLNV.DataSource = dtQLNV;
                dgvQLNV.AutoResizeColumns();

                txtStaffID.ResetText();
                txtFullName.ResetText();
                txtJob.ResetText();
                txtIncome.ResetText();
                txtAddress.ResetText();
                txtPhone.ResetText();
                txtUsername.ResetText();
                txtPassword.ResetText();

                this.txtUsername.Enabled = false;
                this.txtPassword.Enabled = false;
                this.btnSave.Enabled = false;
                this.btnCancle.Enabled = false;

                this.btnAdd.Enabled = true;
                this.btnUpdate.Enabled = true;
                this.btnDelete.Enabled = true;
                this.btnBack.Enabled = true;
                this.btnSearch.Enabled = true;

                dgvQLNV_CellClick(null, null);

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table QLNV. Lỗi!!!");
            }
        }
        int KiemTra(string MaNhanVien, string TaiKhoan, string type)
        {
            dtQLNV = new DataTable();
            dtQLNV.Clear();

            DataSet ds;
            if (type == "tontai")
                ds = dbQLNV.KiemTraNVTonTai(MaNhanVien);
            else if (type == "daxoa")
                ds = dbQLNV.KiemTraNVDaXoa(MaNhanVien);
            else
                ds = dbQLNV.KiemTraTKTonTai(TaiKhoan);
            dtQLNV = ds.Tables[0];

            int soLuong = 0;

            for (int i = 0; i < dtQLNV.Rows.Count; i++)
            {
                for (int j = 0; j < dtQLNV.Columns.Count; j++)
                {
                    object o = dtQLNV.Rows[i].ItemArray[j];
                    //if you want to get the string
                    string s = (string)(o = dtQLNV.Rows[i].ItemArray[j].ToString());
                    soLuong = Int32.Parse(s);
                }
            }
            return soLuong;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_QLNV_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Them = true;
            txtStaffID.Enabled = true;

            txtStaffID.ResetText();
            txtFullName.ResetText();
            txtJob.ResetText();
            txtIncome.ResetText();
            txtAddress.ResetText();
            txtPhone.ResetText();
            txtUsername.ResetText();
            txtPassword.ResetText();

            this.btnSave.Enabled = true;
            this.btnCancle.Enabled = true;
            this.txtUsername.Enabled = true;
            this.txtPassword.Enabled = true;

            this.btnAdd.Enabled = false;
            this.btnUpdate.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnBack.Enabled = false;
            this.btnSearch.Enabled = false;

            this.txtStaffID.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Them = false;

            dgvQLNV_CellClick(null, null);

            this.btnSave.Enabled = true;
            this.btnCancle.Enabled = true;

            this.btnAdd.Enabled = false;
            this.btnUpdate.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnBack.Enabled = false;
            this.btnSearch.Enabled = false;

            this.txtStaffID.Enabled = false;
            this.txtFullName.Focus();
        }

        private void dgvQLNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvQLNV.CurrentCell.RowIndex;

            txtStaffID.Text = dgvQLNV.Rows[r].Cells[0].Value.ToString();
            txtFullName.Text = dgvQLNV.Rows[r].Cells[1].Value.ToString();
            txtJob.Text = dgvQLNV.Rows[r].Cells[2].Value.ToString();
            txtIncome.Text = dgvQLNV.Rows[r].Cells[3].Value.ToString();
            txtAddress.Text = dgvQLNV.Rows[r].Cells[4].Value.ToString();
            try
            {
                dtpDayOfBirth.Value = (DateTime)dgvQLNV.Rows[r].Cells[5].Value;
            }
            catch (Exception)
            {
                dtpDayOfBirth.ResetText();
            }
            try
            {
                cbSex.Checked = (bool)dgvQLNV.Rows[r].Cells[6].Value;
            }
            catch (Exception)
            {
                cbSex.ResetText();
            }
            txtPhone.Text = dgvQLNV.Rows[r].Cells[7].Value.ToString();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            txtStaffID.ResetText();
            txtFullName.ResetText();
            txtJob.ResetText();
            txtIncome.ResetText();
            txtAddress.ResetText();
            txtPhone.ResetText();
            txtUsername.ResetText();
            txtPassword.ResetText();

            this.btnAdd.Enabled = true;
            this.btnUpdate.Enabled = true;
            this.btnDelete.Enabled = true;
            this.btnBack.Enabled = true;
            this.btnSearch.Enabled = true;

            this.btnSave.Enabled = false;
            this.btnCancle.Enabled = false;
            this.txtUsername.Enabled = false;
            this.txtPassword.Enabled = false;

            dgvQLNV_CellClick(null, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    BLQLNV blQLNV = new BLQLNV();
                    bool flag = false;
                    string quyen = "Nhanvien";

                    int kiemTraTonTai = KiemTra(this.txtStaffID.Text, "NULL", "tontai");
                    int kiemTraDaXoa = KiemTra(this.txtStaffID.Text, "NULL", "daxoa");
                    int kiemTraTaiKhoanTonTai = KiemTra("NULL", this.txtUsername.Text, "taikhoantontai");

                    if (kiemTraTonTai > 0)
                    {
                        MessageBox.Show("Nhân viên đã tồn tại!");
                        LoadData();
                    }
                    else if (kiemTraTaiKhoanTonTai > 0)
                    {
                        MessageBox.Show("Tên tài khoản đã tồn tại!");
                        this.txtUsername.ResetText();
                        this.txtUsername.Focus();
                    }
                    else if (kiemTraDaXoa > 0)
                    {
                        blQLNV.CapNhatNhanVienDaXoa(this.txtStaffID.Text, this.txtFullName.Text, this.txtJob.Text, this.txtIncome.Text, this.txtAddress.Text, this.dtpDayOfBirth.Value.ToString(), this.cbSex.Checked.ToString(), this.txtPhone.Text, flag.ToString(), ref err);
                        blQLNV.CapNhatTaiKhoanDaXoa(this.txtStaffID.Text, quyen, this.txtUsername.Text, this.txtPassword.Text, flag.ToString(), ref err);
                        LoadData();
                        MessageBox.Show("Đã thêm xong!");
                    }
                    else
                    {
                        blQLNV.ThemNhanVien(this.txtStaffID.Text, this.txtFullName.Text, this.txtJob.Text, this.txtIncome.Text, this.txtAddress.Text, this.dtpDayOfBirth.Value.ToString(), this.cbSex.Checked.ToString(), this.txtPhone.Text, flag.ToString(), ref err);
                        blQLNV.ThemTaiKhoan(this.txtStaffID.Text, quyen, this.txtUsername.Text, this.txtPassword.Text, flag.ToString(), ref err);
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
                BLQLNV blQLNV = new BLQLNV();
                blQLNV.CapNhatNhanVien(this.txtStaffID.Text, this.txtFullName.Text, this.txtJob.Text, this.txtIncome.Text, this.txtAddress.Text, this.dtpDayOfBirth.Value.ToString(), this.cbSex.Checked.ToString(), this.txtPhone.Text, ref err);
                LoadData();
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvQLNV.CurrentCell.RowIndex;

                string strQLNV = dgvQLNV.Rows[r].Cells[0].Value.ToString();
                bool flag = true;
                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    dbQLNV.XoaNhanVien(ref err, strQLNV, flag.ToString());
                    dbQLNV.XoaTaiKhoan(ref err, strQLNV, flag.ToString());
                    LoadData();
                    MessageBox.Show("Đã xóa xong!");
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

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                txtStaffID.Enabled = true;
                BLQLNV blQLNV = new BLQLNV();
                dtQLNV = new DataTable();
                dtQLNV.Clear();

                DataSet ds = blQLNV.TimKiemNhanVien(this.txtStaffID.Text, this.txtFullName.Text);
                dtQLNV = ds.Tables[0];

                dgvQLNV.DataSource = dtQLNV;
                dgvQLNV.AutoResizeColumns();

            }
            catch (SqlException)
            {
                MessageBox.Show("Không tìm thấy thông tin!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStaffID.Enabled = true;
            txtStaffID.ResetText();
            txtFullName.ResetText();
            txtJob.ResetText();
            txtIncome.ResetText();
            txtAddress.ResetText();
            txtPhone.ResetText();
            txtUsername.ResetText();
            txtPassword.ResetText();
        }
    }
}
