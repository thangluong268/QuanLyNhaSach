using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework_Version.View_Layer
{
    public partial class Form_Staff : Form
    {
        public Form_Staff()
        {
            InitializeComponent();
        }
        public Form_Staff(string user)
        {
            InitializeComponent();
            lbNV.Text = user;
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

        private void btnPay_Borrow_Click(object sender, EventArgs e)
        {
            Form_Borrow_Pay fmBorrowPay = new Form_Borrow_Pay();
            fmBorrowPay.ShowDialog();
        }

        private void btnPay_Buy_Click(object sender, EventArgs e)
        {
            Form_Buy_Pay fmBuyPay = new Form_Buy_Pay();
            fmBuyPay.ShowDialog();
        }
    }
}
