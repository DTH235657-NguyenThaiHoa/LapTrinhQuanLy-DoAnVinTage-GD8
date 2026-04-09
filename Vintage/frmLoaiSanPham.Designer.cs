namespace Vintage
{
    partial class frmLoaiSanPham
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
            groupBox1 = new GroupBox();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTenLoai = new TextBox();
            label1 = new Label();
            btnXuat = new Button();
            btnNhap = new Button();
            panel1 = new Panel();
            label7 = new Label();
            btnHoaDon = new Button();
            btnNhanVien = new Button();
            btnKhachHang = new Button();
            btnSanPham = new Button();
            btnHangSanXuat = new Button();
            btnLoaiSanPham = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            TenLoai = new DataGridViewTextBoxColumn();
            dataGridView = new DataGridView();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtTenLoai);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.FromArgb(128, 64, 0);
            groupBox1.Location = new Point(307, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(659, 151);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin loại sản phẩm";
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.White;
            btnHuyBo.FlatStyle = FlatStyle.Flat;
            btnHuyBo.ForeColor = Color.Black;
            btnHuyBo.Location = new Point(545, 92);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(103, 27);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "Huỷ bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.White;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(436, 92);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(103, 27);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.White;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(252, 92);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(103, 27);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "❌ Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.White;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.FromArgb(128, 64, 0);
            btnSua.Location = new Point(143, 92);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(103, 27);
            btnSua.TabIndex = 3;
            btnSua.Text = "🖊️Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.White;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.FromArgb(128, 64, 0);
            btnThem.Location = new Point(34, 92);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(103, 27);
            btnThem.TabIndex = 2;
            btnThem.Text = "➕Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenLoai
            // 
            txtTenLoai.Location = new Point(194, 37);
            txtTenLoai.Name = "txtTenLoai";
            txtTenLoai.Size = new Size(360, 23);
            txtTenLoai.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(48, 40);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên loại sản phẩm (*):";
            // 
            // btnXuat
            // 
            btnXuat.FlatStyle = FlatStyle.Flat;
            btnXuat.ForeColor = Color.Green;
            btnXuat.Location = new Point(846, 511);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(121, 27);
            btnXuat.TabIndex = 8;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.FlatStyle = FlatStyle.Flat;
            btnNhap.ForeColor = Color.FromArgb(0, 64, 0);
            btnNhap.Location = new Point(709, 511);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(121, 27);
            btnNhap.TabIndex = 9;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 64, 0);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnHoaDon);
            panel1.Controls.Add(btnNhanVien);
            panel1.Controls.Add(btnKhachHang);
            panel1.Controls.Add(btnSanPham);
            panel1.Controls.Add(btnHangSanXuat);
            panel1.Controls.Add(btnLoaiSanPham);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 560);
            panel1.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.System;
            label7.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(37, 51);
            label7.Name = "label7";
            label7.Size = new Size(199, 30);
            label7.TabIndex = 17;
            label7.Text = "Thời trang Vintage";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnHoaDon
            // 
            btnHoaDon.BackColor = Color.Snow;
            btnHoaDon.FlatStyle = FlatStyle.Flat;
            btnHoaDon.Font = new Font("Segoe UI", 12F);
            btnHoaDon.Location = new Point(37, 453);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(215, 43);
            btnHoaDon.TabIndex = 12;
            btnHoaDon.Text = "\U0001f9fe Hoá đơn";
            btnHoaDon.UseVisualStyleBackColor = false;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = Color.Snow;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Font = new Font("Segoe UI", 12F);
            btnNhanVien.Location = new Point(37, 390);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(215, 43);
            btnNhanVien.TabIndex = 11;
            btnNhanVien.Text = "\U0001f9d1‍ Nhân viên";
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.BackColor = Color.Snow;
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Font = new Font("Segoe UI", 12F);
            btnKhachHang.Location = new Point(37, 327);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(215, 43);
            btnKhachHang.TabIndex = 10;
            btnKhachHang.Text = "\U0001f9d1‍\U0001f91d‍\U0001f9d1 Khách hàng";
            btnKhachHang.UseVisualStyleBackColor = false;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnSanPham
            // 
            btnSanPham.BackColor = Color.Snow;
            btnSanPham.FlatStyle = FlatStyle.Flat;
            btnSanPham.Font = new Font("Segoe UI", 12F);
            btnSanPham.Location = new Point(37, 266);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Size = new Size(215, 43);
            btnSanPham.TabIndex = 9;
            btnSanPham.Text = "👕 Sản phẩm";
            btnSanPham.UseVisualStyleBackColor = false;
            btnSanPham.Click += btnSanPham_Click;
            // 
            // btnHangSanXuat
            // 
            btnHangSanXuat.BackColor = Color.Snow;
            btnHangSanXuat.FlatStyle = FlatStyle.Flat;
            btnHangSanXuat.Font = new Font("Segoe UI", 12F);
            btnHangSanXuat.Location = new Point(37, 205);
            btnHangSanXuat.Name = "btnHangSanXuat";
            btnHangSanXuat.Size = new Size(215, 43);
            btnHangSanXuat.TabIndex = 8;
            btnHangSanXuat.Text = "🏭 Nhà cung cấp";
            btnHangSanXuat.UseVisualStyleBackColor = false;
            btnHangSanXuat.Click += btnHangSanXuat_Click;
            // 
            // btnLoaiSanPham
            // 
            btnLoaiSanPham.BackColor = Color.Snow;
            btnLoaiSanPham.FlatStyle = FlatStyle.Flat;
            btnLoaiSanPham.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLoaiSanPham.ForeColor = Color.FromArgb(128, 64, 0);
            btnLoaiSanPham.Location = new Point(37, 142);
            btnLoaiSanPham.Name = "btnLoaiSanPham";
            btnLoaiSanPham.Size = new Size(215, 43);
            btnLoaiSanPham.TabIndex = 7;
            btnLoaiSanPham.Text = "🏷️ Loại sản phẩm";
            btnLoaiSanPham.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.banner;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 557);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(307, 29);
            label2.Name = "label2";
            label2.Size = new Size(264, 45);
            label2.TabIndex = 14;
            label2.Text = "LOẠI SẢN PHẨM";
            // 
            // TenLoai
            // 
            TenLoai.DataPropertyName = "TenLoai";
            TenLoai.HeaderText = "Tên loại sản phẩm";
            TenLoai.Name = "TenLoai";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { TenLoai });
            dataGridView.Location = new Point(307, 266);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(659, 239);
            dataGridView.TabIndex = 0;
            // 
            // btnThoat
            // 
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Location = new Point(307, 522);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(103, 27);
            btnThoat.TabIndex = 16;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click_1;
            // 
            // frmLoaiSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(984, 561);
            Controls.Add(btnThoat);
            Controls.Add(dataGridView);
            Controls.Add(label2);
            Controls.Add(btnNhap);
            Controls.Add(btnXuat);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "frmLoaiSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KHGKJ";
            Load += frmLoaiSanPham_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTenLoai;
        private Label label1;
        private Button btnXuat;
        private Button btnNhap;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnHoaDon;
        private Button btnNhanVien;
        private Button btnKhachHang;
        private Button btnSanPham;
        private Button btnHangSanXuat;
        private Button btnLoaiSanPham;
        private Label label2;
        private DataGridViewTextBoxColumn TenLoai;
        private DataGridView dataGridView;
        private Button btnThoat;
        private Label label7;
    }
}