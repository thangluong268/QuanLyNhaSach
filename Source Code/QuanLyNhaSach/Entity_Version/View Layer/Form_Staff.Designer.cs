namespace EntityFramework_Version.View_Layer
{
    partial class Form_Staff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbNV = new System.Windows.Forms.Label();
            this.btnPay_Borrow = new System.Windows.Forms.Button();
            this.btnQLKH = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnFindBook = new System.Windows.Forms.Button();
            this.btnPay_Buy = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.lbNV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 8;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(57, 31);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 32);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbNV
            // 
            this.lbNV.AutoSize = true;
            this.lbNV.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNV.Location = new System.Drawing.Point(331, 28);
            this.lbNV.Name = "lbNV";
            this.lbNV.Size = new System.Drawing.Size(138, 31);
            this.lbNV.TabIndex = 0;
            this.lbNV.Text = "Nhân Viên";
            // 
            // btnPay_Borrow
            // 
            this.btnPay_Borrow.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay_Borrow.Location = new System.Drawing.Point(620, 199);
            this.btnPay_Borrow.Name = "btnPay_Borrow";
            this.btnPay_Borrow.Size = new System.Drawing.Size(136, 75);
            this.btnPay_Borrow.TabIndex = 13;
            this.btnPay_Borrow.Text = "Thanh Toán Mượn";
            this.btnPay_Borrow.UseVisualStyleBackColor = true;
            this.btnPay_Borrow.Click += new System.EventHandler(this.btnPay_Borrow_Click);
            // 
            // btnQLKH
            // 
            this.btnQLKH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKH.Location = new System.Drawing.Point(370, 199);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Size = new System.Drawing.Size(136, 75);
            this.btnQLKH.TabIndex = 12;
            this.btnQLKH.Text = "Quản Lý Khách Hàng";
            this.btnQLKH.UseVisualStyleBackColor = true;
            this.btnQLKH.Click += new System.EventHandler(this.btnQLKH_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.Location = new System.Drawing.Point(57, 339);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(136, 75);
            this.btnBuy.TabIndex = 11;
            this.btnBuy.Text = "Mua Sách";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrow.Location = new System.Drawing.Point(370, 339);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(136, 75);
            this.btnBorrow.TabIndex = 10;
            this.btnBorrow.Text = "Mượn, Trả Sách";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnFindBook
            // 
            this.btnFindBook.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindBook.Location = new System.Drawing.Point(57, 199);
            this.btnFindBook.Name = "btnFindBook";
            this.btnFindBook.Size = new System.Drawing.Size(136, 75);
            this.btnFindBook.TabIndex = 9;
            this.btnFindBook.Text = "Tìm Sách";
            this.btnFindBook.UseVisualStyleBackColor = true;
            this.btnFindBook.Click += new System.EventHandler(this.btnFindBook_Click);
            // 
            // btnPay_Buy
            // 
            this.btnPay_Buy.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay_Buy.Location = new System.Drawing.Point(620, 339);
            this.btnPay_Buy.Name = "btnPay_Buy";
            this.btnPay_Buy.Size = new System.Drawing.Size(136, 75);
            this.btnPay_Buy.TabIndex = 14;
            this.btnPay_Buy.Text = "Thanh Toán Mua";
            this.btnPay_Buy.UseVisualStyleBackColor = true;
            this.btnPay_Buy.Click += new System.EventHandler(this.btnPay_Buy_Click);
            // 
            // Form_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPay_Buy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPay_Borrow);
            this.Controls.Add(this.btnQLKH);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.btnFindBook);
            this.Name = "Form_Staff";
            this.Text = "Employee";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbNV;
        private System.Windows.Forms.Button btnPay_Borrow;
        private System.Windows.Forms.Button btnQLKH;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnFindBook;
        private System.Windows.Forms.Button btnPay_Buy;
    }
}