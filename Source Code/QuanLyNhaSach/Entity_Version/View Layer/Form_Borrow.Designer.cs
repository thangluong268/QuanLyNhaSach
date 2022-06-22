namespace EntityFramework_Version.View_Layer
{
    partial class Form_Borrow
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
            this.btnReload = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.cmbBookID = new System.Windows.Forms.ComboBox();
            this.cmbCustomerID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvMuon = new System.Windows.Forms.DataGridView();
            this.MaCuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DangMuon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DaThanhToan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(78, 388);
            this.btnReload.Margin = new System.Windows.Forms.Padding(2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(89, 32);
            this.btnReload.TabIndex = 23;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrow.Location = new System.Drawing.Point(20, 288);
            this.btnBorrow.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(89, 32);
            this.btnBorrow.TabIndex = 21;
            this.btnBorrow.Text = "Mượn Sách";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // cmbBookID
            // 
            this.cmbBookID.FormattingEnabled = true;
            this.cmbBookID.Location = new System.Drawing.Point(142, 155);
            this.cmbBookID.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBookID.Name = "cmbBookID";
            this.cmbBookID.Size = new System.Drawing.Size(122, 21);
            this.cmbBookID.TabIndex = 20;
            // 
            // cmbCustomerID
            // 
            this.cmbCustomerID.FormattingEnabled = true;
            this.cmbCustomerID.Location = new System.Drawing.Point(142, 204);
            this.cmbCustomerID.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCustomerID.Name = "cmbCustomerID";
            this.cmbCustomerID.Size = new System.Drawing.Size(122, 21);
            this.cmbCustomerID.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mã Cuốn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(154, 288);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(89, 32);
            this.btnReturn.TabIndex = 22;
            this.btnReturn.Text = "Trả Sách";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(127, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 32);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(548, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mượn Sách";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 67);
            this.panel1.TabIndex = 15;
            // 
            // dgvMuon
            // 
            this.dgvMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCuon,
            this.MaKH,
            this.TenKH,
            this.GiaMuon,
            this.NgayMuon,
            this.HanTra,
            this.NgayTra,
            this.TienPhat,
            this.DangMuon,
            this.DaThanhToan});
            this.dgvMuon.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvMuon.Location = new System.Drawing.Point(292, 67);
            this.dgvMuon.Name = "dgvMuon";
            this.dgvMuon.ReadOnly = true;
            this.dgvMuon.RowHeadersWidth = 51;
            this.dgvMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMuon.Size = new System.Drawing.Size(862, 458);
            this.dgvMuon.TabIndex = 16;
            this.dgvMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMuon_CellClick);
            // 
            // MaCuon
            // 
            this.MaCuon.DataPropertyName = "MaCuon";
            this.MaCuon.HeaderText = "Mã Cuốn";
            this.MaCuon.MinimumWidth = 6;
            this.MaCuon.Name = "MaCuon";
            this.MaCuon.ReadOnly = true;
            this.MaCuon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã Khách Hàng";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên KH";
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            // 
            // GiaMuon
            // 
            this.GiaMuon.DataPropertyName = "GiaMuon";
            this.GiaMuon.HeaderText = "Giá Mượn";
            this.GiaMuon.Name = "GiaMuon";
            this.GiaMuon.ReadOnly = true;
            // 
            // NgayMuon
            // 
            this.NgayMuon.DataPropertyName = "NgayMuon";
            this.NgayMuon.HeaderText = "Ngày Mượn";
            this.NgayMuon.MinimumWidth = 6;
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.ReadOnly = true;
            // 
            // HanTra
            // 
            this.HanTra.DataPropertyName = "HanTra";
            this.HanTra.HeaderText = "Hạn Trả";
            this.HanTra.MinimumWidth = 6;
            this.HanTra.Name = "HanTra";
            this.HanTra.ReadOnly = true;
            // 
            // NgayTra
            // 
            this.NgayTra.DataPropertyName = "NgayTra";
            this.NgayTra.HeaderText = "Ngày Trả";
            this.NgayTra.MinimumWidth = 6;
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.ReadOnly = true;
            // 
            // TienPhat
            // 
            this.TienPhat.DataPropertyName = "TienPhat";
            this.TienPhat.HeaderText = "Tiền Phạt";
            this.TienPhat.MinimumWidth = 6;
            this.TienPhat.Name = "TienPhat";
            this.TienPhat.ReadOnly = true;
            // 
            // DangMuon
            // 
            this.DangMuon.DataPropertyName = "DangMuon";
            this.DangMuon.HeaderText = "Đang Mượn";
            this.DangMuon.MinimumWidth = 6;
            this.DangMuon.Name = "DangMuon";
            this.DangMuon.ReadOnly = true;
            this.DangMuon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DangMuon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DaThanhToan
            // 
            this.DaThanhToan.DataPropertyName = "DaThanhToan";
            this.DaThanhToan.HeaderText = "Đã Thanh Toán";
            this.DaThanhToan.MinimumWidth = 6;
            this.DaThanhToan.Name = "DaThanhToan";
            this.DaThanhToan.ReadOnly = true;
            this.DaThanhToan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DaThanhToan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Form_Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 525);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.cmbBookID);
            this.Controls.Add(this.cmbCustomerID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dgvMuon);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Borrow";
            this.Text = "Form_Buy_Borrow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.ComboBox cmbBookID;
        private System.Windows.Forms.ComboBox cmbCustomerID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienPhat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DangMuon;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DaThanhToan;
    }
}