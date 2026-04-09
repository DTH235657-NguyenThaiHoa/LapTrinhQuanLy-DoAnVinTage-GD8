using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;
using Vintage.Data;

namespace Vintage
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        QLVintageDContext context = new QLVintageDContext();
        frmLoaiSanPham loaiSanPham = null;
        frmHangSanXuat hangSanXuat = null;
        frmSanPham sanPham = null;
        frmKhachHang khachHang = null;
        frmNhanVien nhanVien = null;
        frmHoaDon hoaDon = null;
        frmDangNhap dangNhap = null;
        string hoVaTenNhanVien = ""; // Lấy tên người dùng hiển thị vào thanh Status.
        private void DangNhap()
        {
        LamLai:
            if (dangNhap == null || dangNhap.IsDisposed)
                dangNhap = new frmDangNhap();
            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                string tenDangNhap = dangNhap.txtTenDangNhap.Text;
                string matKhau = dangNhap.txtMatKhau.Text;
                if (tenDangNhap.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtTenDangNhap.Focus();
                    goto LamLai;
                }
                else if (matKhau.Trim() == "")
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtMatKhau.Focus();
                    goto LamLai;
                }
                else
                {
                    var nhanVien = context.NhanVien.Where(r => r.TenDangNhap == tenDangNhap).SingleOrDefault();
                    if (nhanVien == null)
                    {
                        MessageBox.Show("Tên đăng nhập không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dangNhap.txtTenDangNhap.Focus();
                        goto LamLai;
                    }
                    else
                    {
                        if (nhanVien.MatKhau.StartsWith("$2"))
                        {
                            // đã hash
                            if (BC.Verify(matKhau, nhanVien.MatKhau))
                            {
                                hoVaTenNhanVien = nhanVien.TenNhanVien;
                                if (nhanVien.QuyenHan == true)
                                    QuyenQuanLy();
                                else
                                    QuyenNhanVien();
                            }
                            else
                            {
                                MessageBox.Show("Mật khẩu không chính xác!");
                                goto LamLai;
                            }
                        }
                        else
                        {
                            // mật khẩu cũ (plain text)
                            if (matKhau == nhanVien.MatKhau)
                            {
                                // đúng → chuyển sang hash
                                nhanVien.MatKhau = BC.HashPassword(matKhau);
                                context.SaveChanges();

                                hoVaTenNhanVien = nhanVien.TenNhanVien;
                                if (nhanVien.QuyenHan == true)
                                    QuyenQuanLy();
                                else
                                    QuyenNhanVien();
                            }
                            else
                            {
                                MessageBox.Show("Mật khẩu không chính xác!");
                                goto LamLai;
                            }
                        }
                    }
                }
            }
        }
        public void ChuaDangNhap()
        {
            // Sáng đăng nhập
            mnuDangNhap.Enabled = true;
            // Mờ tất cả
            mnuDangXuat.Enabled = false;
            mnuDoiMatKhau.Enabled = false;
            mnuLoaiSanPham.Enabled = false;
            mnuHangSanXuat.Enabled = false;
            mnuSanPham.Enabled = false;
            mnuKhachHang.Enabled = false;
            mnuNhanVien.Enabled = false;
            mnuHoaDon.Enabled = false;
            mnuThongKeSanPham.Enabled = false;
            mnuThongKeDoanhThu.Enabled = false;
            // Hiển thị thông tin trên thanh trạng thái
            lblTrangThai.Text = "Chưa đăng nhập.";
            NguoiDangNhap.Text = "Chưa đăng nhập.";
            LinkDangXuat.Visible = false;
        }
        public void QuyenQuanLy()
        {
            // Mờ đăng nhập
            mnuDangNhap.Enabled = false;
            // Mờ các chức năng quản lý không được phép
            // Sáng đăng xuất và các chức năng quản lý được phép
            mnuDangXuat.Enabled = true;
            mnuDoiMatKhau.Enabled = true;
            mnuLoaiSanPham.Enabled = true;
            mnuHangSanXuat.Enabled = true;
            mnuSanPham.Enabled = true;
            mnuKhachHang.Enabled = true;
            mnuNhanVien.Enabled = true;
            mnuHoaDon.Enabled = true;
            mnuThongKeSanPham.Enabled = true;
            mnuThongKeDoanhThu.Enabled = true;
            // Hiển thị thông tin trên thanh trạng thái
            lblTrangThai.Text = "Quản lý: " + hoVaTenNhanVien;
            NguoiDangNhap.Text = hoVaTenNhanVien;
            LinkDangXuat.Visible = true;
        }
        public void QuyenNhanVien()
        {
            // Mờ đăng nhập
            mnuDangNhap.Enabled = false;
            // Mờ các chức năng nhân viên không được phép
            mnuLoaiSanPham.Enabled = false;
            mnuHangSanXuat.Enabled = false;
            mnuSanPham.Enabled = false;
            mnuNhanVien.Enabled = false;
            // Sáng đăng xuất và các chức năng nhân viên được phép
            mnuDangXuat.Enabled = true;
            mnuDoiMatKhau.Enabled = true;
            mnuKhachHang.Enabled = true;
            mnuHoaDon.Enabled = true;
            mnuThongKeSanPham.Enabled = true;
            mnuThongKeDoanhThu.Enabled = true;
            // Hiển thị thông tin trên thanh trạng thái
            lblTrangThai.Text = "Nhân viên: " + hoVaTenNhanVien;
            NguoiDangNhap.Text = hoVaTenNhanVien;
            LinkDangXuat.Visible = true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            ChuaDangNhap();
            DangNhap();
        }

        private void mnuLoaiSanPham_Click(object sender, EventArgs e)
        {
            if (loaiSanPham == null || loaiSanPham.IsDisposed)
            {
                loaiSanPham = new frmLoaiSanPham();
                loaiSanPham.Show();
            }
            else
                loaiSanPham.Activate();
        }

        private void lblLienKet_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "explorer.exe";
            info.Arguments = "https://fit.agu.edu.vn";
            Process.Start(info);
        }

        private void mnuHangSanXuat_Click(object sender, EventArgs e)
        {
            if (hangSanXuat == null || hangSanXuat.IsDisposed)
            {
                hangSanXuat = new frmHangSanXuat();
                hangSanXuat.Show();
            }
            else
                hangSanXuat.Activate();
        }

        private void mnuSanPham_Click(object sender, EventArgs e)
        {
            if (sanPham == null || sanPham.IsDisposed)
            {
                sanPham = new frmSanPham();
                sanPham.Show();
            }
            else
                sanPham.Activate();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            if (khachHang == null || khachHang.IsDisposed)
            {
                khachHang = new frmKhachHang();
                khachHang.Show();
            }
            else
                khachHang.Activate();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            if (nhanVien == null || nhanVien.IsDisposed)
            {
                nhanVien = new frmNhanVien();
                nhanVien.Show();
            }
            else
                nhanVien.Activate();
        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            if (hoaDon == null || hoaDon.IsDisposed)
            {
                hoaDon = new frmHoaDon();
                hoaDon.Show();
            }
            else
                hoaDon.Activate();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }
            ChuaDangNhap();
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void btnLoaiSanPham_Click(object sender, EventArgs e)
        {
            if (loaiSanPham == null || loaiSanPham.IsDisposed)
            {
                loaiSanPham = new frmLoaiSanPham();
                loaiSanPham.Show();
            }
            else
                loaiSanPham.Activate();
        }
        private void btnHangSanXuat_Click(object sender, EventArgs e)
        {
            if (hangSanXuat == null || hangSanXuat.IsDisposed)
            {
                hangSanXuat = new frmHangSanXuat();
                hangSanXuat.Show();
            }
            else
                hangSanXuat.Activate();
        }
        private void btnSanPham_Click(object sender, EventArgs e)
        {
            if (sanPham == null || sanPham.IsDisposed)
            {
                sanPham = new frmSanPham();
                sanPham.Show();
            }
            else
                sanPham.Activate();
        }
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            if (khachHang == null || khachHang.IsDisposed)
            {
                khachHang = new frmKhachHang();
                khachHang.Show();
            }
            else
                khachHang.Activate();
        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            if (nhanVien == null || nhanVien.IsDisposed)
            {
                nhanVien = new frmNhanVien();
                nhanVien.Show();
            }
            else
                nhanVien.Activate();
        }
        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            if (hoaDon == null || hoaDon.IsDisposed)
            {
                hoaDon = new frmHoaDon();
                hoaDon.Show();
            }
            else
                hoaDon.Activate();
        }

        private void LinkDangXuat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }
            ChuaDangNhap();
        }
        private void lblTrangThai_Click(object sender, EventArgs e)
        {

        }
    }
}
