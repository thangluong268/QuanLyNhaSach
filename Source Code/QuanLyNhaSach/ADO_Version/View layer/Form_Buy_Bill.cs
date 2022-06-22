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
    public partial class Form_Buy_Bill : Form
    {
        DataTable dtBuyBill = null;
        BLBuyBill dbBuyBill = new BLBuyBill();
        List<string> Info = new List<string>();
        public Form_Buy_Bill()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            string MaKhachHang = Form_Buy_Pay.maKH;
            string NgayMua = Form_Buy_Pay.ngaymua;
            try
            {
                dtBuyBill = new DataTable();
                dtBuyBill.Clear();

                DataSet ds = dbBuyBill.LayDuLieu(MaKhachHang, NgayMua);
                dtBuyBill = ds.Tables[0];

                dgvBill.DataSource = dtBuyBill;
                dgvBill.AutoResizeColumns();

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung . Lỗi!!!");
            }
        }
        void LoadTinhTong()
        {
            string MaKhachHang = Form_Buy_Pay.maKH;
            string NgayMua = Form_Buy_Pay.ngaymua;

            dtBuyBill = new DataTable();
            dtBuyBill.Clear();

            DataSet ds = dbBuyBill.TinhTong(MaKhachHang, NgayMua);
            dtBuyBill = ds.Tables[0];

            Info.Clear();
            for (int i = 0; i < dtBuyBill.Rows.Count; i++)
            {
                for (int j = 0; j < dtBuyBill.Columns.Count; j++)
                {
                    object o = dtBuyBill.Rows[i].ItemArray[j];
                    string s = (string)(o = dtBuyBill.Rows[i].ItemArray[j].ToString());
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
        private void Form_Bill_Load(object sender, EventArgs e)
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
