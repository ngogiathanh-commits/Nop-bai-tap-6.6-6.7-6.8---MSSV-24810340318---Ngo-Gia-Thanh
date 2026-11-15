namespace LibraryManagement.GUI
{
    partial class frmLibrary
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
            tabMain = new TabControl();
            tabMuonTra = new TabPage();
            grpLapPhieuMuon = new GroupBox();
            dgvChiTietMuonTam = new DataGridView();
            btnLapPhieuMuon = new Button();
            btnThemSachVaoPhieu = new Button();
            nudSoLuongMuon = new NumericUpDown();
            cboSachMuon = new ComboBox();
            dtpHanTra = new DateTimePicker();
            cboDocGiaMuon = new ComboBox();
            lblSoLuongMuon = new Label();
            lblChonSach = new Label();
            lblHanTra = new Label();
            lblChonDocGia = new Label();
            dgvPhieuMuon = new DataGridView();
            btnTraSach = new Button();
            btnLocPhieu = new Button();
            cboLocTrangThai = new ComboBox();
            lblLocTrangThai = new Label();
            cboLocDocGia = new ComboBox();
            lblLocDocGia = new Label();
            tabDanhMuc = new TabPage();
            grpDocGia = new GroupBox();
            dgvDocGia = new DataGridView();
            btnXoaDG = new Button();
            btnSuaDG = new Button();
            btnThemDG = new Button();
            dtpNgayHetHanThe = new DateTimePicker();
            txtEmailDG = new TextBox();
            txtHoTenDG = new TextBox();
            lblNgayHetHan = new Label();
            lblEmailDG = new Label();
            lblHoTenDG = new Label();
            grpDauSach = new GroupBox();
            dgvDauSach = new DataGridView();
            btnXoaSach = new Button();
            btnSuaSach = new Button();
            btnThemSach = new Button();
            nudSoLuongCon = new NumericUpDown();
            cboTheLoai = new ComboBox();
            txtTenSach = new TextBox();
            lblSoLuongCon = new Label();
            lblTheLoai = new Label();
            lblTenSach = new Label();
            tabBaoCao = new TabPage();
            dgvThongKeTheLoai = new DataGridView();
            lblTongLuotMuon = new Label();
            lstPhieuQuaHan = new ListBox();
            btnLamMoiBaoCao = new Button();
            lblCanhBaoQuaHan = new Label();
            tabMain.SuspendLayout();
            tabMuonTra.SuspendLayout();
            grpLapPhieuMuon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietMuonTam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSoLuongMuon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuMuon).BeginInit();
            tabDanhMuc.SuspendLayout();
            grpDocGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocGia).BeginInit();
            grpDauSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDauSach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSoLuongCon).BeginInit();
            tabBaoCao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKeTheLoai).BeginInit();
            SuspendLayout();
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabMuonTra);
            tabMain.Controls.Add(tabDanhMuc);
            tabMain.Controls.Add(tabBaoCao);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Location = new Point(0, 0);
            tabMain.Margin = new Padding(4, 5, 4, 5);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(1232, 894);
            tabMain.TabIndex = 0;
            // 
            // tabMuonTra
            // 
            tabMuonTra.Controls.Add(grpLapPhieuMuon);
            tabMuonTra.Controls.Add(dgvPhieuMuon);
            tabMuonTra.Controls.Add(btnTraSach);
            tabMuonTra.Controls.Add(btnLocPhieu);
            tabMuonTra.Controls.Add(cboLocTrangThai);
            tabMuonTra.Controls.Add(lblLocTrangThai);
            tabMuonTra.Controls.Add(cboLocDocGia);
            tabMuonTra.Controls.Add(lblLocDocGia);
            tabMuonTra.Location = new Point(4, 29);
            tabMuonTra.Margin = new Padding(4, 5, 4, 5);
            tabMuonTra.Name = "tabMuonTra";
            tabMuonTra.Padding = new Padding(4, 5, 4, 5);
            tabMuonTra.Size = new Size(1224, 861);
            tabMuonTra.TabIndex = 0;
            tabMuonTra.Text = "Quản Lý Mượn & Trả Sách";
            tabMuonTra.UseVisualStyleBackColor = true;
            // 
            // grpLapPhieuMuon
            // 
            grpLapPhieuMuon.Controls.Add(dgvChiTietMuonTam);
            grpLapPhieuMuon.Controls.Add(btnLapPhieuMuon);
            grpLapPhieuMuon.Controls.Add(btnThemSachVaoPhieu);
            grpLapPhieuMuon.Controls.Add(nudSoLuongMuon);
            grpLapPhieuMuon.Controls.Add(cboSachMuon);
            grpLapPhieuMuon.Controls.Add(dtpHanTra);
            grpLapPhieuMuon.Controls.Add(cboDocGiaMuon);
            grpLapPhieuMuon.Controls.Add(lblSoLuongMuon);
            grpLapPhieuMuon.Controls.Add(lblChonSach);
            grpLapPhieuMuon.Controls.Add(lblHanTra);
            grpLapPhieuMuon.Controls.Add(lblChonDocGia);
            grpLapPhieuMuon.Location = new Point(13, 431);
            grpLapPhieuMuon.Margin = new Padding(4, 5, 4, 5);
            grpLapPhieuMuon.Name = "grpLapPhieuMuon";
            grpLapPhieuMuon.Padding = new Padding(4, 5, 4, 5);
            grpLapPhieuMuon.Size = new Size(1193, 408);
            grpLapPhieuMuon.TabIndex = 7;
            grpLapPhieuMuon.TabStop = false;
            grpLapPhieuMuon.Text = "Lập Phiếu Mượn Mới (Kiểm Tra Hạn Thẻ & SqlTransaction)";
            // 
            // dgvChiTietMuonTam
            // 
            dgvChiTietMuonTam.AllowUserToAddRows = false;
            dgvChiTietMuonTam.AllowUserToDeleteRows = false;
            dgvChiTietMuonTam.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietMuonTam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietMuonTam.Location = new Point(513, 38);
            dgvChiTietMuonTam.Margin = new Padding(4, 5, 4, 5);
            dgvChiTietMuonTam.Name = "dgvChiTietMuonTam";
            dgvChiTietMuonTam.ReadOnly = true;
            dgvChiTietMuonTam.RowHeadersWidth = 51;
            dgvChiTietMuonTam.Size = new Size(660, 346);
            dgvChiTietMuonTam.TabIndex = 10;
            // 
            // btnLapPhieuMuon
            // 
            btnLapPhieuMuon.BackColor = Color.LightGreen;
            btnLapPhieuMuon.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLapPhieuMuon.Location = new Point(140, 285);
            btnLapPhieuMuon.Margin = new Padding(4, 5, 4, 5);
            btnLapPhieuMuon.Name = "btnLapPhieuMuon";
            btnLapPhieuMuon.Size = new Size(347, 62);
            btnLapPhieuMuon.TabIndex = 9;
            btnLapPhieuMuon.Text = "Xác Nhận Lập Phiếu Mượn";
            btnLapPhieuMuon.UseVisualStyleBackColor = false;
            btnLapPhieuMuon.Click += btnLapPhieuMuon_Click;
            // 
            // btnThemSachVaoPhieu
            // 
            btnThemSachVaoPhieu.Location = new Point(273, 200);
            btnThemSachVaoPhieu.Margin = new Padding(4, 5, 4, 5);
            btnThemSachVaoPhieu.Name = "btnThemSachVaoPhieu";
            btnThemSachVaoPhieu.Size = new Size(213, 40);
            btnThemSachVaoPhieu.TabIndex = 8;
            btnThemSachVaoPhieu.Text = "Thêm Sách Vào Phiếu";
            btnThemSachVaoPhieu.UseVisualStyleBackColor = true;
            btnThemSachVaoPhieu.Click += btnThemSachVaoPhieu_Click;
            // 
            // nudSoLuongMuon
            // 
            nudSoLuongMuon.Location = new Point(140, 205);
            nudSoLuongMuon.Margin = new Padding(4, 5, 4, 5);
            nudSoLuongMuon.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoLuongMuon.Name = "nudSoLuongMuon";
            nudSoLuongMuon.Size = new Size(113, 27);
            nudSoLuongMuon.TabIndex = 7;
            nudSoLuongMuon.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboSachMuon
            // 
            cboSachMuon.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSachMuon.FormattingEnabled = true;
            cboSachMuon.Location = new Point(140, 146);
            cboSachMuon.Margin = new Padding(4, 5, 4, 5);
            cboSachMuon.Name = "cboSachMuon";
            cboSachMuon.Size = new Size(345, 28);
            cboSachMuon.TabIndex = 6;
            // 
            // dtpHanTra
            // 
            dtpHanTra.Format = DateTimePickerFormat.Short;
            dtpHanTra.Location = new Point(140, 92);
            dtpHanTra.Margin = new Padding(4, 5, 4, 5);
            dtpHanTra.Name = "dtpHanTra";
            dtpHanTra.Size = new Size(345, 27);
            dtpHanTra.TabIndex = 5;
            // 
            // cboDocGiaMuon
            // 
            cboDocGiaMuon.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDocGiaMuon.FormattingEnabled = true;
            cboDocGiaMuon.Location = new Point(140, 38);
            cboDocGiaMuon.Margin = new Padding(4, 5, 4, 5);
            cboDocGiaMuon.Name = "cboDocGiaMuon";
            cboDocGiaMuon.Size = new Size(345, 28);
            cboDocGiaMuon.TabIndex = 4;
            // 
            // lblSoLuongMuon
            // 
            lblSoLuongMuon.AutoSize = true;
            lblSoLuongMuon.Location = new Point(20, 209);
            lblSoLuongMuon.Margin = new Padding(4, 0, 4, 0);
            lblSoLuongMuon.Name = "lblSoLuongMuon";
            lblSoLuongMuon.Size = new Size(72, 20);
            lblSoLuongMuon.TabIndex = 3;
            lblSoLuongMuon.Text = "Số lượng:";
            // 
            // lblChonSach
            // 
            lblChonSach.AutoSize = true;
            lblChonSach.Location = new Point(20, 151);
            lblChonSach.Margin = new Padding(4, 0, 4, 0);
            lblChonSach.Name = "lblChonSach";
            lblChonSach.Size = new Size(79, 20);
            lblChonSach.TabIndex = 2;
            lblChonSach.Text = "Chọn sách:";
            // 
            // lblHanTra
            // 
            lblHanTra.AutoSize = true;
            lblHanTra.Location = new Point(20, 97);
            lblHanTra.Margin = new Padding(4, 0, 4, 0);
            lblHanTra.Name = "lblHanTra";
            lblHanTra.Size = new Size(61, 20);
            lblHanTra.TabIndex = 1;
            lblHanTra.Text = "Hạn trả:";
            // 
            // lblChonDocGia
            // 
            lblChonDocGia.AutoSize = true;
            lblChonDocGia.Location = new Point(20, 43);
            lblChonDocGia.Margin = new Padding(4, 0, 4, 0);
            lblChonDocGia.Name = "lblChonDocGia";
            lblChonDocGia.Size = new Size(64, 20);
            lblChonDocGia.TabIndex = 0;
            lblChonDocGia.Text = "Độc giả:";
            // 
            // dgvPhieuMuon
            // 
            dgvPhieuMuon.AllowUserToAddRows = false;
            dgvPhieuMuon.AllowUserToDeleteRows = false;
            dgvPhieuMuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuMuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuMuon.Location = new Point(13, 77);
            dgvPhieuMuon.Margin = new Padding(4, 5, 4, 5);
            dgvPhieuMuon.Name = "dgvPhieuMuon";
            dgvPhieuMuon.ReadOnly = true;
            dgvPhieuMuon.RowHeadersWidth = 51;
            dgvPhieuMuon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhieuMuon.Size = new Size(1193, 338);
            dgvPhieuMuon.TabIndex = 6;
            // 
            // btnTraSach
            // 
            btnTraSach.BackColor = Color.LightSkyBlue;
            btnTraSach.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTraSach.Location = new Point(967, 18);
            btnTraSach.Margin = new Padding(4, 5, 4, 5);
            btnTraSach.Name = "btnTraSach";
            btnTraSach.Size = new Size(240, 43);
            btnTraSach.TabIndex = 5;
            btnTraSach.Text = "Trả Sách (Đã Trả)";
            btnTraSach.UseVisualStyleBackColor = false;
            btnTraSach.Click += btnTraSach_Click;
            // 
            // btnLocPhieu
            // 
            btnLocPhieu.Location = new Point(653, 20);
            btnLocPhieu.Margin = new Padding(4, 5, 4, 5);
            btnLocPhieu.Name = "btnLocPhieu";
            btnLocPhieu.Size = new Size(113, 38);
            btnLocPhieu.TabIndex = 4;
            btnLocPhieu.Text = "Lọc Phiếu";
            btnLocPhieu.UseVisualStyleBackColor = true;
            btnLocPhieu.Click += btnLocPhieu_Click;
            // 
            // cboLocTrangThai
            // 
            cboLocTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocTrangThai.FormattingEnabled = true;
            cboLocTrangThai.Items.AddRange(new object[] { "Tất cả", "Đang mượn", "Đã trả", "Quá hạn" });
            cboLocTrangThai.Location = new Point(460, 23);
            cboLocTrangThai.Margin = new Padding(4, 5, 4, 5);
            cboLocTrangThai.Name = "cboLocTrangThai";
            cboLocTrangThai.Size = new Size(172, 28);
            cboLocTrangThai.TabIndex = 3;
            // 
            // lblLocTrangThai
            // 
            lblLocTrangThai.AutoSize = true;
            lblLocTrangThai.Location = new Point(367, 28);
            lblLocTrangThai.Margin = new Padding(4, 0, 4, 0);
            lblLocTrangThai.Name = "lblLocTrangThai";
            lblLocTrangThai.Size = new Size(78, 20);
            lblLocTrangThai.TabIndex = 2;
            lblLocTrangThai.Text = "Trạng thái:";
            // 
            // cboLocDocGia
            // 
            cboLocDocGia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocDocGia.FormattingEnabled = true;
            cboLocDocGia.Location = new Point(93, 23);
            cboLocDocGia.Margin = new Padding(4, 5, 4, 5);
            cboLocDocGia.Name = "cboLocDocGia";
            cboLocDocGia.Size = new Size(252, 28);
            cboLocDocGia.TabIndex = 1;
            // 
            // lblLocDocGia
            // 
            lblLocDocGia.AutoSize = true;
            lblLocDocGia.Location = new Point(13, 28);
            lblLocDocGia.Margin = new Padding(4, 0, 4, 0);
            lblLocDocGia.Name = "lblLocDocGia";
            lblLocDocGia.Size = new Size(64, 20);
            lblLocDocGia.TabIndex = 0;
            lblLocDocGia.Text = "Độc giả:";
            // 
            // tabDanhMuc
            // 
            tabDanhMuc.Controls.Add(grpDocGia);
            tabDanhMuc.Controls.Add(grpDauSach);
            tabDanhMuc.Location = new Point(4, 29);
            tabDanhMuc.Margin = new Padding(4, 5, 4, 5);
            tabDanhMuc.Name = "tabDanhMuc";
            tabDanhMuc.Padding = new Padding(4, 5, 4, 5);
            tabDanhMuc.Size = new Size(1224, 861);
            tabDanhMuc.TabIndex = 1;
            tabDanhMuc.Text = "Quản Lý Đầu Sách & Độc Giả";
            tabDanhMuc.UseVisualStyleBackColor = true;
            // 
            // grpDocGia
            // 
            grpDocGia.Controls.Add(dgvDocGia);
            grpDocGia.Controls.Add(btnXoaDG);
            grpDocGia.Controls.Add(btnSuaDG);
            grpDocGia.Controls.Add(btnThemDG);
            grpDocGia.Controls.Add(dtpNgayHetHanThe);
            grpDocGia.Controls.Add(txtEmailDG);
            grpDocGia.Controls.Add(txtHoTenDG);
            grpDocGia.Controls.Add(lblNgayHetHan);
            grpDocGia.Controls.Add(lblEmailDG);
            grpDocGia.Controls.Add(lblHoTenDG);
            grpDocGia.Location = new Point(13, 431);
            grpDocGia.Margin = new Padding(4, 5, 4, 5);
            grpDocGia.Name = "grpDocGia";
            grpDocGia.Padding = new Padding(4, 5, 4, 5);
            grpDocGia.Size = new Size(1193, 408);
            grpDocGia.TabIndex = 1;
            grpDocGia.TabStop = false;
            grpDocGia.Text = "Quản Lý Độc Giả";
            // 
            // dgvDocGia
            // 
            dgvDocGia.AllowUserToAddRows = false;
            dgvDocGia.AllowUserToDeleteRows = false;
            dgvDocGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDocGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocGia.Location = new Point(453, 31);
            dgvDocGia.Margin = new Padding(4, 5, 4, 5);
            dgvDocGia.Name = "dgvDocGia";
            dgvDocGia.ReadOnly = true;
            dgvDocGia.RowHeadersWidth = 51;
            dgvDocGia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDocGia.Size = new Size(720, 354);
            dgvDocGia.TabIndex = 9;
            dgvDocGia.CellClick += dgvDocGia_CellClick;
            // 
            // btnXoaDG
            // 
            btnXoaDG.Location = new Point(300, 223);
            btnXoaDG.Margin = new Padding(4, 5, 4, 5);
            btnXoaDG.Name = "btnXoaDG";
            btnXoaDG.Size = new Size(120, 46);
            btnXoaDG.TabIndex = 8;
            btnXoaDG.Text = "Xóa ĐG";
            btnXoaDG.UseVisualStyleBackColor = true;
            btnXoaDG.Click += btnXoaDG_Click;
            // 
            // btnSuaDG
            // 
            btnSuaDG.Location = new Point(160, 223);
            btnSuaDG.Margin = new Padding(4, 5, 4, 5);
            btnSuaDG.Name = "btnSuaDG";
            btnSuaDG.Size = new Size(120, 46);
            btnSuaDG.TabIndex = 7;
            btnSuaDG.Text = "Sửa ĐG";
            btnSuaDG.UseVisualStyleBackColor = true;
            btnSuaDG.Click += btnSuaDG_Click;
            // 
            // btnThemDG
            // 
            btnThemDG.Location = new Point(20, 223);
            btnThemDG.Margin = new Padding(4, 5, 4, 5);
            btnThemDG.Name = "btnThemDG";
            btnThemDG.Size = new Size(120, 46);
            btnThemDG.TabIndex = 6;
            btnThemDG.Text = "Thêm ĐG";
            btnThemDG.UseVisualStyleBackColor = true;
            btnThemDG.Click += btnThemDG_Click;
            // 
            // dtpNgayHetHanThe
            // 
            dtpNgayHetHanThe.Format = DateTimePickerFormat.Short;
            dtpNgayHetHanThe.Location = new Point(140, 154);
            dtpNgayHetHanThe.Margin = new Padding(4, 5, 4, 5);
            dtpNgayHetHanThe.Name = "dtpNgayHetHanThe";
            dtpNgayHetHanThe.Size = new Size(279, 27);
            dtpNgayHetHanThe.TabIndex = 5;
            // 
            // txtEmailDG
            // 
            txtEmailDG.Location = new Point(140, 100);
            txtEmailDG.Margin = new Padding(4, 5, 4, 5);
            txtEmailDG.Name = "txtEmailDG";
            txtEmailDG.Size = new Size(279, 27);
            txtEmailDG.TabIndex = 4;
            // 
            // txtHoTenDG
            // 
            txtHoTenDG.Location = new Point(140, 46);
            txtHoTenDG.Margin = new Padding(4, 5, 4, 5);
            txtHoTenDG.Name = "txtHoTenDG";
            txtHoTenDG.Size = new Size(279, 27);
            txtHoTenDG.TabIndex = 3;
            // 
            // lblNgayHetHan
            // 
            lblNgayHetHan.AutoSize = true;
            lblNgayHetHan.Location = new Point(20, 158);
            lblNgayHetHan.Margin = new Padding(4, 0, 4, 0);
            lblNgayHetHan.Name = "lblNgayHetHan";
            lblNgayHetHan.Size = new Size(85, 20);
            lblNgayHetHan.TabIndex = 2;
            lblNgayHetHan.Text = "Hạn thẻ TV:";
            // 
            // lblEmailDG
            // 
            lblEmailDG.AutoSize = true;
            lblEmailDG.Location = new Point(20, 105);
            lblEmailDG.Margin = new Padding(4, 0, 4, 0);
            lblEmailDG.Name = "lblEmailDG";
            lblEmailDG.Size = new Size(49, 20);
            lblEmailDG.TabIndex = 1;
            lblEmailDG.Text = "Email:";
            // 
            // lblHoTenDG
            // 
            lblHoTenDG.AutoSize = true;
            lblHoTenDG.Location = new Point(20, 51);
            lblHoTenDG.Margin = new Padding(4, 0, 4, 0);
            lblHoTenDG.Name = "lblHoTenDG";
            lblHoTenDG.Size = new Size(57, 20);
            lblHoTenDG.TabIndex = 0;
            lblHoTenDG.Text = "Họ tên:";
            // 
            // grpDauSach
            // 
            grpDauSach.Controls.Add(dgvDauSach);
            grpDauSach.Controls.Add(btnXoaSach);
            grpDauSach.Controls.Add(btnSuaSach);
            grpDauSach.Controls.Add(btnThemSach);
            grpDauSach.Controls.Add(nudSoLuongCon);
            grpDauSach.Controls.Add(cboTheLoai);
            grpDauSach.Controls.Add(txtTenSach);
            grpDauSach.Controls.Add(lblSoLuongCon);
            grpDauSach.Controls.Add(lblTheLoai);
            grpDauSach.Controls.Add(lblTenSach);
            grpDauSach.Location = new Point(13, 15);
            grpDauSach.Margin = new Padding(4, 5, 4, 5);
            grpDauSach.Name = "grpDauSach";
            grpDauSach.Padding = new Padding(4, 5, 4, 5);
            grpDauSach.Size = new Size(1193, 400);
            grpDauSach.TabIndex = 0;
            grpDauSach.TabStop = false;
            grpDauSach.Text = "Quản Lý Đầu Sách";
            // 
            // dgvDauSach
            // 
            dgvDauSach.AllowUserToAddRows = false;
            dgvDauSach.AllowUserToDeleteRows = false;
            dgvDauSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDauSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDauSach.Location = new Point(453, 31);
            dgvDauSach.Margin = new Padding(4, 5, 4, 5);
            dgvDauSach.Name = "dgvDauSach";
            dgvDauSach.ReadOnly = true;
            dgvDauSach.RowHeadersWidth = 51;
            dgvDauSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDauSach.Size = new Size(720, 346);
            dgvDauSach.TabIndex = 9;
            dgvDauSach.CellClick += dgvDauSach_CellClick;
            // 
            // btnXoaSach
            // 
            btnXoaSach.Location = new Point(300, 223);
            btnXoaSach.Margin = new Padding(4, 5, 4, 5);
            btnXoaSach.Name = "btnXoaSach";
            btnXoaSach.Size = new Size(120, 46);
            btnXoaSach.TabIndex = 8;
            btnXoaSach.Text = "Xóa Sách";
            btnXoaSach.UseVisualStyleBackColor = true;
            btnXoaSach.Click += btnXoaSach_Click;
            // 
            // btnSuaSach
            // 
            btnSuaSach.Location = new Point(160, 223);
            btnSuaSach.Margin = new Padding(4, 5, 4, 5);
            btnSuaSach.Name = "btnSuaSach";
            btnSuaSach.Size = new Size(120, 46);
            btnSuaSach.TabIndex = 7;
            btnSuaSach.Text = "Sửa Sách";
            btnSuaSach.UseVisualStyleBackColor = true;
            btnSuaSach.Click += btnSuaSach_Click;
            // 
            // btnThemSach
            // 
            btnThemSach.Location = new Point(20, 223);
            btnThemSach.Margin = new Padding(4, 5, 4, 5);
            btnThemSach.Name = "btnThemSach";
            btnThemSach.Size = new Size(120, 46);
            btnThemSach.TabIndex = 6;
            btnThemSach.Text = "Thêm Sách";
            btnThemSach.UseVisualStyleBackColor = true;
            btnThemSach.Click += btnThemSach_Click;
            // 
            // nudSoLuongCon
            // 
            nudSoLuongCon.Location = new Point(140, 154);
            nudSoLuongCon.Margin = new Padding(4, 5, 4, 5);
            nudSoLuongCon.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudSoLuongCon.Name = "nudSoLuongCon";
            nudSoLuongCon.Size = new Size(160, 27);
            nudSoLuongCon.TabIndex = 5;
            nudSoLuongCon.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // cboTheLoai
            // 
            cboTheLoai.FormattingEnabled = true;
            cboTheLoai.Items.AddRange(new object[] { "Công nghệ thông tin", "Kinh tế", "Văn học", "Ngoại ngữ" });
            cboTheLoai.Location = new Point(140, 100);
            cboTheLoai.Margin = new Padding(4, 5, 4, 5);
            cboTheLoai.Name = "cboTheLoai";
            cboTheLoai.Size = new Size(279, 28);
            cboTheLoai.TabIndex = 4;
            // 
            // txtTenSach
            // 
            txtTenSach.Location = new Point(140, 46);
            txtTenSach.Margin = new Padding(4, 5, 4, 5);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(279, 27);
            txtTenSach.TabIndex = 3;
            // 
            // lblSoLuongCon
            // 
            lblSoLuongCon.AutoSize = true;
            lblSoLuongCon.Location = new Point(20, 158);
            lblSoLuongCon.Margin = new Padding(4, 0, 4, 0);
            lblSoLuongCon.Name = "lblSoLuongCon";
            lblSoLuongCon.Size = new Size(100, 20);
            lblSoLuongCon.TabIndex = 2;
            lblSoLuongCon.Text = "Số lượng còn:";
            // 
            // lblTheLoai
            // 
            lblTheLoai.AutoSize = true;
            lblTheLoai.Location = new Point(20, 105);
            lblTheLoai.Margin = new Padding(4, 0, 4, 0);
            lblTheLoai.Name = "lblTheLoai";
            lblTheLoai.Size = new Size(65, 20);
            lblTheLoai.TabIndex = 1;
            lblTheLoai.Text = "Thể loại:";
            // 
            // lblTenSach
            // 
            lblTenSach.AutoSize = true;
            lblTenSach.Location = new Point(20, 51);
            lblTenSach.Margin = new Padding(4, 0, 4, 0);
            lblTenSach.Name = "lblTenSach";
            lblTenSach.Size = new Size(68, 20);
            lblTenSach.TabIndex = 0;
            lblTenSach.Text = "Tên sách:";
            // 
            // tabBaoCao
            // 
            tabBaoCao.Controls.Add(dgvThongKeTheLoai);
            tabBaoCao.Controls.Add(lblTongLuotMuon);
            tabBaoCao.Controls.Add(lstPhieuQuaHan);
            tabBaoCao.Controls.Add(btnLamMoiBaoCao);
            tabBaoCao.Controls.Add(lblCanhBaoQuaHan);
            tabBaoCao.Location = new Point(4, 29);
            tabBaoCao.Margin = new Padding(4, 5, 4, 5);
            tabBaoCao.Name = "tabBaoCao";
            tabBaoCao.Padding = new Padding(4, 5, 4, 5);
            tabBaoCao.Size = new Size(1224, 861);
            tabBaoCao.TabIndex = 2;
            tabBaoCao.Text = "Cảnh Báo Quá Hạn & Thống Kê";
            tabBaoCao.UseVisualStyleBackColor = true;
            // 
            // dgvThongKeTheLoai
            // 
            dgvThongKeTheLoai.AllowUserToAddRows = false;
            dgvThongKeTheLoai.AllowUserToDeleteRows = false;
            dgvThongKeTheLoai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongKeTheLoai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongKeTheLoai.Location = new Point(20, 431);
            dgvThongKeTheLoai.Margin = new Padding(4, 5, 4, 5);
            dgvThongKeTheLoai.Name = "dgvThongKeTheLoai";
            dgvThongKeTheLoai.ReadOnly = true;
            dgvThongKeTheLoai.RowHeadersWidth = 51;
            dgvThongKeTheLoai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThongKeTheLoai.Size = new Size(1180, 400);
            dgvThongKeTheLoai.TabIndex = 4;
            // 
            // lblTongLuotMuon
            // 
            lblTongLuotMuon.AutoSize = true;
            lblTongLuotMuon.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongLuotMuon.ForeColor = Color.DarkBlue;
            lblTongLuotMuon.Location = new Point(20, 385);
            lblTongLuotMuon.Margin = new Padding(4, 0, 4, 0);
            lblTongLuotMuon.Name = "lblTongLuotMuon";
            lblTongLuotMuon.Size = new Size(410, 20);
            lblTongLuotMuon.TabIndex = 3;
            lblTongLuotMuon.Text = "Thống kê lượt mượn theo Thể loại (GROUP BY):";
            // 
            // lstPhieuQuaHan
            // 
            lstPhieuQuaHan.ForeColor = Color.Red;
            lstPhieuQuaHan.FormattingEnabled = true;
            lstPhieuQuaHan.Location = new Point(20, 74);
            lstPhieuQuaHan.Margin = new Padding(4, 5, 4, 5);
            lstPhieuQuaHan.Name = "lstPhieuQuaHan";
            lstPhieuQuaHan.Size = new Size(1179, 284);
            lstPhieuQuaHan.TabIndex = 2;
            // 
            // btnLamMoiBaoCao
            // 
            btnLamMoiBaoCao.Location = new Point(1000, 18);
            btnLamMoiBaoCao.Margin = new Padding(4, 5, 4, 5);
            btnLamMoiBaoCao.Name = "btnLamMoiBaoCao";
            btnLamMoiBaoCao.Size = new Size(200, 43);
            btnLamMoiBaoCao.TabIndex = 1;
            btnLamMoiBaoCao.Text = "Làm Mới Báo Cáo";
            btnLamMoiBaoCao.UseVisualStyleBackColor = true;
            btnLamMoiBaoCao.Click += btnLamMoiBaoCao_Click;
            // 
            // lblCanhBaoQuaHan
            // 
            lblCanhBaoQuaHan.AutoSize = true;
            lblCanhBaoQuaHan.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCanhBaoQuaHan.ForeColor = Color.Red;
            lblCanhBaoQuaHan.Location = new Point(20, 28);
            lblCanhBaoQuaHan.Margin = new Padding(4, 0, 4, 0);
            lblCanhBaoQuaHan.Name = "lblCanhBaoQuaHan";
            lblCanhBaoQuaHan.Size = new Size(349, 20);
            lblCanhBaoQuaHan.TabIndex = 0;
            lblCanhBaoQuaHan.Text = "CẢNH BÁO QUÁ HẠN (SqlDataReader):";
            // 
            // frmLibrary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 894);
            Controls.Add(tabMain);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmLibrary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ Thống Quản Lý Mượn Trả Sách Thư Viện (Library Management System)";
            Load += frmLibrary_Load;
            tabMain.ResumeLayout(false);
            tabMuonTra.ResumeLayout(false);
            tabMuonTra.PerformLayout();
            grpLapPhieuMuon.ResumeLayout(false);
            grpLapPhieuMuon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietMuonTam).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSoLuongMuon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuMuon).EndInit();
            tabDanhMuc.ResumeLayout(false);
            grpDocGia.ResumeLayout(false);
            grpDocGia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocGia).EndInit();
            grpDauSach.ResumeLayout(false);
            grpDauSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDauSach).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSoLuongCon).EndInit();
            tabBaoCao.ResumeLayout(false);
            tabBaoCao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKeTheLoai).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabMuonTra;
        private System.Windows.Forms.TabPage tabDanhMuc;
        private System.Windows.Forms.TabPage tabBaoCao;
        private System.Windows.Forms.Label lblLocDocGia;
        private System.Windows.Forms.ComboBox cboLocDocGia;
        private System.Windows.Forms.Label lblLocTrangThai;
        private System.Windows.Forms.ComboBox cboLocTrangThai;
        private System.Windows.Forms.Button btnLocPhieu;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.DataGridView dgvPhieuMuon;
        private System.Windows.Forms.GroupBox grpLapPhieuMuon;
        private System.Windows.Forms.Label lblChonDocGia;
        private System.Windows.Forms.Label lblHanTra;
        private System.Windows.Forms.Label lblChonSach;
        private System.Windows.Forms.Label lblSoLuongMuon;
        private System.Windows.Forms.ComboBox cboDocGiaMuon;
        private System.Windows.Forms.DateTimePicker dtpHanTra;
        private System.Windows.Forms.ComboBox cboSachMuon;
        private System.Windows.Forms.NumericUpDown nudSoLuongMuon;
        private System.Windows.Forms.Button btnThemSachVaoPhieu;
        private System.Windows.Forms.Button btnLapPhieuMuon;
        private System.Windows.Forms.DataGridView dgvChiTietMuonTam;
        private System.Windows.Forms.GroupBox grpDauSach;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.Label lblSoLuongCon;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.ComboBox cboTheLoai;
        private System.Windows.Forms.NumericUpDown nudSoLuongCon;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.Button btnSuaSach;
        private System.Windows.Forms.Button btnXoaSach;
        private System.Windows.Forms.DataGridView dgvDauSach;
        private System.Windows.Forms.GroupBox grpDocGia;
        private System.Windows.Forms.Label lblHoTenDG;
        private System.Windows.Forms.Label lblEmailDG;
        private System.Windows.Forms.Label lblNgayHetHan;
        private System.Windows.Forms.TextBox txtHoTenDG;
        private System.Windows.Forms.TextBox txtEmailDG;
        private System.Windows.Forms.DateTimePicker dtpNgayHetHanThe;
        private System.Windows.Forms.Button btnThemDG;
        private System.Windows.Forms.Button btnSuaDG;
        private System.Windows.Forms.Button btnXoaDG;
        private System.Windows.Forms.DataGridView dgvDocGia;
        private System.Windows.Forms.Label lblCanhBaoQuaHan;
        private System.Windows.Forms.Button btnLamMoiBaoCao;
        private System.Windows.Forms.ListBox lstPhieuQuaHan;
        private System.Windows.Forms.Label lblTongLuotMuon;
        private System.Windows.Forms.DataGridView dgvThongKeTheLoai;
    }
}
