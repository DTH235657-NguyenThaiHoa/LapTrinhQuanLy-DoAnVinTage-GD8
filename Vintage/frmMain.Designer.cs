namespace Vintage
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuStrip = new MenuStrip();
            mnuHeThong = new ToolStripMenuItem();
            mnuDangNhap = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            mnuDoiMatKhau = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            mnuQuanLy = new ToolStripMenuItem();
            mnuLoaiSanPham = new ToolStripMenuItem();
            mnuHangSanXuat = new ToolStripMenuItem();
            mnuSanPham = new ToolStripMenuItem();
            mnuKhachHang = new ToolStripMenuItem();
            mnuNhanVien = new ToolStripMenuItem();
            mnuHoaDon = new ToolStripMenuItem();
            mnuBaoCaoThongKe = new ToolStripMenuItem();
            mnuThongKeSanPham = new ToolStripMenuItem();
            mnuThongKeDoanhThu = new ToolStripMenuItem();
            mnuTroGiup = new ToolStripMenuItem();
            mnuHuongDanSuDung = new ToolStripMenuItem();
            mnuThongTinPhanMem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            lblLienKet = new ToolStripStatusLabel();
            pictureBox1 = new PictureBox();
            btnLoaiSanPham = new Button();
            btnHangSanXuat = new Button();
            btnSanPham = new Button();
            btnKhachHang = new Button();
            btnNhanVien = new Button();
            btnHoaDon = new Button();
            panel1 = new Panel();
            NguoiDangNhap = new Label();
            LinkDangXuat = new LinkLabel();
            VINTAGE = new Label();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.SaddleBrown;
            menuStrip.GripStyle = ToolStripGripStyle.Visible;
            menuStrip.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuQuanLy, mnuBaoCaoThongKe, mnuTroGiup });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(984, 24);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuDangNhap, mnuDangXuat, mnuDoiMatKhau, mnuThoat });
            mnuHeThong.ForeColor = Color.White;
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(69, 20);
            mnuHeThong.Text = "Hệ thống";
            // 
            // mnuDangNhap
            // 
            mnuDangNhap.Name = "mnuDangNhap";
            mnuDangNhap.Size = new Size(157, 22);
            mnuDangNhap.Text = "Đăng nhập…";
            mnuDangNhap.Click += mnuDangNhap_Click;
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(157, 22);
            mnuDangXuat.Text = "Đăng xuất";
            mnuDangXuat.Click += mnuDangXuat_Click;
            // 
            // mnuDoiMatKhau
            // 
            mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            mnuDoiMatKhau.Size = new Size(157, 22);
            mnuDoiMatKhau.Text = "Đổi mật khẩu… ";
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuThoat.Size = new Size(157, 22);
            mnuThoat.Text = "Thoát";
            // 
            // mnuQuanLy
            // 
            mnuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { mnuLoaiSanPham, mnuHangSanXuat, mnuSanPham, mnuKhachHang, mnuNhanVien, mnuHoaDon });
            mnuQuanLy.ForeColor = Color.White;
            mnuQuanLy.Name = "mnuQuanLy";
            mnuQuanLy.Size = new Size(60, 20);
            mnuQuanLy.Text = "Quản lý";
            // 
            // mnuLoaiSanPham
            // 
            mnuLoaiSanPham.Name = "mnuLoaiSanPham";
            mnuLoaiSanPham.Size = new Size(182, 22);
            mnuLoaiSanPham.Text = "Loại sản phẩm…";
            mnuLoaiSanPham.Click += mnuLoaiSanPham_Click;
            // 
            // mnuHangSanXuat
            // 
            mnuHangSanXuat.Name = "mnuHangSanXuat";
            mnuHangSanXuat.Size = new Size(182, 22);
            mnuHangSanXuat.Text = "Hãng sản xuất…";
            mnuHangSanXuat.Click += mnuHangSanXuat_Click;
            // 
            // mnuSanPham
            // 
            mnuSanPham.Name = "mnuSanPham";
            mnuSanPham.Size = new Size(182, 22);
            mnuSanPham.Text = "Sản phẩm…";
            mnuSanPham.Click += mnuSanPham_Click;
            // 
            // mnuKhachHang
            // 
            mnuKhachHang.Name = "mnuKhachHang";
            mnuKhachHang.Size = new Size(182, 22);
            mnuKhachHang.Text = "Khách hàng…";
            mnuKhachHang.Click += mnuKhachHang_Click;
            // 
            // mnuNhanVien
            // 
            mnuNhanVien.Name = "mnuNhanVien";
            mnuNhanVien.Size = new Size(182, 22);
            mnuNhanVien.Text = "Nhân viên…";
            mnuNhanVien.Click += mnuNhanVien_Click;
            // 
            // mnuHoaDon
            // 
            mnuHoaDon.Name = "mnuHoaDon";
            mnuHoaDon.Size = new Size(182, 22);
            mnuHoaDon.Text = "Hóa đơn bán hàng…";
            mnuHoaDon.Click += mnuHoaDon_Click;
            // 
            // mnuBaoCaoThongKe
            // 
            mnuBaoCaoThongKe.DropDownItems.AddRange(new ToolStripItem[] { mnuThongKeSanPham, mnuThongKeDoanhThu });
            mnuBaoCaoThongKe.ForeColor = Color.White;
            mnuBaoCaoThongKe.Name = "mnuBaoCaoThongKe";
            mnuBaoCaoThongKe.Size = new Size(122, 20);
            mnuBaoCaoThongKe.Text = "Báo cáo – Thống kê";
            // 
            // mnuThongKeSanPham
            // 
            mnuThongKeSanPham.Name = "mnuThongKeSanPham";
            mnuThongKeSanPham.Size = new Size(190, 22);
            mnuThongKeSanPham.Text = "Thống kê sản phẩm...";
            // 
            // mnuThongKeDoanhThu
            // 
            mnuThongKeDoanhThu.Name = "mnuThongKeDoanhThu";
            mnuThongKeDoanhThu.Size = new Size(190, 22);
            mnuThongKeDoanhThu.Text = "Thống kê doanh thu...";
            // 
            // mnuTroGiup
            // 
            mnuTroGiup.DropDownItems.AddRange(new ToolStripItem[] { mnuHuongDanSuDung, mnuThongTinPhanMem });
            mnuTroGiup.ForeColor = Color.White;
            mnuTroGiup.Name = "mnuTroGiup";
            mnuTroGiup.Size = new Size(62, 20);
            mnuTroGiup.Text = "Trợ giúp";
            // 
            // mnuHuongDanSuDung
            // 
            mnuHuongDanSuDung.Name = "mnuHuongDanSuDung";
            mnuHuongDanSuDung.ShortcutKeys = Keys.Control | Keys.F1;
            mnuHuongDanSuDung.Size = new Size(226, 22);
            mnuHuongDanSuDung.Text = "Hướng dẫn sử dụng";
            // 
            // mnuThongTinPhanMem
            // 
            mnuThongTinPhanMem.Name = "mnuThongTinPhanMem";
            mnuThongTinPhanMem.Size = new Size(226, 22);
            mnuThongTinPhanMem.Text = "Thông tin phần mềm...";
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { lblTrangThai, toolStripStatusLabel2, lblLienKet });
            statusStrip.Location = new Point(0, 539);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(984, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "statusStrip1";
            // 
            // lblTrangThai
            // 
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(98, 17);
            lblTrangThai.Text = "Chưa đăng nhập.";
            lblTrangThai.Click += lblTrangThai_Click;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(799, 17);
            toolStripStatusLabel2.Text = resources.GetString("toolStripStatusLabel2.Text");
            // 
            // lblLienKet
            // 
            lblLienKet.IsLink = true;
            lblLienKet.Name = "lblLienKet";
            lblLienKet.Size = new Size(72, 17);
            lblLienKet.Spring = true;
            lblLienKet.Text = "© 2024 FIT";
            lblLienKet.Click += lblLienKet_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.banner;
            pictureBox1.Location = new Point(0, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(984, 525);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btnLoaiSanPham
            // 
            btnLoaiSanPham.BackColor = Color.Snow;
            btnLoaiSanPham.FlatStyle = FlatStyle.Flat;
            btnLoaiSanPham.Font = new Font("Segoe UI", 12F);
            btnLoaiSanPham.Location = new Point(46, 145);
            btnLoaiSanPham.Name = "btnLoaiSanPham";
            btnLoaiSanPham.Size = new Size(215, 43);
            btnLoaiSanPham.TabIndex = 0;
            btnLoaiSanPham.Text = "🏷️ Loại sản phẩm";
            btnLoaiSanPham.UseVisualStyleBackColor = false;
            btnLoaiSanPham.Click += btnLoaiSanPham_Click;
            // 
            // btnHangSanXuat
            // 
            btnHangSanXuat.BackColor = Color.Snow;
            btnHangSanXuat.FlatStyle = FlatStyle.Flat;
            btnHangSanXuat.Font = new Font("Segoe UI", 12F);
            btnHangSanXuat.Location = new Point(46, 208);
            btnHangSanXuat.Name = "btnHangSanXuat";
            btnHangSanXuat.Size = new Size(215, 43);
            btnHangSanXuat.TabIndex = 1;
            btnHangSanXuat.Text = "🏭 Nhà cung cấp";
            btnHangSanXuat.UseVisualStyleBackColor = false;
            btnHangSanXuat.Click += btnHangSanXuat_Click;
            // 
            // btnSanPham
            // 
            btnSanPham.BackColor = Color.Snow;
            btnSanPham.FlatStyle = FlatStyle.Flat;
            btnSanPham.Font = new Font("Segoe UI", 12F);
            btnSanPham.Location = new Point(46, 269);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Size = new Size(215, 43);
            btnSanPham.TabIndex = 2;
            btnSanPham.Text = "👕 Sản phẩm";
            btnSanPham.UseVisualStyleBackColor = false;
            btnSanPham.Click += btnSanPham_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.BackColor = Color.Snow;
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Font = new Font("Segoe UI", 12F);
            btnKhachHang.Location = new Point(46, 330);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(215, 43);
            btnKhachHang.TabIndex = 3;
            btnKhachHang.Text = "\U0001f9d1‍\U0001f91d‍\U0001f9d1 Khách hàng";
            btnKhachHang.UseVisualStyleBackColor = false;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = Color.Snow;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Font = new Font("Segoe UI", 12F);
            btnNhanVien.Location = new Point(46, 393);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(215, 43);
            btnNhanVien.TabIndex = 4;
            btnNhanVien.Text = "\U0001f9d1‍ Nhân viên";
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.BackColor = Color.Snow;
            btnHoaDon.FlatStyle = FlatStyle.Flat;
            btnHoaDon.Font = new Font("Segoe UI", 12F);
            btnHoaDon.Location = new Point(46, 456);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(215, 43);
            btnHoaDon.TabIndex = 5;
            btnHoaDon.Text = "\U0001f9fe Hoá đơn";
            btnHoaDon.UseVisualStyleBackColor = false;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(NguoiDangNhap);
            panel1.Controls.Add(LinkDangXuat);
            panel1.Controls.Add(VINTAGE);
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 48);
            panel1.TabIndex = 14;
            // 
            // NguoiDangNhap
            // 
            NguoiDangNhap.AutoSize = true;
            NguoiDangNhap.Font = new Font("Segoe UI", 14.25F);
            NguoiDangNhap.Location = new Point(165, 13);
            NguoiDangNhap.Name = "NguoiDangNhap";
            NguoiDangNhap.Size = new Size(63, 25);
            NguoiDangNhap.TabIndex = 11;
            NguoiDangNhap.Text = "label1";
            // 
            // LinkDangXuat
            // 
            LinkDangXuat.AutoSize = true;
            LinkDangXuat.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LinkDangXuat.LinkColor = Color.FromArgb(128, 64, 0);
            LinkDangXuat.Location = new Point(872, 14);
            LinkDangXuat.Name = "LinkDangXuat";
            LinkDangXuat.Size = new Size(98, 25);
            LinkDangXuat.TabIndex = 10;
            LinkDangXuat.TabStop = true;
            LinkDangXuat.Text = "Đăng xuất";
            LinkDangXuat.LinkClicked += LinkDangXuat_LinkClicked;
            // 
            // VINTAGE
            // 
            VINTAGE.AutoSize = true;
            VINTAGE.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            VINTAGE.ForeColor = Color.FromArgb(128, 64, 0);
            VINTAGE.Location = new Point(44, 7);
            VINTAGE.Name = "VINTAGE";
            VINTAGE.Size = new Size(115, 32);
            VINTAGE.TabIndex = 0;
            VINTAGE.Text = "Xin chào!";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(panel1);
            Controls.Add(btnHoaDon);
            Controls.Add(btnNhanVien);
            Controls.Add(menuStrip);
            Controls.Add(btnKhachHang);
            Controls.Add(statusStrip);
            Controls.Add(btnSanPham);
            Controls.Add(btnHangSanXuat);
            Controls.Add(btnLoaiSanPham);
            Controls.Add(pictureBox1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý cửa hàng quần áo Vintage";
            Load += frmMain_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuDangNhap;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripMenuItem mnuDoiMatKhau;
        private StatusStrip statusStrip;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuQuanLy;
        private ToolStripMenuItem mnuLoaiSanPham;
        private ToolStripMenuItem mnuHangSanXuat;
        private ToolStripMenuItem mnuSanPham;
        private ToolStripMenuItem mnuKhachHang;
        private ToolStripMenuItem mnuNhanVien;
        private ToolStripMenuItem mnuHoaDon;
        private ToolStripMenuItem mnuBaoCaoThongKe;
        private ToolStripMenuItem mnuThongKeSanPham;
        private ToolStripMenuItem mnuThongKeDoanhThu;
        private ToolStripMenuItem mnuTroGiup;
        private ToolStripMenuItem mnuHuongDanSuDung;
        private ToolStripMenuItem mnuThongTinPhanMem;
        private ToolStripStatusLabel lblTrangThai;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel lblLienKet;
        private PictureBox pictureBox1;
        private Button btnLoaiSanPham;
        private Button btnHangSanXuat;
        private Button btnSanPham;
        private Button btnKhachHang;
        private Button btnNhanVien;
        private Button btnHoaDon;
        private Panel panel1;
        private Label VINTAGE;
        private LinkLabel LinkDangXuat;
        private Label NguoiDangNhap;
    }
}