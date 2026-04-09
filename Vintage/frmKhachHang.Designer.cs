namespace Vintage
{
    partial class frmKhachHang
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
            HoVaTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            txtDiaChi = new TextBox();
            txtDienThoai = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnXoa = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            txtHoVaTen = new TextBox();
            label1 = new Label();
            btnHuyBo = new Button();
            btnThem = new Button();
            btnNhap = new Button();
            btnXuat = new Button();
            btnThoat = new Button();
            panel1 = new Panel();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTen, DienThoai, DiaChi });
            dataGridView.Location = new Point(307, 266);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(659, 239);
            dataGridView.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.FillWeight = 30F;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // HoVaTen
            // 
            HoVaTen.DataPropertyName = "HoVaTen";
            HoVaTen.FillWeight = 120F;
            HoVaTen.HeaderText = "Họ và tên";
            HoVaTen.Name = "HoVaTen";
            // 
            // DienThoai
            // 
            DienThoai.DataPropertyName = "DienThoai";
            DienThoai.FillWeight = 80F;
            DienThoai.HeaderText = "Điện thoại";
            DienThoai.Name = "DienThoai";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.FillWeight = 150F;
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.Name = "DiaChi";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Location = new Point(307, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(659, 151);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(143, 62);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(431, 23);
            txtDiaChi.TabIndex = 11;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(414, 33);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(160, 23);
            txtDienThoai.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(344, 36);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 9;
            label3.Text = "Điện thoại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 65);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 8;
            label2.Text = "Địa chỉ:";
            // 
            // btnXoa
            // 
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(252, 109);
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
            btnSua.Location = new Point(143, 109);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(103, 27);
            btnSua.TabIndex = 3;
            btnSua.Text = "🖊️Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLuu
            // 
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(435, 109);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(103, 27);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(143, 33);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(183, 23);
            txtHoVaTen.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 36);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên (*):";
            // 
            // btnHuyBo
            // 
            btnHuyBo.FlatStyle = FlatStyle.Flat;
            btnHuyBo.Location = new Point(544, 109);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(103, 27);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "Huỷ bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnThem
            // 
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.FromArgb(128, 64, 0);
            btnThem.Location = new Point(34, 109);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(103, 27);
            btnThem.TabIndex = 2;
            btnThem.Text = "➕Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnNhap
            // 
            btnNhap.FlatStyle = FlatStyle.Flat;
            btnNhap.ForeColor = Color.FromArgb(0, 64, 0);
            btnNhap.Location = new Point(719, 511);
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
            btnXuat.Location = new Point(846, 511);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(121, 27);
            btnXuat.TabIndex = 12;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnThoat
            // 
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Location = new Point(307, 522);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(103, 27);
            btnThoat.TabIndex = 17;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
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
            panel1.TabIndex = 18;
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
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            button4.ForeColor = Color.FromArgb(128, 64, 0);
            button4.Location = new Point(37, 327);
            button4.Name = "button4";
            button4.Size = new Size(215, 43);
            button4.TabIndex = 10;
            button4.Text = "\U0001f9d1‍\U0001f91d‍\U0001f9d1 Khách hàng";
            button4.UseVisualStyleBackColor = false;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(128, 64, 0);
            label4.Location = new Point(307, 29);
            label4.Name = "label4";
            label4.Size = new Size(230, 45);
            label4.TabIndex = 18;
            label4.Text = "KHÁCH HÀNG";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.System;
            label7.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label7.ForeColor = SystemColors.Window;
            label7.Location = new Point(37, 51);
            label7.Name = "label7";
            label7.Size = new Size(199, 30);
            label7.TabIndex = 19;
            label7.Text = "Thời trang Vintage";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(984, 561);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(btnThoat);
            Controls.Add(btnNhap);
            Controls.Add(btnXuat);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView);
            Name = "frmKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Khách hàng";
            Load += frmKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView;
        private GroupBox groupBox1;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtHoVaTen;
        private Label label1;
        private Label label2;
        private TextBox txtDienThoai;
        private Label label3;
        private TextBox txtDiaChi;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private Button btnNhap;
        private Button btnXuat;
        private Button btnThoat;
        private Panel panel1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label7;
    }
}