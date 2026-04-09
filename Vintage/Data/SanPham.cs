using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vintage.Data
{
    public class SanPham
    {
        public int ID { get; set; }
        public int HangSanXuatID { get; set; }
        public int LoaiSanPhamID { get; set; }
        public string TenSanPham { get; set; }
        public string Size { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public string? MoTa { get; set; }

        public virtual LoaiSanPham LoaiSanPham { get; set; } = null!;
        public virtual HangSanXuat HangSanXuat { get; set; } = null!;
        public virtual ObservableCollection<HoaDon_ChiTiet> HoaDon_ChiTiet { get; set; } = new();
    }
    [NotMapped]
    public class DanhSachSanPham
    {
        public int ID { get; set; }
        public int HangSanXuatID { get; set; }
        public string TenHangSanXuat { get; set; } // Thêm
        public int LoaiSanPhamID { get; set; }
        public string TenLoai { get; set; } // Thêm
        public string TenSanPham { get; set; }
        public string Size { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public string? MoTa { get; set; }
    }
}
