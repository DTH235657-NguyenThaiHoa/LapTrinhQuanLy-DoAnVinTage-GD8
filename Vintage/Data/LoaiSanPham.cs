using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vintage.Data
{
    public class LoaiSanPham
    {
        public int ID { get; set; }
        public string TenLoai { get; set; }

        public virtual ObservableCollection<SanPham> SanPham { get; set; } = new();
    }
}
