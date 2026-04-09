using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vintage.Data;

namespace Vintage
{
    public partial class frmHoaDon : Form
    {
        QLVintageDContext context = new QLVintageDContext();
        int id;
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            List<DanhSachHoaDon> hd = new List<DanhSachHoaDon>();
            hd = context.HoaDon.Select(r => new DanhSachHoaDon
            {
                ID = r.ID,
                NhanVienID = r.NhanVienID,
                HoVaTenNhanVien = r.NhanVien.TenNhanVien,
                KhachHangID = r.KhachHangID,
                HoVaTenKhachHang = r.KhachHang.TenKhachHang,
                NgayLap = r.NgayLap,
                TongTienHoaDon = r.HoaDon_ChiTiet.Sum(ct => (int)ct.SoLuong * ct.DonGia),
                XemChiTiet = "Xem chi tiết"
            }).ToList();
            dataGridView.DataSource = hd;
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet())
            {
                this.Close();
                chiTiet.Show();
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet(id))
            {
                this.Close();
                chiTiet.Show();   
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "HoaDon_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[2] {
                    new DataColumn("ID", typeof(int)),
                    new DataColumn("HoaDon_ChiTiet", typeof(string))
                    });
                    var hoaDon = context.HoaDon.ToList();
                    if (hoaDon != null)
                    {
                        foreach (var p in hoaDon)
                            table.Rows.Add(p.ID, p.HoaDon_ChiTiet);
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "HoaDon");
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Đã xuất dữ liệu ra tập tin Excel thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmLoaiSanPham f = new frmLoaiSanPham();
            f.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmHangSanXuat f = new frmHangSanXuat();
            f.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmSanPham f = new frmSanPham();
            f.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            f.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmNhanVien f = new frmNhanVien();
            f.Show();
            this.Close();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView.Columns[e.ColumnIndex].Name == "XemChiTiet")
            {
                int id = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["ID"].Value);

                frmHoaDon_ChiTiet f = new frmHoaDon_ChiTiet(id);
                this.Close();
                f.Show();
            }
        }
    }
}

