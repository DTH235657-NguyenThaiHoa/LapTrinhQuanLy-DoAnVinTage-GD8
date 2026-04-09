namespace Vintage
{
    partial class frmSanPham
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
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            TenHangSanXuat = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            cboSize = new ComboBox();
            numDonGia = new NumericUpDown();
            numSoLuong = new NumericUpDown();
            cboLoaiSanPham = new ComboBox();
            cboHangSanXuat = new ComboBox();
            txtTenSanPham = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label1 = new Label();
            btnThoat = new Button();
            btnNhap = new Button();
            btnXuat = new Button();
            panel1 = new Panel();
            linkLabel2 = new LinkLabel();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenSanPham, TenLoai, TenHangSanXuat, SoLuong, DonGia });
            dataGridView.Location = new Point(307, 266);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.Size = new Size(659, 239);
            dataGridView.TabIndex = 0;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Tên sản phẩm";
            TenSanPham.Name = "TenSanPham";
            TenSanPham.ReadOnly = true;
            // 
            // TenLoai
            // 
            TenLoai.DataPropertyName = "TenLoai";
            TenLoai.HeaderText = "Phân loại";
            TenLoai.Name = "TenLoai";
            TenLoai.ReadOnly = true;
            // 
            // TenHangSanXuat
            // 
            TenHangSanXuat.DataPropertyName = "TenHangSanXuat";
            TenHangSanXuat.HeaderText = "Hãng sản xuất";
            TenHangSanXuat.Name = "TenHangSanXuat";
            TenHangSanXuat.ReadOnly = true;
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số lượng";
            SoLuong.Name = "SoLuong";
            SoLuong.ReadOnly = true;
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn giá";
            DonGia.Name = "DonGia";
            DonGia.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboSize);
            groupBox1.Controls.Add(numDonGia);
            groupBox1.Controls.Add(numSoLuong);
            groupBox1.Controls.Add(cboLoaiSanPham);
            groupBox1.Controls.Add(cboHangSanXuat);
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.FromArgb(128, 64, 0);
            groupBox1.Location = new Point(308, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(659, 167);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // cboSize
            // 
            cboSize.FlatStyle = FlatStyle.Flat;
            cboSize.FormattingEnabled = true;
            cboSize.Items.AddRange(new object[] { "M", "L", "XL", "XXL", "XXXL" });
            cboSize.Location = new Point(427, 88);
            cboSize.Name = "cboSize";
            cboSize.Size = new Size(140, 23);
            cboSize.TabIndex = 26;
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(427, 59);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(140, 23);
            numDonGia.TabIndex = 25;
            numDonGia.ThousandsSeparator = true;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(427, 30);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(140, 23);
            numSoLuong.TabIndex = 24;
            numSoLuong.ThousandsSeparator = true;
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.FlatStyle = FlatStyle.Flat;
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(121, 30);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(212, 23);
            cboLoaiSanPham.TabIndex = 23;
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.FlatStyle = FlatStyle.Flat;
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(121, 59);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(212, 23);
            cboHangSanXuat.TabIndex = 22;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(121, 88);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(212, 23);
            txtTenSanPham.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(350, 91);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 19;
            label7.Text = "Size (*):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(16, 61);
            label6.Name = "label6";
            label6.Size = new Size(102, 15);
            label6.TabIndex = 17;
            label6.Text = "Hãng sản xuất (*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(348, 63);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 16;
            label5.Text = "Đơn giá (*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(348, 35);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 15;
            label4.Text = "Số lượng (*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(18, 91);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 8;
            label2.Text = "Tên sản phẩm (*):";
            // 
            // btnHuyBo
            // 
            btnHuyBo.FlatStyle = FlatStyle.Flat;
            btnHuyBo.Location = new Point(537, 124);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(103, 27);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "Huỷ bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(428, 124);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(103, 27);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(251, 124);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(103, 27);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "❌ Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.FromArgb(128, 64, 0);
            btnSua.Location = new Point(142, 124);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(103, 27);
            btnSua.TabIndex = 3;
            btnSua.Text = "🖊️Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.FromArgb(128, 64, 0);
            btnThem.Location = new Point(33, 124);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(103, 27);
            btnThem.TabIndex = 2;
            btnThem.Text = "➕Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(16, 33);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Phân loại (*):";
            // 
            // btnThoat
            // 
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Location = new Point(307, 522);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(103, 27);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnNhap
            // 
            btnNhap.FlatStyle = FlatStyle.Flat;
            btnNhap.ForeColor = Color.FromArgb(0, 64, 0);
            btnNhap.Location = new Point(718, 511);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(121, 27);
            btnNhap.TabIndex = 13;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnXuat
            // 
            btnXuat.FlatStyle = FlatStyle.Flat;
            btnXuat.ForeColor = Color.Green;
            btnXuat.Location = new Point(845, 511);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(121, 27);
            btnXuat.TabIndex = 12;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 64, 0);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 560);
            panel1.TabIndex = 18;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(53, 65);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(177, 25);
            linkLabel2.TabIndex = 13;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "\U0001f9d1 Chưa đăng nhập";
            // 
            // button2
            // 
            button2.BackColor = Color.Snow;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(37, 453);
            button2.Name = "button2";
            button2.Size = new Size(215, 43);
            button2.TabIndex = 12;
            button2.Text = "\U0001f9fe Hoá đơn";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Snow;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(37, 390);
            button3.Name = "button3";
            button3.Size = new Size(215, 43);
            button3.TabIndex = 11;
            button3.Text = "\U0001f9d1‍ Nhân viên";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Snow;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F);
            button4.Location = new Point(37, 327);
            button4.Name = "button4";
            button4.Size = new Size(215, 43);
            button4.TabIndex = 10;
            button4.Text = "\U0001f9d1‍\U0001f91d‍\U0001f9d1 Khách hàng";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Snow;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            button5.ForeColor = Color.FromArgb(128, 64, 0);
            button5.Location = new Point(37, 266);
            button5.Name = "button5";
            button5.Size = new Size(215, 43);
            button5.TabIndex = 9;
            button5.Text = "👕 Sản phẩm";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Snow;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 12F);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(37, 205);
            button6.Name = "button6";
            button6.Size = new Size(215, 43);
            button6.TabIndex = 8;
            button6.Text = "🏭 Nhà cung cấp";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Snow;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 12F);
            button7.ForeColor = Color.Black;
            button7.Location = new Point(37, 142);
            button7.Name = "button7";
            button7.Size = new Size(215, 43);
            button7.TabIndex = 7;
            button7.Text = "🏷️ Loại sản phẩm";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.banner;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(289, 557);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(128, 64, 0);
            label3.Location = new Point(307, 29);
            label3.Name = "label3";
            label3.Size = new Size(186, 45);
            label3.TabIndex = 27;
            label3.Text = "SẢN PHẨM";
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(984, 561);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(dataGridView);
            Controls.Add(btnNhap);
            Controls.Add(btnXuat);
            Controls.Add(groupBox1);
            Controls.Add(btnThoat);
            Name = "frmSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sản phẩm";
            Load += frmSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label label1;
        private Label label7;
        private ComboBox cboSize;
        private NumericUpDown numDonGia;
        private NumericUpDown numSoLuong;
        private ComboBox cboLoaiSanPham;
        private ComboBox cboHangSanXuat;
        private TextBox txtTenSanPham;
        private Button btnNhap;
        private Button btnXuat;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn TenLoai;
        private DataGridViewTextBoxColumn TenHangSanXuat;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private Panel panel1;
        private LinkLabel linkLabel2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private PictureBox pictureBox2;
        private Label label3;
    }
}