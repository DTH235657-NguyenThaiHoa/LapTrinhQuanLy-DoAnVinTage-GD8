namespace Vintage
{
    partial class frmHoaDon_ChiTiet
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
            groupBox2 = new GroupBox();
            btnXoa = new Button();
            btnXacNhanBan = new Button();
            numDonGiaBan = new NumericUpDown();
            numSoLuongBan = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            cboSanPham = new ComboBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            DonGiaBan = new DataGridViewTextBoxColumn();
            SoLuongBan = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            LabelMaHD = new Label();
            label2 = new Label();
            cboKhachHang = new ComboBox();
            cboNhanVien = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            btnThoat = new Button();
            btnInHoaDon = new Button();
            btnLuuHoaDon = new Button();
            panel1 = new Panel();
            label7 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            pictureBox2 = new PictureBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnXacNhanBan);
            groupBox2.Controls.Add(numDonGiaBan);
            groupBox2.Controls.Add(numSoLuongBan);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cboSanPham);
            groupBox2.Location = new Point(307, 142);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(659, 93);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chi tiết hoá đơn";
            // 
            // btnXoa
            // 
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Location = new Point(542, 49);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(87, 27);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXacNhanBan
            // 
            btnXacNhanBan.FlatStyle = FlatStyle.Flat;
            btnXacNhanBan.Location = new Point(397, 49);
            btnXacNhanBan.Name = "btnXacNhanBan";
            btnXacNhanBan.Size = new Size(139, 27);
            btnXacNhanBan.TabIndex = 15;
            btnXacNhanBan.Text = "Xác nhận bán";
            btnXacNhanBan.UseVisualStyleBackColor = true;
            btnXacNhanBan.Click += btnXacNhanBan_Click;
            // 
            // numDonGiaBan
            // 
            numDonGiaBan.Location = new Point(282, 53);
            numDonGiaBan.Name = "numDonGiaBan";
            numDonGiaBan.Size = new Size(109, 23);
            numDonGiaBan.TabIndex = 18;
            // 
            // numSoLuongBan
            // 
            numSoLuongBan.Location = new Point(180, 53);
            numSoLuongBan.Name = "numSoLuongBan";
            numSoLuongBan.Size = new Size(96, 23);
            numSoLuongBan.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(282, 35);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 16;
            label6.Text = "Đơn giá bán (*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(180, 35);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 15;
            label5.Text = "Số lượng bán (*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 34);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 14;
            label4.Text = "Sản phẩm (*):";
            // 
            // cboSanPham
            // 
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(13, 52);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(161, 23);
            cboSanPham.TabIndex = 14;
            cboSanPham.SelectionChangeCommitted += cboSanPham_SelectionChangeCommitted;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenSanPham, DonGiaBan, SoLuongBan, ThanhTien });
            dataGridView.Location = new Point(307, 253);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(659, 252);
            dataGridView.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.FillWeight = 30F;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.FillWeight = 120F;
            TenSanPham.HeaderText = "Tên sản phẩm";
            TenSanPham.Name = "TenSanPham";
            // 
            // DonGiaBan
            // 
            DonGiaBan.DataPropertyName = "DonGiaBan";
            DonGiaBan.HeaderText = "Đơn giá bán";
            DonGiaBan.Name = "DonGiaBan";
            // 
            // SoLuongBan
            // 
            SoLuongBan.DataPropertyName = "SoLuongBan";
            SoLuongBan.FillWeight = 80F;
            SoLuongBan.HeaderText = "Số lượng bán";
            SoLuongBan.Name = "SoLuongBan";
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.Name = "ThanhTien";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LabelMaHD);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cboKhachHang);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(307, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(659, 115);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hoá đơn";
            // 
            // LabelMaHD
            // 
            LabelMaHD.AutoSize = true;
            LabelMaHD.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelMaHD.Location = new Point(112, 31);
            LabelMaHD.Name = "LabelMaHD";
            LabelMaHD.Size = new Size(65, 25);
            LabelMaHD.TabIndex = 15;
            LabelMaHD.Text = "MaHD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 39);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 14;
            label2.Text = "Mã Hoá Đơn:";
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(442, 75);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(183, 23);
            cboKhachHang.TabIndex = 13;
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(133, 75);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(183, 23);
            cboNhanVien.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(347, 78);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 9;
            label3.Text = "Khách hàng (*):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 79);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhân viên lập (*):";
            // 
            // btnThoat
            // 
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Location = new Point(307, 522);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(124, 27);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.FlatStyle = FlatStyle.Flat;
            btnInHoaDon.Location = new Point(842, 511);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(124, 27);
            btnInHoaDon.TabIndex = 6;
            btnInHoaDon.Text = "In hóa đơn… ";
            btnInHoaDon.UseVisualStyleBackColor = true;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // btnLuuHoaDon
            // 
            btnLuuHoaDon.FlatStyle = FlatStyle.Flat;
            btnLuuHoaDon.ForeColor = Color.Blue;
            btnLuuHoaDon.Location = new Point(673, 511);
            btnLuuHoaDon.Name = "btnLuuHoaDon";
            btnLuuHoaDon.Size = new Size(163, 27);
            btnLuuHoaDon.TabIndex = 5;
            btnLuuHoaDon.Text = "Lưu hóa đơn và Thanh toán";
            btnLuuHoaDon.UseVisualStyleBackColor = true;
            btnLuuHoaDon.Click += btnLuuHoaDon_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 64, 0);
            panel1.Controls.Add(label7);
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
            panel1.TabIndex = 20;
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
            label7.TabIndex = 16;
            label7.Text = "Thời trang Vintage";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.Snow;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            button2.ForeColor = Color.FromArgb(128, 64, 0);
            button2.Location = new Point(37, 453);
            button2.Name = "button2";
            button2.Size = new Size(215, 43);
            button2.TabIndex = 12;
            button2.Text = "\U0001f9fe Hoá đơn (Chi tiết)";
            button2.UseVisualStyleBackColor = false;
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
            button5.Font = new Font("Segoe UI", 12F);
            button5.Location = new Point(37, 266);
            button5.Name = "button5";
            button5.Size = new Size(215, 43);
            button5.TabIndex = 9;
            button5.Text = "👕 Sản phẩm";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
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
            // frmHoaDon_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(984, 561);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnLuuHoaDon);
            Controls.Add(btnThoat);
            Controls.Add(btnInHoaDon);
            Controls.Add(dataGridView);
            Name = "frmHoaDon_ChiTiet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hoá đơn Chi tiết";
            Load += frmHoaDon_ChiTiet_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label label4;
        private ComboBox cboSanPham;
        private DataGridView dataGridView;
        private GroupBox groupBox1;
        private ComboBox cboKhachHang;
        private ComboBox cboNhanVien;
        private Label label3;
        private Button btnThoat;
        private Button btnInHoaDon;
        private Button btnLuuHoaDon;
        private Label label1;
        private Button btnXoa;
        private Button btnXacNhanBan;
        private NumericUpDown numDonGiaBan;
        private NumericUpDown numSoLuongBan;
        private Label label6;
        private Label label5;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn DonGiaBan;
        private DataGridViewTextBoxColumn SoLuongBan;
        private DataGridViewTextBoxColumn ThanhTien;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label LabelMaHD;
        private Label label2;
        private Label label7;
    }
}