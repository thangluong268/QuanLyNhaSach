namespace ADO_Version.View_layer
{
    partial class Form_Login
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.ptbPassvisible1 = new System.Windows.Forms.PictureBox();
            this.ptbPassinvisible1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rbManager = new System.Windows.Forms.RadioButton();
            this.rbStaff = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnForgetPass = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPassvisible1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPassinvisible1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.DimGray;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.DarkGray;
            this.txtUsername.Location = new System.Drawing.Point(320, 236);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(299, 45);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.Text = "User Name";
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.DimGray;
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.Location = new System.Drawing.Point(320, 289);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(299, 45);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "Password";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::ADO_Version.Properties.Resources.backcolorlogin;
            this.pictureBox6.Image = global::ADO_Version.Properties.Resources.icons8_user_64__1_;
            this.pictureBox6.Location = new System.Drawing.Point(380, 62);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(177, 153);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 101;
            this.pictureBox6.TabStop = false;
            // 
            // ptbPassvisible1
            // 
            this.ptbPassvisible1.BackgroundImage = global::ADO_Version.Properties.Resources.backcolorlogin;
            this.ptbPassvisible1.Image = global::ADO_Version.Properties.Resources.icons8_eye_64;
            this.ptbPassvisible1.Location = new System.Drawing.Point(577, 287);
            this.ptbPassvisible1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbPassvisible1.Name = "ptbPassvisible1";
            this.ptbPassvisible1.Size = new System.Drawing.Size(43, 46);
            this.ptbPassvisible1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPassvisible1.TabIndex = 100;
            this.ptbPassvisible1.TabStop = false;
            this.ptbPassvisible1.Click += new System.EventHandler(this.ptbPassvisible1_Click);
            // 
            // ptbPassinvisible1
            // 
            this.ptbPassinvisible1.BackgroundImage = global::ADO_Version.Properties.Resources.backcolorlogin;
            this.ptbPassinvisible1.Image = global::ADO_Version.Properties.Resources.icons8_invisible_64;
            this.ptbPassinvisible1.Location = new System.Drawing.Point(576, 289);
            this.ptbPassinvisible1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbPassinvisible1.Name = "ptbPassinvisible1";
            this.ptbPassinvisible1.Size = new System.Drawing.Size(43, 46);
            this.ptbPassinvisible1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPassinvisible1.TabIndex = 99;
            this.ptbPassinvisible1.TabStop = false;
            this.ptbPassinvisible1.Click += new System.EventHandler(this.ptbPassinvisible1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::ADO_Version.Properties.Resources.backcolorlogin;
            this.pictureBox3.Image = global::ADO_Version.Properties.Resources.icons8_password_64;
            this.pictureBox3.Location = new System.Drawing.Point(227, 287);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 98;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ADO_Version.Properties.Resources.backcolorlogin;
            this.pictureBox2.Image = global::ADO_Version.Properties.Resources.icons8_user_64;
            this.pictureBox2.Location = new System.Drawing.Point(227, 236);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 97;
            this.pictureBox2.TabStop = false;
            // 
            // rbManager
            // 
            this.rbManager.AutoSize = true;
            this.rbManager.BackgroundImage = global::ADO_Version.Properties.Resources.backcolorlogin;
            this.rbManager.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbManager.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbManager.Location = new System.Drawing.Point(515, 366);
            this.rbManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbManager.Name = "rbManager";
            this.rbManager.Size = new System.Drawing.Size(105, 27);
            this.rbManager.TabIndex = 59;
            this.rbManager.TabStop = true;
            this.rbManager.Text = "Quản Lý";
            this.rbManager.UseVisualStyleBackColor = true;
            // 
            // rbStaff
            // 
            this.rbStaff.AutoSize = true;
            this.rbStaff.BackgroundImage = global::ADO_Version.Properties.Resources.backcolorlogin;
            this.rbStaff.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStaff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbStaff.Location = new System.Drawing.Point(267, 366);
            this.rbStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbStaff.Name = "rbStaff";
            this.rbStaff.Size = new System.Drawing.Size(117, 27);
            this.rbStaff.TabIndex = 58;
            this.rbStaff.TabStop = true;
            this.rbStaff.Text = "Nhân Viên";
            this.rbStaff.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = global::ADO_Version.Properties.Resources.backcolorlogin;
            this.label4.Location = new System.Drawing.Point(385, 337);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 44);
            this.label4.TabIndex = 96;
            this.label4.Text = "                               ";
            // 
            // btn_Back
            // 
            this.btn_Back.BackgroundImage = global::ADO_Version.Properties.Resources.backcolorlogin;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Back.Location = new System.Drawing.Point(757, 574);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(149, 48);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImage = global::ADO_Version.Properties.Resources.backcolorlogin;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(380, 446);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(177, 48);
            this.btnLogin.TabIndex = 61;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnForgetPass
            // 
            this.btnForgetPass.BackgroundImage = global::ADO_Version.Properties.Resources.backcolorlogin;
            this.btnForgetPass.FlatAppearance.BorderSize = 0;
            this.btnForgetPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForgetPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgetPass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnForgetPass.Location = new System.Drawing.Point(380, 545);
            this.btnForgetPass.Margin = new System.Windows.Forms.Padding(4);
            this.btnForgetPass.Name = "btnForgetPass";
            this.btnForgetPass.Size = new System.Drawing.Size(177, 48);
            this.btnForgetPass.TabIndex = 8;
            this.btnForgetPass.Text = "Quên mật khẩu";
            this.btnForgetPass.UseVisualStyleBackColor = true;
            this.btnForgetPass.Click += new System.EventHandler(this.btnForgetPass_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ADO_Version.Properties.Resources.Login_Page;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(960, 665);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 654);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.ptbPassvisible1);
            this.Controls.Add(this.ptbPassinvisible1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.rbManager);
            this.Controls.Add(this.rbStaff);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnForgetPass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPassvisible1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPassinvisible1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnForgetPass;
        private System.Windows.Forms.RadioButton rbStaff;
        private System.Windows.Forms.RadioButton rbManager;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox ptbPassinvisible1;
        private System.Windows.Forms.PictureBox ptbPassvisible1;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}