using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vintage
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bthHuyBo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void chboxMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxMK.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;
        }
    }
}
