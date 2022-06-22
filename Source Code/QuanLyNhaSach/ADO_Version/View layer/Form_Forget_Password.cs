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
    public partial class Form_Forget_Password : Form
    {
        DataTable dtForgetPass = null;
        BLForgetPassword dbForgetPass = new BLForgetPassword();

        List<string> Info = new List<string>();
        public Form_Forget_Password()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Forget_Password_Load(object sender, EventArgs e)
        {

        }

        private void btnFindPass_Click(object sender, EventArgs e)
        {
            dtForgetPass = new DataTable();
            dtForgetPass.Clear();

            DataSet ds = dbForgetPass.LayThongTin(this.txtStaffID.Text, this.txtFullName.Text, this.txtPhone.Text);
            dtForgetPass = ds.Tables[0];

            Info.Clear();
            for (int i = 0; i < dtForgetPass.Rows.Count; i++)
            {
                for (int j = 0; j < dtForgetPass.Columns.Count; j++)
                {
                    object o = dtForgetPass.Rows[i].ItemArray[j];
                    string s = (string)(o = dtForgetPass.Rows[i].ItemArray[j].ToString());
                    Info.Add(s);
                }
            }

            if (Info.Count > 0)
            {
                this.lblStaffID.Text = Info[0];
                this.lblUserName.Text = Info[1];
                this.lblPassword.Text = Info[2];

            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtStaffID.ResetText();
            this.txtFullName.ResetText();
            this.txtPhone.ResetText();
            this.lblStaffID.ResetText();
            this.lblUserName.ResetText();
            this.lblPassword.ResetText();
        }
    }
}
