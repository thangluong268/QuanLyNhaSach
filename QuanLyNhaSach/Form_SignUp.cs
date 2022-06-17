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
    public partial class Form_SignUp : Form
    {
        string err;
        public Form_SignUp()
        {
            InitializeComponent();
        }
        
        private void Form_SignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            try
            {
                BLSignUp blSingUp = new BLSignUp();
                // thêm thông tin vào table NhanVien
                blSingUp.ThemNhanVien(this.txtStaffID.Text, this.txtFullName.Text, this.txtJob.Text, this.txtIncome.Text, this.txtAddress.Text, this.dtpDayOfBirth.Value.ToString(), this.cbSex.Checked.ToString(), this.txtPhone.Text, ref err);
                
                // thêm thông tin vào table TaiKhoan
                string quyen = "Nhanvien";
                blSingUp.ThemTaiKhoan(this.txtStaffID.Text, quyen, this.txtUsername.Text, this.txtPassword.Text, ref err);
                
                if (this.txtConfirmPass.Text == this.txtPassword.Text)
                    MessageBox.Show("Đã thêm xong!");
                else
                {
                    MessageBox.Show("Vui lòng xác nhận lại mật khẩu!");
                    this.txtPassword.ResetText();
                    this.txtConfirmPass.ResetText();
                    this.txtPassword.Focus();
                }

            }
            catch (SqlException)
            {
                MessageBox.Show("Không thêm được. Lỗi rồi!");
            }
        }
        private void Passvisible1_Click(object sender, EventArgs e)
        {
            if (this.Passvisible1.Visible == true)
            {
                this.Passvisible1.Visible = false;
                this.Passinvisible1.Visible = true;
                this.txtPassword.PasswordChar = '\0';
            }
            else
            {
                this.Passvisible1.Visible = true;
                this.Passinvisible1.Visible = false;
                txtPassword.PasswordChar = '✽';
            }
        }

        private void Passinvisible1_Click(object sender, EventArgs e)
        {
            if (this.Passinvisible1.Visible == false)
            {
                this.Passvisible1.Visible = false;
                this.Passinvisible1.Visible = true;
                this.txtPassword.PasswordChar = '\0';
            }
            else
            {
                this.Passvisible1.Visible = true;
                this.Passinvisible1.Visible = false;
                txtPassword.PasswordChar = '✽';
            }
        }

        private void Passinvisible2_Click(object sender, EventArgs e)
        {
            if (this.Passinvisible2.Visible == false)
            {
                this.Passvisible2.Visible = false;
                this.Passinvisible2.Visible = true;
                this.txtConfirmPass.PasswordChar = '\0';
            }
            else
            {
                this.Passvisible2.Visible = true;
                this.Passinvisible2.Visible = false;
                this.txtConfirmPass.PasswordChar = '✽';
            }
        }

        private void Passvisible2_Click(object sender, EventArgs e)
        {
            if (this.Passvisible2.Visible == true)
            {
                this.Passvisible2.Visible = false;
                this.Passinvisible2.Visible = true;
                this.txtConfirmPass.PasswordChar = '\0';
            }
            else
            {
                this.Passvisible2.Visible = true;
                this.Passinvisible2.Visible = false;
                this.txtConfirmPass.PasswordChar = '✽';
            }
        }
    }
}
