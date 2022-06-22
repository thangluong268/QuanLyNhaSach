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
    public partial class Form_Borrow_Bill : Form
    {
        DataTable dtBorrowBill = null;
        BLBorrowBill dbBorrowBill = new BLBorrowBill();
        List<string> Info = new List<string>();
        public Form_Borrow_Bill()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            string MaKhachHang = Form_Borrow_Pay.maKH;
            string NgayMuon = Form_Borrow_Pay.ngaymuon;
            try
            {
                dtBorrowBill = new DataTable();
                dtBorrowBill.Clear();

                DataSet ds = dbBorrowBill.LayDuLieu(MaKhachHang, NgayMuon);
                dtBorrowBill = ds.Tables[0];

                dgvBill.DataSource = dtBorrowBill;
                dgvBill.AutoResizeColumns();

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung . Lỗi!!!");
            }
        }
        void LoadTinhTong()
        {
            string MaKhachHang = Form_Borrow_Pay.maKH;
            string NgayMuon = Form_Borrow_Pay.ngaymuon;

            dtBorrowBill = new DataTable();
            dtBorrowBill.Clear();

            DataSet ds = dbBorrowBill.TinhTong(MaKhachHang, NgayMuon);
            dtBorrowBill = ds.Tables[0];

            Info.Clear();
            for (int i = 0; i < dtBorrowBill.Rows.Count; i++)
            {
                for (int j = 0; j < dtBorrowBill.Columns.Count; j++)
                {
                    object o = dtBorrowBill.Rows[i].ItemArray[j];
                    string s = (string)(o = dtBorrowBill.Rows[i].ItemArray[j].ToString());
                    Info.Add(s);
                }
            }

            if (Info.Count > 0)
            {
                this.lbSoLuong.Text = Info[0];
                this.lbThanhTien.Text = Info[1];

            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin!");
            }
        }
        private void Form_Borrow_Bill_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadTinhTong();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
