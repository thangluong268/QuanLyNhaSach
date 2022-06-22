namespace EntityFramework_Version.View_Layer
{
    partial class Form_Thong_Ke_Doanh_Thu
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
            this.label7 = new System.Windows.Forms.Label();
            this.rbThang = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.txtThongKe_Ban = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_ThongKeDauSach = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_ThongKeLoiNhuan = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ThongKe_Phat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThongKe_Muon = new System.Windows.Forms.TextBox();
            this.dtNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKeDauSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKeLoiNhuan)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(369, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 19);
            this.label7.TabIndex = 35;
            this.label7.Text = "Thực hiện từ ngày";
            // 
            // rbThang
            // 
            this.rbThang.AutoSize = true;
            this.rbThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThang.Location = new System.Drawing.Point(662, 165);
            this.rbThang.Name = "rbThang";
            this.rbThang.Size = new System.Drawing.Size(164, 23);
            this.rbThang.TabIndex = 41;
            this.rbThang.TabStop = true;
            this.rbThang.Text = "Thống kê theo tháng";
            this.rbThang.UseVisualStyleBackColor = true;
            this.rbThang.CheckedChanged += new System.EventHandler(this.rbThang_CheckedChanged);
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNam.Location = new System.Drawing.Point(512, 165);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(155, 23);
            this.rbNam.TabIndex = 40;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Thông kê theo năm";
            this.rbNam.UseVisualStyleBackColor = true;
            this.rbNam.CheckedChanged += new System.EventHandler(this.rbNam_CheckedChanged);
            // 
            // txtThongKe_Ban
            // 
            this.txtThongKe_Ban.Location = new System.Drawing.Point(299, 213);
            this.txtThongKe_Ban.Name = "txtThongKe_Ban";
            this.txtThongKe_Ban.Size = new System.Drawing.Size(100, 20);
            this.txtThongKe_Ban.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.dgv_ThongKeDauSach);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(346, 423);
            this.panel3.TabIndex = 39;
            // 
            // dgv_ThongKeDauSach
            // 
            this.dgv_ThongKeDauSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongKeDauSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TuaSach,
            this.SoLuong});
            this.dgv_ThongKeDauSach.Location = new System.Drawing.Point(3, 53);
            this.dgv_ThongKeDauSach.Name = "dgv_ThongKeDauSach";
            this.dgv_ThongKeDauSach.ReadOnly = true;
            this.dgv_ThongKeDauSach.RowHeadersWidth = 51;
            this.dgv_ThongKeDauSach.Size = new System.Drawing.Size(324, 225);
            this.dgv_ThongKeDauSach.TabIndex = 25;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã Sach";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            this.MaSach.Width = 125;
            // 
            // TuaSach
            // 
            this.TuaSach.DataPropertyName = "TuaSach";
            this.TuaSach.HeaderText = "Tựa Sách";
            this.TuaSach.MinimumWidth = 6;
            this.TuaSach.Name = "TuaSach";
            this.TuaSach.ReadOnly = true;
            this.TuaSach.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Số tiền nhận được từ việc bán sách";
            // 
            // dgv_ThongKeLoiNhuan
            // 
            this.dgv_ThongKeLoiNhuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongKeLoiNhuan.Location = new System.Drawing.Point(373, 293);
            this.dgv_ThongKeLoiNhuan.Name = "dgv_ThongKeLoiNhuan";
            this.dgv_ThongKeLoiNhuan.RowHeadersWidth = 51;
            this.dgv_ThongKeLoiNhuan.Size = new System.Drawing.Size(456, 159);
            this.dgv_ThongKeLoiNhuan.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtThongKe_Ban);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtTongTien);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_ThongKe_Phat);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtThongKe_Muon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(834, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 423);
            this.panel2.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(136, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tổng số tiền thu được";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(299, 353);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(100, 20);
            this.txtTongTien.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Số tiền nhận được từ việc cho mượn sách";
            // 
            // txt_ThongKe_Phat
            // 
            this.txt_ThongKe_Phat.Location = new System.Drawing.Point(299, 300);
            this.txt_ThongKe_Phat.Name = "txt_ThongKe_Phat";
            this.txt_ThongKe_Phat.Size = new System.Drawing.Size(100, 20);
            this.txt_ThongKe_Phat.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Số tiền nhận được từ việc nộp phạt";
            // 
            // txtThongKe_Muon
            // 
            this.txtThongKe_Muon.Location = new System.Drawing.Point(299, 251);
            this.txtThongKe_Muon.Name = "txtThongKe_Muon";
            this.txtThongKe_Muon.Size = new System.Drawing.Size(100, 20);
            this.txtThongKe_Muon.TabIndex = 20;
            // 
            // dtNgayBatDau
            // 
            this.dtNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayBatDau.Location = new System.Drawing.Point(384, 169);
            this.dtNgayBatDau.Name = "dtNgayBatDau";
            this.dtNgayBatDau.Size = new System.Drawing.Size(105, 20);
            this.dtNgayBatDau.TabIndex = 43;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(554, 236);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(89, 32);
            this.btnThongKe.TabIndex = 34;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(123, 39);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 32);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống Kê Doanh Thu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 19);
            this.label6.TabIndex = 36;
            this.label6.Text = "Số Lượng sách còn lại trên mỗi đầu sách";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 100);
            this.panel1.TabIndex = 33;
            // 
            // Form_Thong_Ke_Doanh_Thu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 523);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rbThang);
            this.Controls.Add(this.rbNam);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgv_ThongKeLoiNhuan);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtNgayBatDau);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Thong_Ke_Doanh_Thu";
            this.Text = "Thong_Ke_Doanh_Thu";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKeDauSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKeLoiNhuan)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbThang;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.TextBox txtThongKe_Ban;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_ThongKeDauSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_ThongKeLoiNhuan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ThongKe_Phat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtThongKe_Muon;
        private System.Windows.Forms.DateTimePicker dtNgayBatDau;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}