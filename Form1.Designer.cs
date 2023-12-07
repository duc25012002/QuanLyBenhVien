namespace QuanLyBenhVien
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label112 = new Label();
            edtMaBenhAn = new TextBox();
            label1 = new Label();
            edtHoTen = new TextBox();
            label3 = new Label();
            edtGioiTinh = new TextBox();
            label4 = new Label();
            edtSoNgayDieuTri = new TextBox();
            label5 = new Label();
            edtSoTienPhaiTra = new TextBox();
            label6 = new Label();
            edtDiaChi = new TextBox();
            label7 = new Label();
            pickerNgayNhapVien = new DateTimePicker();
            grvBenhNhan = new DataGridView();
            btnCapNhat = new Button();
            btnLoc = new Button();
            ((System.ComponentModel.ISupportInitialize)grvBenhNhan).BeginInit();
            SuspendLayout();
            // 
            // label112
            // 
            label112.AutoSize = true;
            label112.Location = new Point(9, 24);
            label112.Name = "label112";
            label112.Size = new Size(70, 15);
            label112.TabIndex = 0;
            label112.Text = "Mã bệnh án";
            // 
            // edtMaBenhAn
            // 
            edtMaBenhAn.Location = new Point(121, 24);
            edtMaBenhAn.Name = "edtMaBenhAn";
            edtMaBenhAn.Size = new Size(183, 23);
            edtMaBenhAn.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 80);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Họ tên";
            // 
            // edtHoTen
            // 
            edtHoTen.Location = new Point(121, 80);
            edtHoTen.Name = "edtHoTen";
            edtHoTen.Size = new Size(183, 23);
            edtHoTen.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 139);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 0;
            label3.Text = "Giới tính";
            // 
            // edtGioiTinh
            // 
            edtGioiTinh.Location = new Point(121, 139);
            edtGioiTinh.Name = "edtGioiTinh";
            edtGioiTinh.Size = new Size(183, 23);
            edtGioiTinh.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 202);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 0;
            label4.Text = "Số ngày điều trị";
            // 
            // edtSoNgayDieuTri
            // 
            edtSoNgayDieuTri.Location = new Point(121, 202);
            edtSoNgayDieuTri.Name = "edtSoNgayDieuTri";
            edtSoNgayDieuTri.Size = new Size(183, 23);
            edtSoNgayDieuTri.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(464, 88);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 0;
            label5.Text = "Số tiền phải trả";
            // 
            // edtSoTienPhaiTra
            // 
            edtSoTienPhaiTra.Location = new Point(563, 83);
            edtSoTienPhaiTra.Name = "edtSoTienPhaiTra";
            edtSoTienPhaiTra.Size = new Size(200, 23);
            edtSoTienPhaiTra.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(464, 150);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 0;
            label6.Text = "Địa chỉ";
            // 
            // edtDiaChi
            // 
            edtDiaChi.Location = new Point(563, 142);
            edtDiaChi.Name = "edtDiaChi";
            edtDiaChi.Size = new Size(200, 23);
            edtDiaChi.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(464, 27);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 0;
            label7.Text = "Ngày Nhập Viện";
            // 
            // pickerNgayNhapVien
            // 
            pickerNgayNhapVien.Location = new Point(563, 27);
            pickerNgayNhapVien.Name = "pickerNgayNhapVien";
            pickerNgayNhapVien.Size = new Size(200, 23);
            pickerNgayNhapVien.TabIndex = 2;
            // 
            // grvBenhNhan
            // 
            grvBenhNhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grvBenhNhan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grvBenhNhan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvBenhNhan.Location = new Point(19, 253);
            grvBenhNhan.Name = "grvBenhNhan";
            grvBenhNhan.RowTemplate.Height = 25;
            grvBenhNhan.Size = new Size(744, 238);
            grvBenhNhan.TabIndex = 3;
            grvBenhNhan.CellContentClick += grvBenhNhan_CellContentClick;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(301, 513);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(75, 23);
            btnCapNhat.TabIndex = 4;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnLoc
            // 
            btnLoc.Location = new Point(418, 513);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(75, 23);
            btnLoc.TabIndex = 4;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 616);
            Controls.Add(btnLoc);
            Controls.Add(btnCapNhat);
            Controls.Add(grvBenhNhan);
            Controls.Add(pickerNgayNhapVien);
            Controls.Add(edtDiaChi);
            Controls.Add(label6);
            Controls.Add(edtSoTienPhaiTra);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(edtSoNgayDieuTri);
            Controls.Add(label4);
            Controls.Add(edtGioiTinh);
            Controls.Add(label3);
            Controls.Add(edtHoTen);
            Controls.Add(label1);
            Controls.Add(edtMaBenhAn);
            Controls.Add(label112);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)grvBenhNhan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label112;
        private TextBox edtMaBenhAn;
        private Label label1;
        private TextBox edtHoTen;
        private Label label3;
        private TextBox edtGioiTinh;
        private Label label4;
        private TextBox edtSoNgayDieuTri;
        private Label label5;
        private TextBox edtSoTienPhaiTra;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private DateTimePicker pickerNgayNhapVien;
        private DataGridView grvBenhNhan;
        private Button btnCapNhat;
        private Button btnLoc;
        private TextBox edtDiaChi;
    }
}