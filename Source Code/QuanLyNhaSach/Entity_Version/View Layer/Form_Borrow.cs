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
    public partial class Form_Borrow : Form
    {

        Muon_Sach muon_sach = new Muon_Sach();
        string result;

        public Form_Borrow()
        {
            InitializeComponent();
            Load_Data();
        }

        void Load_Data () // Update data to the form
        {
            try
            {
                dgvMuon.DataSource = muon_sach.Lay_TT();
                LoadcmbCustomerID();
                LoadcmbBookID();
                
                btnBorrow.Enabled = true;
                btnReturn.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Không thể load data, lỗi rồi!!!");
            }
        }

        //void Clear () // Delete data for txt
        //{
        //    txtMaKH.ResetText();
        //    txtMaSach.ResetText();
        //}

        void LoadcmbCustomerID()
        {
            DataTable dataTable = new DataTable();
            dataTable = muon_sach.Load_KH();

            cmbCustomerID.ValueMember = "MaKH";
            cmbCustomerID.DataSource = dataTable;
        }
        void LoadcmbBookID()
        {
            DataTable dataTable = new DataTable();
            dataTable = muon_sach.Load_CuonSach_Chua_Xoa();

            cmbBookID.ValueMember = "MaCuon";
            cmbBookID.DataSource = dataTable;

        }

        private void btnBack_Click(object sender, EventArgs e) // back the form
        {
            this.Close();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            Load_Data();
            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                string MaKH = cmbCustomerID.Text.Trim();
                string MaCuon = cmbBookID.Text.Trim();
                muon_sach.KH_Tra_Sach(MaKH, MaCuon);
                MessageBox.Show("Đã trả thành công");
                Load_Data();
            }
            catch
            {
                MessageBox.Show("Trả không thành công, vui lòng kiểm tra lại mã khách hàng và mã cuốn");
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            try
            {
                string MaKH = cmbCustomerID.Text.Trim();
                string MaCuon = cmbBookID.Text.Trim();
                DateTime NgMuon = DateTime.Now;
                muon_sach.KH_Muon_Sach(MaKH, MaCuon, NgMuon, ref result);
                MessageBox.Show(result);
                Load_Data();
            }
            catch
            {
                MessageBox.Show("Thêm không thành công, vui lòng kiểm tra lại mã khách hàng và mã cuốn");
            }
        }

        private void dgvMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = dgvMuon.CurrentCell.RowIndex;

                cmbCustomerID.Text = dgvMuon.Rows[r].Cells[1].Value.ToString().Trim();
                cmbBookID.Text = dgvMuon.Rows[r].Cells[0].Value.ToString().Trim();
            }
            catch
            {
                MessageBox.Show("Không có dữ liệu");
            }
        }
    }
}
