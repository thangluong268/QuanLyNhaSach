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
    public partial class Form_Find_Book : Form
    {
        Find_Book find_book = new Find_Book();

        void Load_Data ()
        {
            try
            {
                dgvFindBook.DataSource = find_book.Lay_TT_Sach();
                dgvFindBook.AutoResizeColumns();
                this.txtBookName.ResetText();
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu");
            }
        }

        void Find_book()
        {
            string tua_sach = txtBookName.Text.Trim();
            try
            {
                dgvFindBook.DataSource = find_book.Tim_Sach(tua_sach);
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu");
            }
        }
        public Form_Find_Book()
        {
            InitializeComponent();
            Load_Data();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Find_book();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            Load_Data();
        }
    }
}
