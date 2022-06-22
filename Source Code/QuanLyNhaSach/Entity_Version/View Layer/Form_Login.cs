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
    public partial class Form_Login : Form
    {
        string quyen = null;


        Login Login = new Login();

        public Form_Login()
        {
            InitializeComponent();
        }

        void Clear()
        {
            txtUsername.ResetText();
            txtPassword.ResetText();
        }
        private void radioNhanVien_CheckedChanged(object sender, EventArgs e)
        {
            this.quyen = "Nhanvien";
        }

        private void radioQuanLy_CheckedChanged(object sender, EventArgs e)
        {
            this.quyen = "Quanli";
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();
            if (quyen == "Nhanvien")
            {
                if (Login.Check_Login_IsTrue(user, pass, quyen))
                {

                    Form fmEmployee = new Form_Staff("Nhân Viên " + user);
                    fmEmployee.ShowDialog();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Nhập sai tên người dùng hoặc mật khẩu");
                }
            }    
            else if (quyen == "Quanli")
            {
                if (Login.Check_Login_IsTrue(user, pass, quyen))
                {
                    Form fmManager = new Form_Manager();
                    fmManager.ShowDialog();
                    Clear();

                }
                else
                {
                    MessageBox.Show("Nhập sai tên người dùng hoặc mật khẩu");
                }
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
