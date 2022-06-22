using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFramework_Version.BS_Layer;

namespace EntityFramework_Version.View_Layer
{
    public partial class Form_QLNV : Form
    {
        string option = null;
        QLNV qlnv = new QLNV();

        public Form_QLNV()
        {
            InitializeComponent();
            Load_Data();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.txtPass.PasswordChar = '✽';
        }

        private void ptbPassinvisible1_Click(object sender, EventArgs e)
        {
            if (this.ptbPassinvisible1.Visible == false)
            {
                this.ptbPassvisible1.Visible = false;
                this.ptbPassinvisible1.Visible = true;
                this.txtPass.PasswordChar = '\0';
            }
            else
            {
                this.ptbPassvisible1.Visible = true;
                this.ptbPassinvisible1.Visible = false;
                txtPass.PasswordChar = '✽';
            }
        }

        private void ptbPassvisible1_Click(object sender, EventArgs e)
        {
            if (this.ptbPassvisible1.Visible == true)
            {
                this.ptbPassvisible1.Visible = false;
                this.ptbPassinvisible1.Visible = true;
                this.txtPass.PasswordChar = '\0';
            }
            else
            {
                this.ptbPassvisible1.Visible = true;
                this.ptbPassinvisible1.Visible = false;
                txtPass.PasswordChar = '✽';
            }
        }

        void Load_Data()
        {
            try
            {
                dgvQLNV.DataSource = qlnv.Lay_TT_NV();
            }
            catch
            {
                MessageBox.Show("Không thể load dữ liệu");
            }
        }
        
        void Clear ()
        {
            txtAddress.ResetText();
            txtFullName.ResetText();
            txtIncome.ResetText();
            txtJob.ResetText();
            txtPhone.ResetText();
            txtStaffID.ResetText();
            dtpDayOfBirth.ResetText();
            cbSex.ResetText();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.option = "Them";
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnSearch.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.option = "Sua";
            btnDelete.Enabled = false;
            btnAdd.Enabled = false;
            btnSearch.Enabled = false;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.option = "Tim Kiem";
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = false;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.option = "Xoa";
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnSearch.Enabled = false;

        }

        private void dgvQLNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            try
            {
                int r = dgvQLNV.CurrentCell.RowIndex;

                txtAddress.Text = dgvQLNV.Rows[r].Cells[4].Value.ToString().Trim();
                txtFullName.Text = dgvQLNV.Rows[r].Cells[1].Value.ToString().Trim();
                txtIncome.Text = dgvQLNV.Rows[r].Cells[3].Value.ToString().Trim();
                txtJob.Text = dgvQLNV.Rows[r].Cells[2].Value.ToString().Trim();
                txtPhone.Text = dgvQLNV.Rows[r].Cells[7].Value.ToString().Trim();
                txtStaffID.Text = dgvQLNV.Rows[r].Cells[0].Value.ToString().Trim();
                dtpDayOfBirth.Value = Convert.ToDateTime(dgvQLNV.Rows[r].Cells[5].Value.ToString());
                cbSex.Checked = Convert.ToBoolean(dgvQLNV.Rows[r].Cells[6].Value.ToString());
                //txtUser.Text = dgvQLNV.Rows[r].Cells[8].Value.ToString().Trim();
                //txtPass.Text = dgvQLNV.Rows[r].Cells[9].Value.ToString().Trim();

            }
            catch
            {
                MessageBox.Show("Không có dữ liệu");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Load_Data();
            Clear();
            btnAdd.Enabled = true;
            btnSearch.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (option == "Them")
            {
                try
                {
                    string MaNV = txtStaffID.Text.Trim();
                    string TenNV = txtFullName.Text.Trim();
                    string CongViec = txtJob.Text.Trim();
                    string Luong = txtIncome.Text.Trim();
                    string DiaChi = txtAddress.Text.Trim();
                    DateTime NgSinh = Convert.ToDateTime(dtpDayOfBirth.Value);
                    bool GioiTinh = Convert.ToBoolean(cbSex.CheckState);
                    string SDT = txtPhone.Text.Trim();
                    string user = txtUser.Text.Trim();
                    string pass = txtPass.Text.Trim();
                    qlnv.Them_NV(MaNV, TenNV, CongViec, Luong, DiaChi, NgSinh, GioiTinh, SDT, user, pass);
                    MessageBox.Show("Đã thêm thông tin thành công");
                    Load_Data();
                }
                catch
                {
                    MessageBox.Show("Thêm thông tin không thành công, vui lòng kiểm tra lại");
                }
            }
            else if (option == "Sua")
            {
                try
                {
                    string MaNV = txtStaffID.Text.Trim();
                    string TenNV = txtFullName.Text.Trim();
                    string CongViec = txtJob.Text.Trim();
                    string Luong = txtIncome.Text.Trim();
                    string DiaChi = txtAddress.Text.Trim();
                    DateTime NgSinh = Convert.ToDateTime(dtpDayOfBirth.Value);
                    bool GioiTinh = Convert.ToBoolean(cbSex.CheckState);
                    string SDT = txtPhone.Text.Trim();
                    qlnv.Sua_TT_NV(MaNV, TenNV, CongViec, Luong, DiaChi, NgSinh, GioiTinh, SDT);
                    MessageBox.Show("Đã sửa thông tin thành công");
                    Load_Data();
                }
                catch
                {
                    MessageBox.Show("Sửa thông tin không thành công, vui lòng kiểm tra lại");
                }
            }
            else if (option == "Xoa")
            {
                try
                {
                    string MaNV = txtStaffID.Text.Trim();

                    qlnv.Xoa_NV(MaNV);
                    MessageBox.Show("Đã xóa thông tin thành công");
                    Load_Data();
                }
                catch
                {
                    MessageBox.Show("Không xóa được thông tin, vui lòng kiểm tra lại");
                }
            }
            else if (option == "Tim Kiem")
            {
                try
                {
                    string MaNV = txtStaffID.Text.Trim();

                    dgvQLNV.DataSource = qlnv.Tim_NV(MaNV);
                }
                catch
                {
                    MessageBox.Show("Không tìm được thông tin, vui lòng kiểm tra lại");
                }
            }
            else MessageBox.Show("Chưa chọn chức năng");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Form_QLNV_Load(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnSearch.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            this.option = null;
        }
    }
}
