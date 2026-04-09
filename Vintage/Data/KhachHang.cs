using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vintage.Data
{
    public class KhachHang
    {
        public int ID { get; set; }
        public string TenKhachHang { get; set; }
        public string? DienThoai { get; set; }
        public string? DiaChi { get; set; }

        public virtual ObservableCollection<HoaDon> HoaDon { get; set; } = new();
    }
}
