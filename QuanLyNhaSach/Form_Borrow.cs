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
    public partial class Form_Borrow : Form
    {
        DataTable dtBorrow = null;
        //bool Them;
        string err;
        BLBorrow dbBr = new BLBorrow();
        public Form_Borrow()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            try
            {
                dtBorrow = new DataTable();
                dtBorrow.Clear();

                DataSet ds = dbBr.LayDuLieu();
                dtBorrow = ds.Tables[0];

                // Đưa dữ liệu lên DataGridView 
                dgvBORROW.DataSource = dtBorrow;
                // Thay đổi độ rộng cột 
                dgvBORROW.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel 
                txtMaKH.ResetText();
                txtMaSach.ResetText();
                //
                dgvBORROW_CellClick(null, null);

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table BORROW. Lỗi!!!");
            }
        }
        private void Form_Borrow_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void dgvBORROW_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvBORROW.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            txtMaKH.Text = dgvBORROW.Rows[r].Cells[0].Value.ToString();
            txtMaSach.Text = dgvBORROW.Rows[r].Cells[1].Value.ToString();
        }
    }
}
