namespace Vintage
{
    partial class frmDangNhap
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
            VINTAGE = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            panel1 = new Panel();
            button2 = new Button();
            bthHuyBo = new Button();
            label1 = new Label();
            chboxMK = new CheckBox();
            pictureBox1 = new PictureBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // VINTAGE
            // 
            VINTAGE.AutoSize = true;
            VINTAGE.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold);
            VINTAGE.ForeColor = Color.FromArgb(128, 64, 0);
            VINTAGE.Location = new Point(76, 29);
            VINTAGE.Name = "VINTAGE";
            VINTAGE.Size = new Size(199, 86);
            VINTAGE.TabIndex = 0;
            VINTAGE.Text = "1980s";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.ForeColor = Color.FromArgb(128, 64, 0);
            label3.Location = new Point(28, 170);
            label3.Name = "label3";
            label3.Size = new Size(133, 25);
            label3.TabIndex = 2;
            label3.Text = "Tên đăng nhập:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.ForeColor = Color.FromArgb(128, 64, 0);
            label4.Location = new Point(28, 229);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 3;
            label4.Text = "Mật khẩu:";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BorderStyle = BorderStyle.FixedSingle;
            txtTenDangNhap.ForeColor = Color.Black;
            txtTenDangNhap.Location = new Point(28, 198);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(283, 23);
            txtTenDangNhap.TabIndex = 4;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.ForeColor = Color.Black;
            txtMatKhau.Location = new Point(28, 257);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(283, 23);
            txtMatKhau.TabIndex = 5;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(128, 64, 0);
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(28, 343);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(283, 44);
            btnDangNhap.TabIndex = 6;
            btnDangNhap.Text = "ĐĂNG NHẬP";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(bthHuyBo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(chboxMK);
            panel1.Controls.Add(btnDangNhap);
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(VINTAGE);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtTenDangNhap);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(322, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 492);
            panel1.TabIndex = 13;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(128, 64, 0);
            button2.Location = new Point(173, 403);
            button2.Name = "button2";
            button2.Size = new Size(138, 30);
            button2.TabIndex = 10;
            button2.Text = "THOÁT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // bthHuyBo
            // 
            bthHuyBo.BackColor = Color.White;
            bthHuyBo.FlatStyle = FlatStyle.Flat;
            bthHuyBo.ForeColor = Color.FromArgb(128, 64, 0);
            bthHuyBo.Location = new Point(29, 403);
            bthHuyBo.Name = "bthHuyBo";
            bthHuyBo.Size = new Size(138, 30);
            bthHuyBo.TabIndex = 9;
            bthHuyBo.Text = "HUỶ BỎ";
            bthHuyBo.UseVisualStyleBackColor = false;
            bthHuyBo.Click += bthHuyBo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(100, 105);
            label1.Name = "label1";
            label1.Size = new Size(139, 21);
            label1.TabIndex = 8;
            label1.Text = "Thời trang Vintage";
            // 
            // chboxMK
            // 
            chboxMK.AutoSize = true;
            chboxMK.BackColor = SystemColors.Window;
            chboxMK.ForeColor = Color.Black;
            chboxMK.Location = new Point(28, 295);
            chboxMK.Name = "chboxMK";
            chboxMK.Size = new Size(104, 19);
            chboxMK.TabIndex = 7;
            chboxMK.Text = "Hiện mật khẩu";
            chboxMK.UseVisualStyleBackColor = false;
            chboxMK.CheckedChanged += chboxMK_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.banner;
            pictureBox1.Location = new Point(-6, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(993, 670);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += frmDangNhap_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label VINTAGE;
        private Label label3;
        private Label label4;
        private Button btnDangNhap;
        public TextBox txtTenDangNhap;
        public TextBox txtMatKhau;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private CheckBox chboxMK;
        private Label label1;
        private Button button2;
        private Button bthHuyBo;
    }
}