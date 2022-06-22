namespace EntityFramework_Version.View_Layer
{
    partial class Form_Buy
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
            this.cmbBookID = new System.Windows.Forms.ComboBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbCustomerID = new System.Windows.Forms.ComboBox();
            this.NgayMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBuy = new System.Windows.Forms.DataGridView();
            this.GiaMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuy)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(120, 301);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(89, 32);
            this.btnReload.TabIndex = 18;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // cmbBookID
            // 
            this.cmbBookID.FormattingEnabled = true;
            this.cmbBookID.Location = new System.Drawing.Point(137, 108);
            this.cmbBookID.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBookID.Name = "cmbBookID";
            this.cmbBookID.Size = new System.Drawing.Size(73, 21);
            this.cmbBookID.TabIndex = 25;
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.Location = new System.Drawing.Point(61, 226);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(89, 32);
            this.btnBuy.TabIndex = 24;
            this.btnBuy.Text = "Mua";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 67);
            this.panel1.TabIndex = 19;
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(535, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mua Sách";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(12, 301);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 32);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbCustomerID
            // 
            this.cmbCustomerID.FormattingEnabled = true;
            this.cmbCustomerID.Location = new System.Drawing.Point(137, 163);
            this.cmbCustomerID.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCustomerID.Name = "cmbCustomerID";
            this.cmbCustomerID.Size = new System.Drawing.Size(73, 21);
            this.cmbCustomerID.TabIndex = 26;
            // 
            // NgayMua
            // 
            this.NgayMua.DataPropertyName = "NgayMua";
            this.NgayMua.HeaderText = "Ngày Mua";
            this.NgayMua.MinimumWidth = 6;
            this.NgayMua.Name = "NgayMua";
            this.NgayMua.ReadOnly = true;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên Khách Hàng";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã Khách Hàng";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            // 
            // TuaSach
            // 
            this.TuaSach.DataPropertyName = "TuaSach";
            this.TuaSach.HeaderText = "Tựa Sách";
            this.TuaSach.MinimumWidth = 6;
            this.TuaSach.Name = "TuaSach";
            this.TuaSach.ReadOnly = true;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // dgvBuy
            // 
            this.dgvBuy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCuon,
            this.TuaSach,
            this.MaKH,
            this.TenKH,
            this.GiaMua,
            this.NgayMua});
            this.dgvBuy.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvBuy.Location = new System.Drawing.Point(215, 67);
            this.dgvBuy.Name = "dgvBuy";
            this.dgvBuy.ReadOnly = true;
            this.dgvBuy.RowHeadersWidth = 51;
            this.dgvBuy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuy.Size = new System.Drawing.Size(829, 431);
            this.dgvBuy.TabIndex = 20;
            this.dgvBuy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuy_CellContentClick);
            // 
            // GiaMua
            // 
            this.GiaMua.DataPropertyName = "GiaMua";
            this.GiaMua.HeaderText = "Đơn Giá";
            this.GiaMua.MinimumWidth = 6;
            this.GiaMua.Name = "GiaMua";
            this.GiaMua.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Mã Cuốn";
            // 
            // Form_Buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 498);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.cmbBookID);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbCustomerID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvBuy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Buy";
            this.Text = "Form_Buy";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.ComboBox cmbBookID;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCuon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaMua;
        private System.Windows.Forms.Label label3;
    }
}