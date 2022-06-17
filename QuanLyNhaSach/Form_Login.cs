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
    public partial class Form_Login : Form
    {
        DataTable dtLogin = null;
        BLLogin dbLogin = new BLLogin();
        public Form_Login()
        {
            InitializeComponent();
        }
        private void btnForgetPass_Click(object sender, EventArgs e)
        {
            Form fmFindPass = new Form_Forget_Password();
            fmFindPass.ShowDialog();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            dtLogin = new DataTable();
            dtLogin.Clear();

            DataSet ds;
            string quyen = "Nhanvien";
            if (rbStaff.Checked)
                quyen = "Nhanvien";
            else if (rbManager.Checked)
                quyen = "Quanli";
            ds = dbLogin.CheckDangNhap(quyen, this.txtUsername.Text, this.txtPassword.Text);
            dtLogin = ds.Tables[0];

            int soLuong = 0;

            for (int i = 0; i < dtLogin.Rows.Count; i++)
            {
                for (int j = 0; j < dtLogin.Columns.Count; j++)
                {
                    object o = dtLogin.Rows[i].ItemArray[j];
                    //if you want to get the string
                    string s = (string)(o = dtLogin.Rows[i].ItemArray[j].ToString());
                    soLuong = Int32.Parse(s);
                }
            }

            if (soLuong == 1 && rbStaff.Checked)
            {
                Form formStaff = new Form_Staff();
                formStaff.ShowDialog();
            }
            else if (soLuong == 1 && rbManager.Checked)
            {
                Form formManager = new Form_Manager();
                formManager.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tên người dùng hoặc mật khẩu không đúng!");
                txtUsername.Focus();
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

        }
    }
}
