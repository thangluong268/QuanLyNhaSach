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
    public partial class Form_Forget_Password : Form
    {
        Find_Pass find_pass = new Find_Pass();
        public Form_Forget_Password()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFindPass_Click(object sender, EventArgs e)
        {
            try
            {
                string MaNV = txtStaffID.Text.Trim();
                string TenNV = txtFullName.Text.Trim();
                string SDT = txtPhone.Text.Trim();

                var result = find_pass.Tim_MK(MaNV, TenNV, SDT);
                lblStaffID.Text = result.Item1.ToString().Trim();
                lblUserName.Text = result.Item2.ToString().Trim();
                lblPassword.Text = result.Item3.ToString().Trim();

                //dgvFindPass.DataSource = find_pass.Tim_MK(MaNV, TenNV, SDT);
                //dgvFindPass.AutoResizeColumns();

                MessageBox.Show("Đã tìm được tên tài khoản và mật khẩu");

            }
            catch
            {
                MessageBox.Show("Không thể tìm tên tài khoản và mật khẩu");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void Form_Forget_Password_Load(object sender, EventArgs e)
        {

        }
    }
}
