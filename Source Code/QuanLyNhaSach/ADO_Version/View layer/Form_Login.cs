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
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.txtPassword.PasswordChar = '✽';
        }

        private void ptbPassinvisible1_Click(object sender, EventArgs e)
        {
            if (this.ptbPassinvisible1.Visible == false)
            {
                this.ptbPassvisible1.Visible = false;
                this.ptbPassinvisible1.Visible = true;
                this.txtPassword.PasswordChar = '\0';
            }
            else
            {
                this.ptbPassvisible1.Visible = true;
                this.ptbPassinvisible1.Visible = false;
                txtPassword.PasswordChar = '✽';
            }
        }

        private void ptbPassvisible1_Click(object sender, EventArgs e)
        {
            if (this.ptbPassvisible1.Visible == true)
            {
                this.ptbPassvisible1.Visible = false;
                this.ptbPassinvisible1.Visible = true;
                this.txtPassword.PasswordChar = '\0';
            }
            else
            {
                this.ptbPassvisible1.Visible = true;
                this.ptbPassinvisible1.Visible = false;
                txtPassword.PasswordChar = '✽';
            }
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            this.txtUsername.ResetText();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            this.txtPassword.ResetText();
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
                this.txtUsername.Text = "User Name";
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
                this.txtPassword.Text = "Password";
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            this.txtUsername.ResetText();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            this.txtPassword.ResetText();
        }
    }
}
