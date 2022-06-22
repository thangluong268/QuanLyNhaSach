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
    public partial class Form_Borrow_Pay : Form
    {
        Pay_Borrow pay = new Pay_Borrow();
        
        public Form_Borrow_Pay()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dgvPAY.DataSource = pay.Lay_TT_Pay_Borrow();
                LoadcmbCustomerID();
                LoadcmbBookID();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table PAY. Lỗi!!!");
            }
        }
        void LoadcmbCustomerID()
        {
            DataTable dataTable = new DataTable();
            dataTable = pay.Lay_TT_Pay_Borrow();

            cmbCustomerID.ValueMember = "MaKH";
            cmbCustomerID.DataSource = dataTable;
        }
        void LoadcmbBookID()
        {
            DataTable dataTable = new DataTable();
            dataTable = pay.Lay_TT_Pay_Borrow();

            cmbBookID.ValueMember = "MaCuon";
            cmbBookID.DataSource = dataTable;
        }

        private void Form_Borrow_Pay_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadcmbCustomerID();
            LoadcmbBookID();
        }

        private void dgvPAY_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           try
            {
                int r = dgvPAY.CurrentCell.RowIndex;

                cmbBookID.Text = dgvPAY.Rows[r].Cells[0].Value.ToString().Trim();
                cmbCustomerID.Text = dgvPAY.Rows[r].Cells[1].Value.ToString().Trim();
                dtpDayOfBorrow.Value = Convert.ToDateTime(dgvPAY.Rows[r].Cells[2].Value.ToString().Trim());
            }
            catch
            {
                MessageBox.Show("Không có dữ liệu");
            }
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
            string MaKH = cmbCustomerID.Text.ToString().Trim();

            Form form = new Form_Borrow_Bill(MaKH);
            form.ShowDialog();
           
     
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string MaKH = cmbCustomerID.Text.ToString().Trim();
                dgvPAY.DataSource = pay.Tim_KH_Chua_Thanh_Toan(MaKH);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không tìm thấy thông tin!");
            }
        }
    }
}
