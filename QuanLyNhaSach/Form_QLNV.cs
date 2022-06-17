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
using QuanLyNhaSach.BS_layer;

namespace QuanLyNhaSach
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

            this.btnSave.Enabled = true;
            this.btnCancle.Enabled = true;

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

            this.btnAdd.Enabled = true;
            this.btnUpdate.Enabled = true;
            this.btnDelete.Enabled = true;
            this.btnBack.Enabled = true;
            this.btnSearch.Enabled = true;

            this.btnSave.Enabled = false;
            this.btnCancle.Enabled = false;

            dgvQLNV_CellClick(null, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    BLQLNV blQLNV = new BLQLNV();
                    blQLNV.ThemNhanVien(this.txtStaffID.Text, this.txtFullName.Text, this.txtJob.Text, this.txtIncome.Text, this.txtAddress.Text, this.dtpDayOfBirth.Value.ToString(), this.cbSex.Checked.ToString(), this.txtPhone.Text, ref err);
                    LoadData();
                    MessageBox.Show("Đã thêm xong!");
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

                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    dbQLNV.XoaNhanVien(ref err, strQLNV);
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
    }
}
