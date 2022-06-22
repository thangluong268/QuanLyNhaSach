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

namespace ADO_Version
{
    public partial class Form_Thong_Ke_Doanh_Thu : Form
    {
        DataTable dtThongKe = null;
        BLThongKe dbTK = new BLThongKe();
        List<string> Info = new List<string>();
        public Form_Thong_Ke_Doanh_Thu()
        {
            InitializeComponent();
        }
        void LoadSoLuongSach()
        {
            try
            {
                dtThongKe = new DataTable();
                dtThongKe.Clear();

                DataSet ds = dbTK.LayDuLieu();
                dtThongKe = ds.Tables[0];

                dgv_ThongKeDauSach.DataSource = dtThongKe;
                dgv_ThongKeDauSach.AutoResizeColumns();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung . Lỗi!!!");
            }
        }
        void TinhTienNam(string NgayBatDau, string NgayKetThuc)
        {
            dtThongKe = new DataTable();
            dtThongKe.Clear();

            DataSet ds = null;
            ds = dbTK.TinhTienTheoNam(NgayBatDau, NgayKetThuc);
            dtThongKe = ds.Tables[0];

            Info.Clear();
            for (int i = 0; i < dtThongKe.Rows.Count; i++)
            {
                for (int j = 0; j < dtThongKe.Columns.Count; j++)
                {
                    object o = dtThongKe.Rows[i].ItemArray[j];
                    //if you want to get the string
                    string s = (string)(o = dtThongKe.Rows[i].ItemArray[j].ToString());
                    Info.Add(s);
                }
            }
            if (Info.Count > 0)
            {
                this.txtThongKe_Ban.Text = Info[1];
                this.txtThongKe_Muon.Text = Info[2];
                this.txt_ThongKe_Phat.Text = Info[3];
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin!");
            }
        }
        void TinhTienThang(string NgayBatDau)
        {
            dtThongKe = new DataTable();
            dtThongKe.Clear();

            DataSet ds = null;
            ds = dbTK.TinhTienTheoThang(NgayBatDau);
            dtThongKe = ds.Tables[0];

            Info.Clear();
            for (int i = 1; i < dtThongKe.Columns.Count; i++)
            {
                int tong = 0;
                for (int j = 0; j < dtThongKe.Rows.Count; j++)
                {
                    object o = dtThongKe.Rows[j].ItemArray[i];
                    //if you want to get the string
                    string s = (string)(o = dtThongKe.Rows[j].ItemArray[i].ToString());
                    if (s != "")
                        tong += Int32.Parse(s); 
                }
                Info.Add(tong.ToString());
            }
            if (Info.Count > 0)
            {
                this.txtThongKe_Ban.Text = Info[0];
                this.txtThongKe_Muon.Text = Info[1];
                this.txt_ThongKe_Phat.Text = Info[2];
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin!");
            }
        }
        void LoadTinhTienNam(string NgayBatDau, string NgayKetThuc)
        {
            TinhTienNam(NgayBatDau, NgayKetThuc);
            int tongTien = 0;
            try
            {
                tongTien = Int32.Parse(this.txtThongKe_Ban.Text) + Int32.Parse(this.txtThongKe_Muon.Text) + Int32.Parse(this.txt_ThongKe_Phat.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm thấy thông tin!");
            }
            this.txtTongTien.Text = tongTien.ToString();
        }
        void LoadTinhTienThang(string NgayBatDau)
        {
            TinhTienThang(NgayBatDau);
            int tongTien = Int32.Parse(this.txtThongKe_Ban.Text) + Int32.Parse(this.txtThongKe_Muon.Text) + Int32.Parse(this.txt_ThongKe_Phat.Text);
            this.txtTongTien.Text = tongTien.ToString();
        }
        void LoadThongKeTheoNam(string NgayBatDau, string NgayKetThuc)
        {
            try
            {
                dtThongKe = new DataTable();
                dtThongKe.Clear();

                DataSet ds = dbTK.TinhTienTheoNam(NgayBatDau, NgayKetThuc);
                dtThongKe = ds.Tables[0];

                dgv_ThongKeLoiNhuan.DataSource = dtThongKe;
                dgv_ThongKeLoiNhuan.AutoResizeColumns();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung . Lỗi!!!");
            }
        }
        void LoadThongKeTheoThang(string NgayBatDau)
        {
            try
            {
                dtThongKe = new DataTable();
                dtThongKe.Clear();

                DataSet ds = dbTK.TinhTienTheoThang(NgayBatDau);
                dtThongKe = ds.Tables[0];

                dgv_ThongKeLoiNhuan.DataSource = dtThongKe;
                dgv_ThongKeLoiNhuan.AutoResizeColumns();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung . Lỗi!!!");
            }
        }
        private void Form_Thong_Ke_Doanh_Thu_Load(object sender, EventArgs e)
        {
            LoadSoLuongSach();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (rbNam.Checked)
            {
                LoadThongKeTheoNam(this.dtNgayBatDau.Value.ToShortDateString().ToString(), DateTime.Today.ToShortDateString().ToString());
                LoadTinhTienNam(this.dtNgayBatDau.Value.ToShortDateString().ToString(), DateTime.Today.ToShortDateString().ToString());
            }
            else if (rbThang.Checked)
            {
                LoadThongKeTheoThang(this.dtNgayBatDau.Value.ToShortDateString().ToString());
                LoadTinhTienThang(this.dtNgayBatDau.Value.ToShortDateString().ToString());
            }
        }
    }
}
