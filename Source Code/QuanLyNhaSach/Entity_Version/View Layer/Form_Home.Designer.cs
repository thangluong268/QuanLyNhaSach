namespace EntityFramework_Version.View_Layer
{
    partial class Form_Home
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
            this.btn_Internal = new System.Windows.Forms.Button();
            this.btn_Guest = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Home_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Internal
            // 
            this.btn_Internal.BackColor = System.Drawing.Color.Transparent;
            this.btn_Internal.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Internal.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Internal.Location = new System.Drawing.Point(572, 419);
            this.btn_Internal.Name = "btn_Internal";
            this.btn_Internal.Size = new System.Drawing.Size(89, 32);
            this.btn_Internal.TabIndex = 10;
            this.btn_Internal.Text = "Đăng Nhập";
            this.btn_Internal.UseVisualStyleBackColor = false;
            this.btn_Internal.Click += new System.EventHandler(this.btn_Internal_Click);
            // 
            // btn_Guest
            // 
            this.btn_Guest.BackColor = System.Drawing.Color.Transparent;
            this.btn_Guest.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guest.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Guest.Location = new System.Drawing.Point(317, 419);
            this.btn_Guest.Name = "btn_Guest";
            this.btn_Guest.Size = new System.Drawing.Size(89, 32);
            this.btn_Guest.TabIndex = 9;
            this.btn_Guest.Text = "Khách";
            this.btn_Guest.UseVisualStyleBackColor = false;
            this.btn_Guest.Click += new System.EventHandler(this.btn_Guest_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_close.Location = new System.Drawing.Point(821, 21);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(89, 32);
            this.btn_close.TabIndex = 8;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(818, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Địa chỉ: 01 Võ Văn Ngân";
            // 
            // Home_title
            // 
            this.Home_title.AutoSize = true;
            this.Home_title.BackColor = System.Drawing.Color.Transparent;
            this.Home_title.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_title.ForeColor = System.Drawing.Color.White;
            this.Home_title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Home_title.Location = new System.Drawing.Point(310, 9);
            this.Home_title.Name = "Home_title";
            this.Home_title.Size = new System.Drawing.Size(386, 43);
            this.Home_title.TabIndex = 6;
            this.Home_title.Text = "Nhà Sách Thành Công";
            this.Home_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EntityFramework_Version.Properties.Resources.store_book;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 517);
            this.Controls.Add(this.btn_Internal);
            this.Controls.Add(this.btn_Guest);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Home_title);
            this.Name = "Form_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Internal;
        private System.Windows.Forms.Button btn_Guest;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Home_title;
    }
}

