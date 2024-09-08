namespace XemLaiHoaDon
{
    partial class FrmXemLai
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lvChiTietDonHang = new System.Windows.Forms.ListView();
			this.clhID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clhMaHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clhTenMatHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clhGiaBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clhSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clhThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clhGhiChu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.txtGiamGia = new System.Windows.Forms.TextBox();
			this.txtTongTien = new System.Windows.Forms.TextBox();
			this.txtPhiShip = new System.Windows.Forms.TextBox();
			this.txtTienHang = new System.Windows.Forms.TextBox();
			this.txtTienThue = new System.Windows.Forms.TextBox();
			this.txtGhiChu = new System.Windows.Forms.TextBox();
			this.btnInHoaDon = new System.Windows.Forms.Button();
			this.btnHuyDon = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.cbTrangThai = new System.Windows.Forms.ComboBox();
			this.txtKhachHang = new System.Windows.Forms.TextBox();
			this.txtNguoiNhan = new System.Windows.Forms.TextBox();
			this.txtSdt = new System.Windows.Forms.TextBox();
			this.txtNgayGioGiao = new System.Windows.Forms.TextBox();
			this.txtDCKhach = new System.Windows.Forms.TextBox();
			this.txtDCGiao = new System.Windows.Forms.TextBox();
			this.lblTongTien = new System.Windows.Forms.Label();
			this.txtNgayLap = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Thông tin khách";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "Họ tên khách";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "Tên người nhận";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(296, 37);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 16);
			this.label4.TabIndex = 0;
			this.label4.Text = "Số điện thoại";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(296, 67);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(92, 16);
			this.label5.TabIndex = 0;
			this.label5.Text = "Ngày giờ giao";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(610, 37);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(86, 16);
			this.label6.TabIndex = 0;
			this.label6.Text = "Địa chỉ khách";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(610, 67);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(110, 16);
			this.label7.TabIndex = 0;
			this.label7.Text = "Địa chỉ giao hàng";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(9, 107);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(105, 16);
			this.label8.TabIndex = 0;
			this.label8.Text = "Chi tiết đơn hàng";
			// 
			// lvChiTietDonHang
			// 
			this.lvChiTietDonHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhID,
            this.clhMaHang,
            this.clhTenMatHang,
            this.clhGiaBan,
            this.clhSoLuong,
            this.clhThanhTien,
            this.clhGhiChu});
			this.lvChiTietDonHang.GridLines = true;
			this.lvChiTietDonHang.HideSelection = false;
			this.lvChiTietDonHang.Location = new System.Drawing.Point(12, 140);
			this.lvChiTietDonHang.Name = "lvChiTietDonHang";
			this.lvChiTietDonHang.Size = new System.Drawing.Size(886, 226);
			this.lvChiTietDonHang.TabIndex = 1;
			this.lvChiTietDonHang.UseCompatibleStateImageBehavior = false;
			this.lvChiTietDonHang.View = System.Windows.Forms.View.Details;
			// 
			// clhID
			// 
			this.clhID.Text = "ID";
			// 
			// clhMaHang
			// 
			this.clhMaHang.Text = "Mã hàng";
			this.clhMaHang.Width = 94;
			// 
			// clhTenMatHang
			// 
			this.clhTenMatHang.Text = "Tên mặt hàng";
			this.clhTenMatHang.Width = 160;
			// 
			// clhGiaBan
			// 
			this.clhGiaBan.Text = "Giá bán";
			this.clhGiaBan.Width = 90;
			// 
			// clhSoLuong
			// 
			this.clhSoLuong.Text = "Số lượng";
			this.clhSoLuong.Width = 117;
			// 
			// clhThanhTien
			// 
			this.clhThanhTien.Text = "Thành tiền";
			this.clhThanhTien.Width = 111;
			// 
			// clhGhiChu
			// 
			this.clhGhiChu.Text = "Ghi chú";
			this.clhGhiChu.Width = 248;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(12, 382);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(114, 16);
			this.label9.TabIndex = 0;
			this.label9.Text = "Thông tin hóa đơn";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(12, 414);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(62, 16);
			this.label10.TabIndex = 0;
			this.label10.Text = "Ngày lập";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(12, 447);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(61, 16);
			this.label11.TabIndex = 0;
			this.label11.Text = "Giảm giá";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(12, 482);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(98, 16);
			this.label12.TabIndex = 0;
			this.label12.Text = "Tổng thành tiền";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(12, 513);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(51, 16);
			this.label13.TabIndex = 0;
			this.label13.Text = "Ghi chú";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(335, 415);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(67, 16);
			this.label14.TabIndex = 0;
			this.label14.Text = "Trạng thái";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(335, 448);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(54, 16);
			this.label15.TabIndex = 0;
			this.label15.Text = "Phí ship";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(668, 413);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(67, 16);
			this.label16.TabIndex = 0;
			this.label16.Text = "Tiền hàng";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(668, 446);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(62, 16);
			this.label17.TabIndex = 0;
			this.label17.Text = "Tiền thuế";
			// 
			// txtGiamGia
			// 
			this.txtGiamGia.Location = new System.Drawing.Point(140, 442);
			this.txtGiamGia.Name = "txtGiamGia";
			this.txtGiamGia.ReadOnly = true;
			this.txtGiamGia.Size = new System.Drawing.Size(188, 22);
			this.txtGiamGia.TabIndex = 2;
			// 
			// txtTongTien
			// 
			this.txtTongTien.Location = new System.Drawing.Point(140, 477);
			this.txtTongTien.Name = "txtTongTien";
			this.txtTongTien.ReadOnly = true;
			this.txtTongTien.Size = new System.Drawing.Size(188, 22);
			this.txtTongTien.TabIndex = 2;
			// 
			// txtPhiShip
			// 
			this.txtPhiShip.Location = new System.Drawing.Point(407, 443);
			this.txtPhiShip.Name = "txtPhiShip";
			this.txtPhiShip.ReadOnly = true;
			this.txtPhiShip.Size = new System.Drawing.Size(207, 22);
			this.txtPhiShip.TabIndex = 2;
			// 
			// txtTienHang
			// 
			this.txtTienHang.Location = new System.Drawing.Point(741, 414);
			this.txtTienHang.Name = "txtTienHang";
			this.txtTienHang.ReadOnly = true;
			this.txtTienHang.Size = new System.Drawing.Size(157, 22);
			this.txtTienHang.TabIndex = 2;
			this.txtTienHang.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// txtTienThue
			// 
			this.txtTienThue.Location = new System.Drawing.Point(741, 448);
			this.txtTienThue.Name = "txtTienThue";
			this.txtTienThue.ReadOnly = true;
			this.txtTienThue.Size = new System.Drawing.Size(157, 22);
			this.txtTienThue.TabIndex = 2;
			// 
			// txtGhiChu
			// 
			this.txtGhiChu.Location = new System.Drawing.Point(140, 505);
			this.txtGhiChu.Name = "txtGhiChu";
			this.txtGhiChu.Size = new System.Drawing.Size(758, 22);
			this.txtGhiChu.TabIndex = 2;
			// 
			// btnInHoaDon
			// 
			this.btnInHoaDon.Location = new System.Drawing.Point(598, 563);
			this.btnInHoaDon.Name = "btnInHoaDon";
			this.btnInHoaDon.Size = new System.Drawing.Size(98, 23);
			this.btnInHoaDon.TabIndex = 3;
			this.btnInHoaDon.Text = "In hóa đơn";
			this.btnInHoaDon.UseVisualStyleBackColor = true;
			// 
			// btnHuyDon
			// 
			this.btnHuyDon.Location = new System.Drawing.Point(716, 563);
			this.btnHuyDon.Name = "btnHuyDon";
			this.btnHuyDon.Size = new System.Drawing.Size(75, 23);
			this.btnHuyDon.TabIndex = 3;
			this.btnHuyDon.Text = "Hủy đơn";
			this.btnHuyDon.UseVisualStyleBackColor = true;
			// 
			// btnLuu
			// 
			this.btnLuu.Location = new System.Drawing.Point(821, 563);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(75, 23);
			this.btnLuu.TabIndex = 3;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = true;
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(921, 563);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(75, 23);
			this.btnThoat.TabIndex = 3;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			// 
			// cbTrangThai
			// 
			this.cbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTrangThai.FormattingEnabled = true;
			this.cbTrangThai.Location = new System.Drawing.Point(408, 407);
			this.cbTrangThai.Name = "cbTrangThai";
			this.cbTrangThai.Size = new System.Drawing.Size(206, 24);
			this.cbTrangThai.TabIndex = 4;
			// 
			// txtKhachHang
			// 
			this.txtKhachHang.Location = new System.Drawing.Point(123, 37);
			this.txtKhachHang.Name = "txtKhachHang";
			this.txtKhachHang.ReadOnly = true;
			this.txtKhachHang.Size = new System.Drawing.Size(167, 22);
			this.txtKhachHang.TabIndex = 5;
			// 
			// txtNguoiNhan
			// 
			this.txtNguoiNhan.Location = new System.Drawing.Point(123, 64);
			this.txtNguoiNhan.Name = "txtNguoiNhan";
			this.txtNguoiNhan.ReadOnly = true;
			this.txtNguoiNhan.Size = new System.Drawing.Size(167, 22);
			this.txtNguoiNhan.TabIndex = 5;
			// 
			// txtSdt
			// 
			this.txtSdt.Location = new System.Drawing.Point(405, 34);
			this.txtSdt.Name = "txtSdt";
			this.txtSdt.ReadOnly = true;
			this.txtSdt.Size = new System.Drawing.Size(167, 22);
			this.txtSdt.TabIndex = 5;
			// 
			// txtNgayGioGiao
			// 
			this.txtNgayGioGiao.Location = new System.Drawing.Point(405, 61);
			this.txtNgayGioGiao.Name = "txtNgayGioGiao";
			this.txtNgayGioGiao.ReadOnly = true;
			this.txtNgayGioGiao.Size = new System.Drawing.Size(167, 22);
			this.txtNgayGioGiao.TabIndex = 5;
			// 
			// txtDCKhach
			// 
			this.txtDCKhach.Location = new System.Drawing.Point(731, 34);
			this.txtDCKhach.Name = "txtDCKhach";
			this.txtDCKhach.ReadOnly = true;
			this.txtDCKhach.Size = new System.Drawing.Size(167, 22);
			this.txtDCKhach.TabIndex = 5;
			// 
			// txtDCGiao
			// 
			this.txtDCGiao.Location = new System.Drawing.Point(731, 61);
			this.txtDCGiao.Name = "txtDCGiao";
			this.txtDCGiao.ReadOnly = true;
			this.txtDCGiao.Size = new System.Drawing.Size(167, 22);
			this.txtDCGiao.TabIndex = 5;
			// 
			// lblTongTien
			// 
			this.lblTongTien.AutoSize = true;
			this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTongTien.ForeColor = System.Drawing.Color.Red;
			this.lblTongTien.Location = new System.Drawing.Point(337, 482);
			this.lblTongTien.Name = "lblTongTien";
			this.lblTongTien.Size = new System.Drawing.Size(15, 16);
			this.lblTongTien.TabIndex = 6;
			this.lblTongTien.Text = "0";
			// 
			// txtNgayLap
			// 
			this.txtNgayLap.Location = new System.Drawing.Point(140, 407);
			this.txtNgayLap.Name = "txtNgayLap";
			this.txtNgayLap.ReadOnly = true;
			this.txtNgayLap.Size = new System.Drawing.Size(188, 22);
			this.txtNgayLap.TabIndex = 7;
			// 
			// FrmXemLai
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1052, 613);
			this.Controls.Add(this.txtNgayLap);
			this.Controls.Add(this.lblTongTien);
			this.Controls.Add(this.txtDCGiao);
			this.Controls.Add(this.txtNgayGioGiao);
			this.Controls.Add(this.txtNguoiNhan);
			this.Controls.Add(this.txtDCKhach);
			this.Controls.Add(this.txtSdt);
			this.Controls.Add(this.txtKhachHang);
			this.Controls.Add(this.cbTrangThai);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnLuu);
			this.Controls.Add(this.btnHuyDon);
			this.Controls.Add(this.btnInHoaDon);
			this.Controls.Add(this.txtGhiChu);
			this.Controls.Add(this.txtTongTien);
			this.Controls.Add(this.txtTienThue);
			this.Controls.Add(this.txtTienHang);
			this.Controls.Add(this.txtPhiShip);
			this.Controls.Add(this.txtGiamGia);
			this.Controls.Add(this.lvChiTietDonHang);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmXemLai";
			this.Text = "Chi tiết đơn hàng";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView lvChiTietDonHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtPhiShip;
        private System.Windows.Forms.TextBox txtTienHang;
        private System.Windows.Forms.TextBox txtTienThue;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnHuyDon;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.TextBox txtNguoiNhan;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtNgayGioGiao;
        private System.Windows.Forms.TextBox txtDCKhach;
        private System.Windows.Forms.TextBox txtDCGiao;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.ColumnHeader clhID;
        private System.Windows.Forms.ColumnHeader clhMaHang;
        private System.Windows.Forms.ColumnHeader clhTenMatHang;
        private System.Windows.Forms.ColumnHeader clhGiaBan;
        private System.Windows.Forms.ColumnHeader clhSoLuong;
        private System.Windows.Forms.ColumnHeader clhThanhTien;
        private System.Windows.Forms.ColumnHeader clhGhiChu;
        private System.Windows.Forms.TextBox txtNgayLap;
    }
}