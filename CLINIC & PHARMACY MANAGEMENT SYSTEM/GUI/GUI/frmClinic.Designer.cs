namespace ClinicSystem.GUI
{
    partial class frmClinic
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabTiepNhanKeDon = new System.Windows.Forms.TabPage();
            this.grpKeDon = new System.Windows.Forms.GroupBox();
            this.btnLuuXuatDon = new System.Windows.Forms.Button();
            this.lblTongTienDon = new System.Windows.Forms.Label();
            this.lblTongTienTxt = new System.Windows.Forms.Label();
            this.dgvChiTietDon = new System.Windows.Forms.DataGridView();
            this.btnThemThuoc = new System.Windows.Forms.Button();
            this.txtLieuDung = new System.Windows.Forms.TextBox();
            this.nudSoLuongThuoc = new System.Windows.Forms.NumericUpDown();
            this.cboThuoc = new System.Windows.Forms.ComboBox();
            this.nudTienKham = new System.Windows.Forms.NumericUpDown();
            this.txtChanDoan = new System.Windows.Forms.TextBox();
            this.lblLieuDung = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblChonThuoc = new System.Windows.Forms.Label();
            this.lblTienKham = new System.Windows.Forms.Label();
            this.lblChanDoan = new System.Windows.Forms.Label();
            this.grpTiepNhan = new System.Windows.Forms.GroupBox();
            this.cboHoSoKham = new System.Windows.Forms.ComboBox();
            this.lblChonHoSo = new System.Windows.Forms.Label();
            this.btnTiepNhan = new System.Windows.Forms.Button();
            this.txtTrieuChung = new System.Windows.Forms.TextBox();
            this.nudNamSinh = new System.Windows.Forms.NumericUpDown();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblTrieuChung = new System.Windows.Forms.Label();
            this.lblNamSinh = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.btnTimBN = new System.Windows.Forms.Button();
            this.txtTimSDT = new System.Windows.Forms.TextBox();
            this.lblTimSDT = new System.Windows.Forms.Label();
            this.tabThanhToan = new System.Windows.Forms.TabPage();
            this.grpChiTietHoaDon = new System.Windows.Forms.GroupBox();
            this.txtHoaDonPreview = new System.Windows.Forms.TextBox();
            this.dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.grpDanhSachDon = new System.Windows.Forms.GroupBox();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.dgvDonThuoc = new System.Windows.Forms.DataGridView();
            this.tabKhoThuoc = new System.Windows.Forms.TabPage();
            this.dgvKhoThuoc = new System.Windows.Forms.DataGridView();
            this.grpThongTinThuoc = new System.Windows.Forms.GroupBox();
            this.btnNhapThemKho = new System.Windows.Forms.Button();
            this.nudSoLuongNhapThem = new System.Windows.Forms.NumericUpDown();
            this.lblNhapThem = new System.Windows.Forms.Label();
            this.btnCapNhatGia = new System.Windows.Forms.Button();
            this.btnThemThuocMoi = new System.Windows.Forms.Button();
            this.nudSoLuongTon = new System.Windows.Forms.NumericUpDown();
            this.nudDonGiaThuoc = new System.Windows.Forms.NumericUpDown();
            this.cboDonViTinh = new System.Windows.Forms.ComboBox();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.lblSoLuongTon = new System.Windows.Forms.Label();
            this.lblDonGiaThuoc = new System.Windows.Forms.Label();
            this.lblDonViTinh = new System.Windows.Forms.Label();
            this.lblTenThuoc = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tabTiepNhanKeDon.SuspendLayout();
            this.grpKeDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienKham)).BeginInit();
            this.grpTiepNhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNamSinh)).BeginInit();
            this.tabThanhToan.SuspendLayout();
            this.grpChiTietHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).BeginInit();
            this.grpDanhSachDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonThuoc)).BeginInit();
            this.tabKhoThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoThuoc)).BeginInit();
            this.grpThongTinThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongNhapThem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGiaThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabTiepNhanKeDon);
            this.tabMain.Controls.Add(this.tabThanhToan);
            this.tabMain.Controls.Add(this.tabKhoThuoc);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(944, 591);
            this.tabMain.TabIndex = 0;
            // 
            // tabTiepNhanKeDon
            // 
            this.tabTiepNhanKeDon.Controls.Add(this.grpKeDon);
            this.tabTiepNhanKeDon.Controls.Add(this.grpTiepNhan);
            this.tabTiepNhanKeDon.Location = new System.Drawing.Point(4, 22);
            this.tabTiepNhanKeDon.Name = "tabTiepNhanKeDon";
            this.tabTiepNhanKeDon.Padding = new System.Windows.Forms.Padding(3);
            this.tabTiepNhanKeDon.Size = new System.Drawing.Size(936, 565);
            this.tabTiepNhanKeDon.TabIndex = 0;
            this.tabTiepNhanKeDon.Text = "Tiếp Nhận Bệnh Nhân & Kê Đơn Thuốc";
            this.tabTiepNhanKeDon.UseVisualStyleBackColor = true;
            // 
            // grpKeDon
            // 
            this.grpKeDon.Controls.Add(this.btnLuuXuatDon);
            this.grpKeDon.Controls.Add(this.lblTongTienDon);
            this.grpKeDon.Controls.Add(this.lblTongTienTxt);
            this.grpKeDon.Controls.Add(this.dgvChiTietDon);
            this.grpKeDon.Controls.Add(this.btnThemThuoc);
            this.grpKeDon.Controls.Add(this.txtLieuDung);
            this.grpKeDon.Controls.Add(this.nudSoLuongThuoc);
            this.grpKeDon.Controls.Add(this.cboThuoc);
            this.grpKeDon.Controls.Add(this.nudTienKham);
            this.grpKeDon.Controls.Add(this.txtChanDoan);
            this.grpKeDon.Controls.Add(this.lblLieuDung);
            this.grpKeDon.Controls.Add(this.lblSoLuong);
            this.grpKeDon.Controls.Add(this.lblChonThuoc);
            this.grpKeDon.Controls.Add(this.lblTienKham);
            this.grpKeDon.Controls.Add(this.lblChanDoan);
            this.grpKeDon.Location = new System.Drawing.Point(450, 10);
            this.grpKeDon.Name = "grpKeDon";
            this.grpKeDon.Size = new System.Drawing.Size(475, 545);
            this.grpKeDon.TabIndex = 1;
            this.grpKeDon.TabStop = false;
            this.grpKeDon.Text = "Khám Bệnh & Kê Đơn Thuốc (SqlTransaction)";
            // 
            // btnLuuXuatDon
            // 
            this.btnLuuXuatDon.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLuuXuatDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuXuatDon.Location = new System.Drawing.Point(255, 490);
            this.btnLuuXuatDon.Name = "btnLuuXuatDon";
            this.btnLuuXuatDon.Size = new System.Drawing.Size(205, 40);
            this.btnLuuXuatDon.TabIndex = 14;
            this.btnLuuXuatDon.Text = "Lưu && Xuất Đơn Thuốc";
            this.btnLuuXuatDon.UseVisualStyleBackColor = false;
            this.btnLuuXuatDon.Click += new System.EventHandler(this.btnLuuXuatDon_Click);
            // 
            // lblTongTienDon
            // 
            this.lblTongTienDon.AutoSize = true;
            this.lblTongTienDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienDon.ForeColor = System.Drawing.Color.Red;
            this.lblTongTienDon.Location = new System.Drawing.Point(100, 500);
            this.lblTongTienDon.Name = "lblTongTienDon";
            this.lblTongTienDon.Size = new System.Drawing.Size(102, 18);
            this.lblTongTienDon.TabIndex = 13;
            this.lblTongTienDon.Text = "100,000 VNĐ";
            // 
            // lblTongTienTxt
            // 
            this.lblTongTienTxt.AutoSize = true;
            this.lblTongTienTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienTxt.Location = new System.Drawing.Point(15, 502);
            this.lblTongTienTxt.Name = "lblTongTienTxt";
            this.lblTongTienTxt.Size = new System.Drawing.Size(79, 15);
            this.lblTongTienTxt.TabIndex = 12;
            this.lblTongTienTxt.Text = "Tổng chi phí:";
            // 
            // dgvChiTietDon
            // 
            this.dgvChiTietDon.AllowUserToAddRows = false;
            this.dgvChiTietDon.AllowUserToDeleteRows = false;
            this.dgvChiTietDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietDon.Location = new System.Drawing.Point(15, 210);
            this.dgvChiTietDon.Name = "dgvChiTietDon";
            this.dgvChiTietDon.ReadOnly = true;
            this.dgvChiTietDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietDon.Size = new System.Drawing.Size(445, 265);
            this.dgvChiTietDon.TabIndex = 11;
            // 
            // btnThemThuoc
            // 
            this.btnThemThuoc.Location = new System.Drawing.Point(345, 170);
            this.btnThemThuoc.Name = "btnThemThuoc";
            this.btnThemThuoc.Size = new System.Drawing.Size(115, 28);
            this.btnThemThuoc.TabIndex = 10;
            this.btnThemThuoc.Text = "Thêm Thuốc";
            this.btnThemThuoc.UseVisualStyleBackColor = true;
            this.btnThemThuoc.Click += new System.EventHandler(this.btnThemThuoc_Click);
            // 
            // txtLieuDung
            // 
            this.txtLieuDung.Location = new System.Drawing.Point(95, 135);
            this.txtLieuDung.Name = "txtLieuDung";
            this.txtLieuDung.Size = new System.Drawing.Size(365, 20);
            this.txtLieuDung.TabIndex = 9;
            this.txtLieuDung.Text = "Sáng 1 viên, Chiều 1 viên sau ăn";
            // 
            // nudSoLuongThuoc
            // 
            this.nudSoLuongThuoc.Location = new System.Drawing.Point(390, 95);
            this.nudSoLuongThuoc.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.nudSoLuongThuoc.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudSoLuongThuoc.Name = "nudSoLuongThuoc";
            this.nudSoLuongThuoc.Size = new System.Drawing.Size(70, 20);
            this.nudSoLuongThuoc.TabIndex = 8;
            this.nudSoLuongThuoc.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboThuoc
            // 
            this.cboThuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThuoc.FormattingEnabled = true;
            this.cboThuoc.Location = new System.Drawing.Point(95, 95);
            this.cboThuoc.Name = "cboThuoc";
            this.cboThuoc.Size = new System.Drawing.Size(220, 21);
            this.cboThuoc.TabIndex = 7;
            // 
            // nudTienKham
            // 
            this.nudTienKham.Increment = new decimal(new int[] { 10000, 0, 0, 0 });
            this.nudTienKham.Location = new System.Drawing.Point(95, 60);
            this.nudTienKham.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.nudTienKham.Name = "nudTienKham";
            this.nudTienKham.Size = new System.Drawing.Size(160, 20);
            this.nudTienKham.TabIndex = 6;
            this.nudTienKham.Value = new decimal(new int[] { 100000, 0, 0, 0 });
            this.nudTienKham.ValueChanged += new System.EventHandler(this.nudTienKham_ValueChanged);
            // 
            // txtChanDoan
            // 
            this.txtChanDoan.Location = new System.Drawing.Point(95, 25);
            this.txtChanDoan.Name = "txtChanDoan";
            this.txtChanDoan.Size = new System.Drawing.Size(365, 20);
            this.txtChanDoan.TabIndex = 5;
            // 
            // lblLieuDung
            // 
            this.lblLieuDung.AutoSize = true;
            this.lblLieuDung.Location = new System.Drawing.Point(15, 138);
            this.lblLieuDung.Name = "lblLieuDung";
            this.lblLieuDung.Size = new System.Drawing.Size(57, 13);
            this.lblLieuDung.TabIndex = 4;
            this.lblLieuDung.Text = "Liều dùng:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(325, 98);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(52, 13);
            this.lblSoLuong.TabIndex = 3;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // lblChonThuoc
            // 
            this.lblChonThuoc.AutoSize = true;
            this.lblChonThuoc.Location = new System.Drawing.Point(15, 98);
            this.lblChonThuoc.Name = "lblChonThuoc";
            this.lblChonThuoc.Size = new System.Drawing.Size(65, 13);
            this.lblChonThuoc.TabIndex = 2;
            this.lblChonThuoc.Text = "Chọn thuốc:";
            // 
            // lblTienKham
            // 
            this.lblTienKham.AutoSize = true;
            this.lblTienKham.Location = new System.Drawing.Point(15, 63);
            this.lblTienKham.Name = "lblTienKham";
            this.lblTienKham.Size = new System.Drawing.Size(57, 13);
            this.lblTienKham.TabIndex = 1;
            this.lblTienKham.Text = "Tiền khám:";
            // 
            // lblChanDoan
            // 
            this.lblChanDoan.AutoSize = true;
            this.lblChanDoan.Location = new System.Drawing.Point(15, 28);
            this.lblChanDoan.Name = "lblChanDoan";
            this.lblChanDoan.Size = new System.Drawing.Size(62, 13);
            this.lblChanDoan.TabIndex = 0;
            this.lblChanDoan.Text = "Chẩn đoán:";
            // 
            // grpTiepNhan
            // 
            this.grpTiepNhan.Controls.Add(this.cboHoSoKham);
            this.grpTiepNhan.Controls.Add(this.lblChonHoSo);
            this.grpTiepNhan.Controls.Add(this.btnTiepNhan);
            this.grpTiepNhan.Controls.Add(this.txtTrieuChung);
            this.grpTiepNhan.Controls.Add(this.nudNamSinh);
            this.grpTiepNhan.Controls.Add(this.txtSDT);
            this.grpTiepNhan.Controls.Add(this.txtHoTen);
            this.grpTiepNhan.Controls.Add(this.lblTrieuChung);
            this.grpTiepNhan.Controls.Add(this.lblNamSinh);
            this.grpTiepNhan.Controls.Add(this.lblSDT);
            this.grpTiepNhan.Controls.Add(this.lblHoTen);
            this.grpTiepNhan.Controls.Add(this.btnTimBN);
            this.grpTiepNhan.Controls.Add(this.txtTimSDT);
            this.grpTiepNhan.Controls.Add(this.lblTimSDT);
            this.grpTiepNhan.Location = new System.Drawing.Point(10, 10);
            this.grpTiepNhan.Name = "grpTiepNhan";
            this.grpTiepNhan.Size = new System.Drawing.Size(430, 545);
            this.grpTiepNhan.TabIndex = 0;
            this.grpTiepNhan.TabStop = false;
            this.grpTiepNhan.Text = "Tra Cứu & Tiếp Nhận Bệnh Nhân";
            // 
            // cboHoSoKham
            // 
            this.cboHoSoKham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHoSoKham.FormattingEnabled = true;
            this.cboHoSoKham.Location = new System.Drawing.Point(15, 450);
            this.cboHoSoKham.Name = "cboHoSoKham";
            this.cboHoSoKham.Size = new System.Drawing.Size(400, 21);
            this.cboHoSoKham.TabIndex = 13;
            // 
            // lblChonHoSo
            // 
            this.lblChonHoSo.AutoSize = true;
            this.lblChonHoSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonHoSo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblChonHoSo.Location = new System.Drawing.Point(15, 425);
            this.lblChonHoSo.Name = "lblChonHoSo";
            this.lblChonHoSo.Size = new System.Drawing.Size(222, 13);
            this.lblChonHoSo.TabIndex = 12;
            this.lblChonHoSo.Text = "Hồ Sơ Khám Đang Chọn Để Kê Đơn:";
            // 
            // btnTiepNhan
            // 
            this.btnTiepNhan.BackColor = System.Drawing.Color.LightGreen;
            this.btnTiepNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiepNhan.Location = new System.Drawing.Point(105, 345);
            this.btnTiepNhan.Name = "btnTiepNhan";
            this.btnTiepNhan.Size = new System.Drawing.Size(310, 38);
            this.btnTiepNhan.TabIndex = 11;
            this.btnTiepNhan.Text = "Tiếp Nhận && Tạo Hồ Sơ Khám";
            this.btnTiepNhan.UseVisualStyleBackColor = false;
            this.btnTiepNhan.Click += new System.EventHandler(this.btnTiepNhan_Click);
            // 
            // txtTrieuChung
            // 
            this.txtTrieuChung.Location = new System.Drawing.Point(105, 195);
            this.txtTrieuChung.Multiline = true;
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.Size = new System.Drawing.Size(310, 130);
            this.txtTrieuChung.TabIndex = 10;
            // 
            // nudNamSinh
            // 
            this.nudNamSinh.Location = new System.Drawing.Point(105, 155);
            this.nudNamSinh.Maximum = new decimal(new int[] { 2026, 0, 0, 0 });
            this.nudNamSinh.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            this.nudNamSinh.Name = "nudNamSinh";
            this.nudNamSinh.Size = new System.Drawing.Size(120, 20);
            this.nudNamSinh.TabIndex = 9;
            this.nudNamSinh.Value = new decimal(new int[] { 1995, 0, 0, 0 });
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(105, 115);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(310, 20);
            this.txtSDT.TabIndex = 8;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(105, 75);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(310, 20);
            this.txtHoTen.TabIndex = 7;
            // 
            // lblTrieuChung
            // 
            this.lblTrieuChung.AutoSize = true;
            this.lblTrieuChung.Location = new System.Drawing.Point(15, 198);
            this.lblTrieuChung.Name = "lblTrieuChung";
            this.lblTrieuChung.Size = new System.Drawing.Size(67, 13);
            this.lblTrieuChung.TabIndex = 6;
            this.lblTrieuChung.Text = "Triệu chứng:";
            // 
            // lblNamSinh
            // 
            this.lblNamSinh.AutoSize = true;
            this.lblNamSinh.Location = new System.Drawing.Point(15, 158);
            this.lblNamSinh.Name = "lblNamSinh";
            this.lblNamSinh.Size = new System.Drawing.Size(55, 13);
            this.lblNamSinh.TabIndex = 5;
            this.lblNamSinh.Text = "Năm sinh:";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(15, 118);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(73, 13);
            this.lblSDT.TabIndex = 4;
            this.lblSDT.Text = "Số điện thoại:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(15, 78);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(61, 13);
            this.lblHoTen.TabIndex = 3;
            this.lblHoTen.Text = "Họ tên BN:";
            // 
            // btnTimBN
            // 
            this.btnTimBN.Location = new System.Drawing.Point(330, 25);
            this.btnTimBN.Name = "btnTimBN";
            this.btnTimBN.Size = new System.Drawing.Size(85, 25);
            this.btnTimBN.TabIndex = 2;
            this.btnTimBN.Text = "Tra cứu";
            this.btnTimBN.UseVisualStyleBackColor = true;
            this.btnTimBN.Click += new System.EventHandler(this.btnTimBN_Click);
            // 
            // txtTimSDT
            // 
            this.txtTimSDT.Location = new System.Drawing.Point(105, 27);
            this.txtTimSDT.Name = "txtTimSDT";
            this.txtTimSDT.Size = new System.Drawing.Size(215, 20);
            this.txtTimSDT.TabIndex = 1;
            // 
            // lblTimSDT
            // 
            this.lblTimSDT.AutoSize = true;
            this.lblTimSDT.Location = new System.Drawing.Point(15, 30);
            this.lblTimSDT.Name = "lblTimSDT";
            this.lblTimSDT.Size = new System.Drawing.Size(52, 13);
            this.lblTimSDT.TabIndex = 0;
            this.lblTimSDT.Text = "Tìm SĐT:";
            // 
            // tabThanhToan
            // 
            this.tabThanhToan.Controls.Add(this.grpChiTietHoaDon);
            this.tabThanhToan.Controls.Add(this.grpDanhSachDon);
            this.tabThanhToan.Location = new System.Drawing.Point(4, 22);
            this.tabThanhToan.Name = "tabThanhToan";
            this.tabThanhToan.Padding = new System.Windows.Forms.Padding(3);
            this.tabThanhToan.Size = new System.Drawing.Size(936, 565);
            this.tabThanhToan.TabIndex = 1;
            this.tabThanhToan.Text = "Thanh Toán & In Hóa Đơn Viện Phí";
            this.tabThanhToan.UseVisualStyleBackColor = true;
            // 
            // grpChiTietHoaDon
            // 
            this.grpChiTietHoaDon.Controls.Add(this.txtHoaDonPreview);
            this.grpChiTietHoaDon.Controls.Add(this.dgvChiTietHoaDon);
            this.grpChiTietHoaDon.Location = new System.Drawing.Point(10, 265);
            this.grpChiTietHoaDon.Name = "grpChiTietHoaDon";
            this.grpChiTietHoaDon.Size = new System.Drawing.Size(915, 290);
            this.grpChiTietHoaDon.TabIndex = 1;
            this.grpChiTietHoaDon.TabStop = false;
            this.grpChiTietHoaDon.Text = "Chi Tiết Đơn Thuốc && Bản In Hóa Đơn";
            // 
            // txtHoaDonPreview
            // 
            this.txtHoaDonPreview.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoaDonPreview.Location = new System.Drawing.Point(465, 20);
            this.txtHoaDonPreview.Multiline = true;
            this.txtHoaDonPreview.Name = "txtHoaDonPreview";
            this.txtHoaDonPreview.ReadOnly = true;
            this.txtHoaDonPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHoaDonPreview.Size = new System.Drawing.Size(440, 255);
            this.txtHoaDonPreview.TabIndex = 1;
            // 
            // dgvChiTietHoaDon
            // 
            this.dgvChiTietHoaDon.AllowUserToAddRows = false;
            this.dgvChiTietHoaDon.AllowUserToDeleteRows = false;
            this.dgvChiTietHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHoaDon.Location = new System.Drawing.Point(10, 20);
            this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            this.dgvChiTietHoaDon.ReadOnly = true;
            this.dgvChiTietHoaDon.Size = new System.Drawing.Size(445, 255);
            this.dgvChiTietHoaDon.TabIndex = 0;
            // 
            // grpDanhSachDon
            // 
            this.grpDanhSachDon.Controls.Add(this.btnInHoaDon);
            this.grpDanhSachDon.Controls.Add(this.btnThanhToan);
            this.grpDanhSachDon.Controls.Add(this.dgvDonThuoc);
            this.grpDanhSachDon.Location = new System.Drawing.Point(10, 10);
            this.grpDanhSachDon.Name = "grpDanhSachDon";
            this.grpDanhSachDon.Size = new System.Drawing.Size(915, 245);
            this.grpDanhSachDon.TabIndex = 0;
            this.grpDanhSachDon.TabStop = false;
            this.grpDanhSachDon.Text = "Danh Sách Đơn Thuốc / Hóa Đơn Khám Bệnh";
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Location = new System.Drawing.Point(565, 200);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(150, 35);
            this.btnInHoaDon.TabIndex = 2;
            this.btnInHoaDon.Text = "In Hóa Đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.Coral;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(730, 200);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(175, 35);
            this.btnThanhToan.TabIndex = 1;
            this.btnThanhToan.Text = "Xác Nhận Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // dgvDonThuoc
            // 
            this.dgvDonThuoc.AllowUserToAddRows = false;
            this.dgvDonThuoc.AllowUserToDeleteRows = false;
            this.dgvDonThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonThuoc.Location = new System.Drawing.Point(10, 20);
            this.dgvDonThuoc.Name = "dgvDonThuoc";
            this.dgvDonThuoc.ReadOnly = true;
            this.dgvDonThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonThuoc.Size = new System.Drawing.Size(895, 170);
            this.dgvDonThuoc.TabIndex = 0;
            this.dgvDonThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonThuoc_CellClick);
            // 
            // tabKhoThuoc
            // 
            this.tabKhoThuoc.Controls.Add(this.dgvKhoThuoc);
            this.tabKhoThuoc.Controls.Add(this.grpThongTinThuoc);
            this.tabKhoThuoc.Location = new System.Drawing.Point(4, 22);
            this.tabKhoThuoc.Name = "tabKhoThuoc";
            this.tabKhoThuoc.Padding = new System.Windows.Forms.Padding(3);
            this.tabKhoThuoc.Size = new System.Drawing.Size(936, 565);
            this.tabKhoThuoc.TabIndex = 2;
            this.tabKhoThuoc.Text = "Quản Lý Danh Mục & Kho Thuốc";
            this.tabKhoThuoc.UseVisualStyleBackColor = true;
            // 
            // dgvKhoThuoc
            // 
            this.dgvKhoThuoc.AllowUserToAddRows = false;
            this.dgvKhoThuoc.AllowUserToDeleteRows = false;
            this.dgvKhoThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhoThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoThuoc.Location = new System.Drawing.Point(10, 165);
            this.dgvKhoThuoc.Name = "dgvKhoThuoc";
            this.dgvKhoThuoc.ReadOnly = true;
            this.dgvKhoThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhoThuoc.Size = new System.Drawing.Size(915, 390);
            this.dgvKhoThuoc.TabIndex = 1;
            this.dgvKhoThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoThuoc_CellClick);
            // 
            // grpThongTinThuoc
            // 
            this.grpThongTinThuoc.Controls.Add(this.btnNhapThemKho);
            this.grpThongTinThuoc.Controls.Add(this.nudSoLuongNhapThem);
            this.grpThongTinThuoc.Controls.Add(this.lblNhapThem);
            this.grpThongTinThuoc.Controls.Add(this.btnCapNhatGia);
            this.grpThongTinThuoc.Controls.Add(this.btnThemThuocMoi);
            this.grpThongTinThuoc.Controls.Add(this.nudSoLuongTon);
            this.grpThongTinThuoc.Controls.Add(this.nudDonGiaThuoc);
            this.grpThongTinThuoc.Controls.Add(this.cboDonViTinh);
            this.grpThongTinThuoc.Controls.Add(this.txtTenThuoc);
            this.grpThongTinThuoc.Controls.Add(this.lblSoLuongTon);
            this.grpThongTinThuoc.Controls.Add(this.lblDonGiaThuoc);
            this.grpThongTinThuoc.Controls.Add(this.lblDonViTinh);
            this.grpThongTinThuoc.Controls.Add(this.lblTenThuoc);
            this.grpThongTinThuoc.Location = new System.Drawing.Point(10, 10);
            this.grpThongTinThuoc.Name = "grpThongTinThuoc";
            this.grpThongTinThuoc.Size = new System.Drawing.Size(915, 145);
            this.grpThongTinThuoc.TabIndex = 0;
            this.grpThongTinThuoc.TabStop = false;
            this.grpThongTinThuoc.Text = "Thông Tin Thuốc & Nhập Kho Dược Phẩm";
            // 
            // btnNhapThemKho
            // 
            this.btnNhapThemKho.BackColor = System.Drawing.Color.LightGreen;
            this.btnNhapThemKho.Location = new System.Drawing.Point(740, 95);
            this.btnNhapThemKho.Name = "btnNhapThemKho";
            this.btnNhapThemKho.Size = new System.Drawing.Size(155, 30);
            this.btnNhapThemKho.TabIndex = 12;
            this.btnNhapThemKho.Text = "Nhập Thêm Tồn Kho";
            this.btnNhapThemKho.UseVisualStyleBackColor = false;
            this.btnNhapThemKho.Click += new System.EventHandler(this.btnNhapThemKho_Click);
            // 
            // nudSoLuongNhapThem
            // 
            this.nudSoLuongNhapThem.Location = new System.Drawing.Point(630, 100);
            this.nudSoLuongNhapThem.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.nudSoLuongNhapThem.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudSoLuongNhapThem.Name = "nudSoLuongNhapThem";
            this.nudSoLuongNhapThem.Size = new System.Drawing.Size(95, 20);
            this.nudSoLuongNhapThem.TabIndex = 11;
            this.nudSoLuongNhapThem.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lblNhapThem
            // 
            this.lblNhapThem.AutoSize = true;
            this.lblNhapThem.Location = new System.Drawing.Point(535, 103);
            this.lblNhapThem.Name = "lblNhapThem";
            this.lblNhapThem.Size = new System.Drawing.Size(84, 13);
            this.lblNhapThem.TabIndex = 10;
            this.lblNhapThem.Text = "SL nhập thêm:";
            // 
            // btnCapNhatGia
            // 
            this.btnCapNhatGia.Location = new System.Drawing.Point(260, 95);
            this.btnCapNhatGia.Name = "btnCapNhatGia";
            this.btnCapNhatGia.Size = new System.Drawing.Size(150, 30);
            this.btnCapNhatGia.TabIndex = 9;
            this.btnCapNhatGia.Text = "Cập Nhật Đơn Giá";
            this.btnCapNhatGia.UseVisualStyleBackColor = true;
            this.btnCapNhatGia.Click += new System.EventHandler(this.btnCapNhatGia_Click);
            // 
            // btnThemThuocMoi
            // 
            this.btnThemThuocMoi.Location = new System.Drawing.Point(95, 95);
            this.btnThemThuocMoi.Name = "btnThemThuocMoi";
            this.btnThemThuocMoi.Size = new System.Drawing.Size(150, 30);
            this.btnThemThuocMoi.TabIndex = 8;
            this.btnThemThuocMoi.Text = "Thêm Thuốc Mới";
            this.btnThemThuocMoi.UseVisualStyleBackColor = true;
            this.btnThemThuocMoi.Click += new System.EventHandler(this.btnThemThuocMoi_Click);
            // 
            // nudSoLuongTon
            // 
            this.nudSoLuongTon.Location = new System.Drawing.Point(630, 60);
            this.nudSoLuongTon.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.nudSoLuongTon.Name = "nudSoLuongTon";
            this.nudSoLuongTon.Size = new System.Drawing.Size(150, 20);
            this.nudSoLuongTon.TabIndex = 7;
            // 
            // nudDonGiaThuoc
            // 
            this.nudDonGiaThuoc.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            this.nudDonGiaThuoc.Location = new System.Drawing.Point(630, 25);
            this.nudDonGiaThuoc.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            this.nudDonGiaThuoc.Name = "nudDonGiaThuoc";
            this.nudDonGiaThuoc.Size = new System.Drawing.Size(150, 20);
            this.nudDonGiaThuoc.TabIndex = 6;
            // 
            // cboDonViTinh
            // 
            this.cboDonViTinh.FormattingEnabled = true;
            this.cboDonViTinh.Items.AddRange(new object[] {
            "Viên",
            "Vỉ",
            "Chai",
            "Hộp",
            "Gói"});
            this.cboDonViTinh.Location = new System.Drawing.Point(95, 60);
            this.cboDonViTinh.Name = "cboDonViTinh";
            this.cboDonViTinh.Size = new System.Drawing.Size(180, 21);
            this.cboDonViTinh.TabIndex = 5;
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Location = new System.Drawing.Point(95, 25);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(350, 20);
            this.txtTenThuoc.TabIndex = 4;
            // 
            // lblSoLuongTon
            // 
            this.lblSoLuongTon.AutoSize = true;
            this.lblSoLuongTon.Location = new System.Drawing.Point(535, 63);
            this.lblSoLuongTon.Name = "lblSoLuongTon";
            this.lblSoLuongTon.Size = new System.Drawing.Size(70, 13);
            this.lblSoLuongTon.TabIndex = 3;
            this.lblSoLuongTon.Text = "Số lượng tồn:";
            // 
            // lblDonGiaThuoc
            // 
            this.lblDonGiaThuoc.AutoSize = true;
            this.lblDonGiaThuoc.Location = new System.Drawing.Point(535, 28);
            this.lblDonGiaThuoc.Name = "lblDonGiaThuoc";
            this.lblDonGiaThuoc.Size = new System.Drawing.Size(47, 13);
            this.lblDonGiaThuoc.TabIndex = 2;
            this.lblDonGiaThuoc.Text = "Đơn giá:";
            // 
            // lblDonViTinh
            // 
            this.lblDonViTinh.AutoSize = true;
            this.lblDonViTinh.Location = new System.Drawing.Point(15, 63);
            this.lblDonViTinh.Name = "lblDonViTinh";
            this.lblDonViTinh.Size = new System.Drawing.Size(60, 13);
            this.lblDonViTinh.TabIndex = 1;
            this.lblDonViTinh.Text = "Đơn vị tính:";
            // 
            // lblTenThuoc
            // 
            this.lblTenThuoc.AutoSize = true;
            this.lblTenThuoc.Location = new System.Drawing.Point(15, 28);
            this.lblTenThuoc.Name = "lblTenThuoc";
            this.lblTenThuoc.Size = new System.Drawing.Size(58, 13);
            this.lblTenThuoc.TabIndex = 0;
            this.lblTenThuoc.Text = "Tên thuốc:";
            // 
            // frmClinic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 591);
            this.Controls.Add(this.tabMain);
            this.Name = "frmClinic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Phòng Khám & Kê Đơn Thuốc (Clinic & Pharmacy Management System)";
            this.Load += new System.EventHandler(this.frmClinic_Load);
            this.tabMain.ResumeLayout(false);
            this.tabTiepNhanKeDon.ResumeLayout(false);
            this.grpKeDon.ResumeLayout(false);
            this.grpKeDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienKham)).EndInit();
            this.grpTiepNhan.ResumeLayout(false);
            this.grpTiepNhan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNamSinh)).EndInit();
            this.tabThanhToan.ResumeLayout(false);
            this.grpChiTietHoaDon.ResumeLayout(false);
            this.grpChiTietHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).EndInit();
            this.grpDanhSachDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonThuoc)).EndInit();
            this.tabKhoThuoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoThuoc)).EndInit();
            this.grpThongTinThuoc.ResumeLayout(false);
            this.grpThongTinThuoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongNhapThem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGiaThuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabTiepNhanKeDon;
        private System.Windows.Forms.TabPage tabThanhToan;
        private System.Windows.Forms.TabPage tabKhoThuoc;
        private System.Windows.Forms.GroupBox grpTiepNhan;
        private System.Windows.Forms.Label lblTimSDT;
        private System.Windows.Forms.TextBox txtTimSDT;
        private System.Windows.Forms.Button btnTimBN;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblNamSinh;
        private System.Windows.Forms.Label lblTrieuChung;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.NumericUpDown nudNamSinh;
        private System.Windows.Forms.TextBox txtTrieuChung;
        private System.Windows.Forms.Button btnTiepNhan;
        private System.Windows.Forms.Label lblChonHoSo;
        private System.Windows.Forms.ComboBox cboHoSoKham;
        private System.Windows.Forms.GroupBox grpKeDon;
        private System.Windows.Forms.Label lblChanDoan;
        private System.Windows.Forms.Label lblTienKham;
        private System.Windows.Forms.Label lblChonThuoc;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblLieuDung;
        private System.Windows.Forms.TextBox txtChanDoan;
        private System.Windows.Forms.NumericUpDown nudTienKham;
        private System.Windows.Forms.ComboBox cboThuoc;
        private System.Windows.Forms.NumericUpDown nudSoLuongThuoc;
        private System.Windows.Forms.TextBox txtLieuDung;
        private System.Windows.Forms.Button btnThemThuoc;
        private System.Windows.Forms.DataGridView dgvChiTietDon;
        private System.Windows.Forms.Label lblTongTienTxt;
        private System.Windows.Forms.Label lblTongTienDon;
        private System.Windows.Forms.Button btnLuuXuatDon;
        private System.Windows.Forms.GroupBox grpDanhSachDon;
        private System.Windows.Forms.DataGridView dgvDonThuoc;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.GroupBox grpChiTietHoaDon;
        private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
        private System.Windows.Forms.TextBox txtHoaDonPreview;
        private System.Windows.Forms.GroupBox grpThongTinThuoc;
        private System.Windows.Forms.Label lblTenThuoc;
        private System.Windows.Forms.Label lblDonViTinh;
        private System.Windows.Forms.Label lblDonGiaThuoc;
        private System.Windows.Forms.Label lblSoLuongTon;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.ComboBox cboDonViTinh;
        private System.Windows.Forms.NumericUpDown nudDonGiaThuoc;
        private System.Windows.Forms.NumericUpDown nudSoLuongTon;
        private System.Windows.Forms.Button btnThemThuocMoi;
        private System.Windows.Forms.Button btnCapNhatGia;
        private System.Windows.Forms.Label lblNhapThem;
        private System.Windows.Forms.NumericUpDown nudSoLuongNhapThem;
        private System.Windows.Forms.Button btnNhapThemKho;
        private System.Windows.Forms.DataGridView dgvKhoThuoc;
    }
}
