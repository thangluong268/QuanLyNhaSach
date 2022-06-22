using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_Version.View_layer
{
    public partial class Form_Home : Form
    {
        public Form_Home()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_Guest_Click(object sender, EventArgs e)
        {
            Form fmGuset = new Form_Find_Book();
            fmGuset.ShowDialog();
        }

        private void btn_Internal_Click(object sender, EventArgs e)
        {
            Form fmInternal = new Form_Login();
            fmInternal.ShowDialog();
        }

        private void Form_Home_Load(object sender, EventArgs e)
        {

        }
    }
}
