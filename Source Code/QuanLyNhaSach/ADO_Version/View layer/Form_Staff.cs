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
    public partial class Form_Staff : Form
    {
        public Form_Staff()
        {
            InitializeComponent();
        }

        private void btnFindBook_Click(object sender, EventArgs e)
        {
            Form fmFindBook = new Form_Find_Book();
            fmFindBook.ShowDialog();
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            Form fmQLKH = new Form_Customer();
            fmQLKH.ShowDialog();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            Form fmBuy = new Form_Buy();
            fmBuy.ShowDialog();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            Form fmBorrow = new Form_Borrow();
            fmBorrow.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Form_Employee_Load(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Form form = new Form_Buy_Pay();
            form.ShowDialog();
        }

        private void Form_Staff_Load(object sender, EventArgs e)
        {

        }

        private void btnBorrowPay_Click(object sender, EventArgs e)
        {
            Form form = new Form_Borrow_Pay();
            form.ShowDialog();
        }
    }
}
