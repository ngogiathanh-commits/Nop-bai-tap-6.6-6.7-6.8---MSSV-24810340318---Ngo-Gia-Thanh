namespace BilliardsClubManagement.GUI
{
    partial class frmBilliards
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
            this.flpBanBida = new System.Windows.Forms.FlowLayoutPanel();
            this.grpThongTinBan = new System.Windows.Forms.GroupBox();
            this.lblLoaiBan = new System.Windows.Forms.Label();
            this.lblLoaiBanTxt = new System.Windows.Forms.Label();
            this.btnCapNhatTienGio = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTongTienTxt = new System.Windows.Forms.Label();
            this.lblTienDichVu = new System.Windows.Forms.Label();
            this.lblTienDichVuTxt = new System.Windows.Forms.Label();
            this.lblTienGioChoi = new System.Windows.Forms.Label();
            this.lblTienGioChoiTxt = new System.Windows.Forms.Label();
            this.lblGioBatDau = new System.Windows.Forms.Label();
            this.lblGioBatDauTxt = new System.Windows.Forms.Label();
            this.lblGiaGio = new System.Windows.Forms.Label();
            this.lblGiaGioTxt = new System.Windows.Forms.Label();
            this.lblTenBanDangChon = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnMoBan = new System.Windows.Forms.Button();
            this.grpDichVu = new System.Windows.Forms.GroupBox();
            this.btnTangSL = new System.Windows.Forms.Button();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.nudSoLuongDV = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuongDV = new System.Windows.Forms.Label();
            this.cboDichVu = new System.Windows.Forms.ComboBox();
            this.lblChonDV = new System.Windows.Forms.Label();
            this.grpThongTinBan.SuspendLayout();
            this.grpDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongDV)).BeginInit();
            this.SuspendLayout();
            // 
            // flpBanBida
            // 
            this.flpBanBida.AutoScroll = true;
            this.flpBanBida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpBanBida.Location = new System.Drawing.Point(12, 12);
            this.flpBanBida.Name = "flpBanBida";
            this.flpBanBida.Size = new System.Drawing.Size(420, 545);
            this.flpBanBida.TabIndex = 0;
            // 
            // grpThongTinBan
            // 
            this.grpThongTinBan.Controls.Add(this.lblLoaiBan);
            this.grpThongTinBan.Controls.Add(this.lblLoaiBanTxt);
            this.grpThongTinBan.Controls.Add(this.btnCapNhatTienGio);
            this.grpThongTinBan.Controls.Add(this.lblTongTien);
            this.grpThongTinBan.Controls.Add(this.lblTongTienTxt);
            this.grpThongTinBan.Controls.Add(this.lblTienDichVu);
            this.grpThongTinBan.Controls.Add(this.lblTienDichVuTxt);
            this.grpThongTinBan.Controls.Add(this.lblTienGioChoi);
            this.grpThongTinBan.Controls.Add(this.lblTienGioChoiTxt);
            this.grpThongTinBan.Controls.Add(this.lblGioBatDau);
            this.grpThongTinBan.Controls.Add(this.lblGioBatDauTxt);
            this.grpThongTinBan.Controls.Add(this.lblGiaGio);
            this.grpThongTinBan.Controls.Add(this.lblGiaGioTxt);
            this.grpThongTinBan.Controls.Add(this.lblTenBanDangChon);
            this.grpThongTinBan.Controls.Add(this.btnThanhToan);
            this.grpThongTinBan.Controls.Add(this.btnMoBan);
            this.grpThongTinBan.Location = new System.Drawing.Point(445, 12);
            this.grpThongTinBan.Name = "grpThongTinBan";
            this.grpThongTinBan.Size = new System.Drawing.Size(475, 240);
            this.grpThongTinBan.TabIndex = 1;
            this.grpThongTinBan.TabStop = false;
            this.grpThongTinBan.Text = "Thông Tin Bàn Bida && Tính Tiền Giờ (Block 15 Phút)";
            // 
            // lblLoaiBan
            // 
            this.lblLoaiBan.AutoSize = true;
            this.lblLoaiBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiBan.Location = new System.Drawing.Point(110, 52);
            this.lblLoaiBan.Name = "lblLoaiBan";
            this.lblLoaiBan.Size = new System.Drawing.Size(22, 15);
            this.lblLoaiBan.TabIndex = 15;
            this.lblLoaiBan.Text = "---";
            // 
            // lblLoaiBanTxt
            // 
            this.lblLoaiBanTxt.AutoSize = true;
            this.lblLoaiBanTxt.Location = new System.Drawing.Point(15, 53);
            this.lblLoaiBanTxt.Name = "lblLoaiBanTxt";
            this.lblLoaiBanTxt.Size = new System.Drawing.Size(51, 13);
            this.lblLoaiBanTxt.TabIndex = 14;
            this.lblLoaiBanTxt.Text = "Loại bàn:";
            // 
            // btnCapNhatTienGio
            // 
            this.btnCapNhatTienGio.Location = new System.Drawing.Point(350, 20);
            this.btnCapNhatTienGio.Name = "btnCapNhatTienGio";
            this.btnCapNhatTienGio.Size = new System.Drawing.Size(115, 28);
            this.btnCapNhatTienGio.TabIndex = 13;
            this.btnCapNhatTienGio.Text = "Cập nhật giờ";
            this.btnCapNhatTienGio.UseVisualStyleBackColor = true;
            this.btnCapNhatTienGio.Click += new System.EventHandler(this.btnCapNhatTienGio_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(110, 200);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(60, 20);
            this.lblTongTien.TabIndex = 12;
            this.lblTongTien.Text = "0 VNĐ";
            // 
            // lblTongTienTxt
            // 
            this.lblTongTienTxt.AutoSize = true;
            this.lblTongTienTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienTxt.Location = new System.Drawing.Point(15, 203);
            this.lblTongTienTxt.Name = "lblTongTienTxt";
            this.lblTongTienTxt.Size = new System.Drawing.Size(89, 15);
            this.lblTongTienTxt.TabIndex = 11;
            this.lblTongTienTxt.Text = "TỔNG CỘNG:";
            // 
            // lblTienDichVu
            // 
            this.lblTienDichVu.AutoSize = true;
            this.lblTienDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienDichVu.Location = new System.Drawing.Point(110, 170);
            this.lblTienDichVu.Name = "lblTienDichVu";
            this.lblTienDichVu.Size = new System.Drawing.Size(48, 16);
            this.lblTienDichVu.TabIndex = 10;
            this.lblTienDichVu.Text = "0 VNĐ";
            // 
            // lblTienDichVuTxt
            // 
            this.lblTienDichVuTxt.AutoSize = true;
            this.lblTienDichVuTxt.Location = new System.Drawing.Point(15, 172);
            this.lblTienDichVuTxt.Name = "lblTienDichVuTxt";
            this.lblTienDichVuTxt.Size = new System.Drawing.Size(71, 13);
            this.lblTienDichVuTxt.TabIndex = 9;
            this.lblTienDichVuTxt.Text = "Tiền dịch vụ:";
            // 
            // lblTienGioChoi
            // 
            this.lblTienGioChoi.AutoSize = true;
            this.lblTienGioChoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienGioChoi.Location = new System.Drawing.Point(110, 140);
            this.lblTienGioChoi.Name = "lblTienGioChoi";
            this.lblTienGioChoi.Size = new System.Drawing.Size(48, 16);
            this.lblTienGioChoi.TabIndex = 8;
            this.lblTienGioChoi.Text = "0 VNĐ";
            // 
            // lblTienGioChoiTxt
            // 
            this.lblTienGioChoiTxt.AutoSize = true;
            this.lblTienGioChoiTxt.Location = new System.Drawing.Point(15, 142);
            this.lblTienGioChoiTxt.Name = "lblTienGioChoiTxt";
            this.lblTienGioChoiTxt.Size = new System.Drawing.Size(71, 13);
            this.lblTienGioChoiTxt.TabIndex = 7;
            this.lblTienGioChoiTxt.Text = "Tiền giờ chơi:";
            // 
            // lblGioBatDau
            // 
            this.lblGioBatDau.AutoSize = true;
            this.lblGioBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioBatDau.Location = new System.Drawing.Point(110, 110);
            this.lblGioBatDau.Name = "lblGioBatDau";
            this.lblGioBatDau.Size = new System.Drawing.Size(35, 15);
            this.lblGioBatDau.TabIndex = 6;
            this.lblGioBatDau.Text = "--:--";
            // 
            // lblGioBatDauTxt
            // 
            this.lblGioBatDauTxt.AutoSize = true;
            this.lblGioBatDauTxt.Location = new System.Drawing.Point(15, 112);
            this.lblGioBatDauTxt.Name = "lblGioBatDauTxt";
            this.lblGioBatDauTxt.Size = new System.Drawing.Size(66, 13);
            this.lblGioBatDauTxt.TabIndex = 5;
            this.lblGioBatDauTxt.Text = "Giờ bắt đầu:";
            // 
            // lblGiaGio
            // 
            this.lblGiaGio.AutoSize = true;
            this.lblGiaGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaGio.Location = new System.Drawing.Point(110, 80);
            this.lblGiaGio.Name = "lblGiaGio";
            this.lblGiaGio.Size = new System.Drawing.Size(73, 15);
            this.lblGiaGio.TabIndex = 4;
            this.lblGiaGio.Text = "0 VNĐ/Giờ";
            // 
            // lblGiaGioTxt
            // 
            this.lblGiaGioTxt.AutoSize = true;
            this.lblGiaGioTxt.Location = new System.Drawing.Point(15, 82);
            this.lblGiaGioTxt.Name = "lblGiaGioTxt";
            this.lblGiaGioTxt.Size = new System.Drawing.Size(69, 13);
            this.lblGiaGioTxt.TabIndex = 3;
            this.lblGiaGioTxt.Text = "Giá theo giờ:";
            // 
            // lblTenBanDangChon
            // 
            this.lblTenBanDangChon.AutoSize = true;
            this.lblTenBanDangChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenBanDangChon.ForeColor = System.Drawing.Color.Blue;
            this.lblTenBanDangChon.Location = new System.Drawing.Point(15, 22);
            this.lblTenBanDangChon.Name = "lblTenBanDangChon";
            this.lblTenBanDangChon.Size = new System.Drawing.Size(134, 20);
            this.lblTenBanDangChon.TabIndex = 2;
            this.lblTenBanDangChon.Text = "Chưa chọn bàn";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.Coral;
            this.btnThanhToan.Enabled = false;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(350, 175);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(115, 50);
            this.btnThanhToan.TabIndex = 1;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnMoBan
            // 
            this.btnMoBan.BackColor = System.Drawing.Color.LightGreen;
            this.btnMoBan.Enabled = false;
            this.btnMoBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoBan.Location = new System.Drawing.Point(350, 115);
            this.btnMoBan.Name = "btnMoBan";
            this.btnMoBan.Size = new System.Drawing.Size(115, 50);
            this.btnMoBan.TabIndex = 0;
            this.btnMoBan.Text = "Mở Bàn";
            this.btnMoBan.UseVisualStyleBackColor = false;
            this.btnMoBan.Click += new System.EventHandler(this.btnMoBan_Click);
            // 
            // grpDichVu
            // 
            this.grpDichVu.Controls.Add(this.btnTangSL);
            this.grpDichVu.Controls.Add(this.dgvDichVu);
            this.grpDichVu.Controls.Add(this.btnThemDV);
            this.grpDichVu.Controls.Add(this.nudSoLuongDV);
            this.grpDichVu.Controls.Add(this.lblSoLuongDV);
            this.grpDichVu.Controls.Add(this.cboDichVu);
            this.grpDichVu.Controls.Add(this.lblChonDV);
            this.grpDichVu.Location = new System.Drawing.Point(445, 260);
            this.grpDichVu.Name = "grpDichVu";
            this.grpDichVu.Size = new System.Drawing.Size(475, 297);
            this.grpDichVu.TabIndex = 2;
            this.grpDichVu.TabStop = false;
            this.grpDichVu.Text = "Gọi Đồ Uống && Thuê Gậy (Disconnected DataTable)";
            // 
            // btnTangSL
            // 
            this.btnTangSL.Enabled = false;
            this.btnTangSL.Location = new System.Drawing.Point(385, 55);
            this.btnTangSL.Name = "btnTangSL";
            this.btnTangSL.Size = new System.Drawing.Size(80, 26);
            this.btnTangSL.TabIndex = 6;
            this.btnTangSL.Text = "Tăng SL (+1)";
            this.btnTangSL.UseVisualStyleBackColor = true;
            this.btnTangSL.Click += new System.EventHandler(this.btnTangSL_Click);
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.AllowUserToAddRows = false;
            this.dgvDichVu.AllowUserToDeleteRows = false;
            this.dgvDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Location = new System.Drawing.Point(10, 90);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDichVu.Size = new System.Drawing.Size(455, 195);
            this.dgvDichVu.TabIndex = 5;
            this.dgvDichVu.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDichVu_CellEndEdit);
            // 
            // btnThemDV
            // 
            this.btnThemDV.Enabled = false;
            this.btnThemDV.Location = new System.Drawing.Point(295, 55);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(80, 26);
            this.btnThemDV.TabIndex = 4;
            this.btnThemDV.Text = "Thêm Món";
            this.btnThemDV.UseVisualStyleBackColor = true;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // nudSoLuongDV
            // 
            this.nudSoLuongDV.Location = new System.Drawing.Point(220, 58);
            this.nudSoLuongDV.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudSoLuongDV.Name = "nudSoLuongDV";
            this.nudSoLuongDV.Size = new System.Drawing.Size(60, 20);
            this.nudSoLuongDV.TabIndex = 3;
            this.nudSoLuongDV.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblSoLuongDV
            // 
            this.lblSoLuongDV.AutoSize = true;
            this.lblSoLuongDV.Location = new System.Drawing.Point(160, 61);
            this.lblSoLuongDV.Name = "lblSoLuongDV";
            this.lblSoLuongDV.Size = new System.Drawing.Size(52, 13);
            this.lblSoLuongDV.TabIndex = 2;
            this.lblSoLuongDV.Text = "Số lượng:";
            // 
            // cboDichVu
            // 
            this.cboDichVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDichVu.FormattingEnabled = true;
            this.cboDichVu.Location = new System.Drawing.Point(90, 23);
            this.cboDichVu.Name = "cboDichVu";
            this.cboDichVu.Size = new System.Drawing.Size(375, 21);
            this.cboDichVu.TabIndex = 1;
            // 
            // lblChonDV
            // 
            this.lblChonDV.AutoSize = true;
            this.lblChonDV.Location = new System.Drawing.Point(10, 26);
            this.lblChonDV.Name = "lblChonDV";
            this.lblChonDV.Size = new System.Drawing.Size(71, 13);
            this.lblChonDV.TabIndex = 0;
            this.lblChonDV.Text = "Chọn dịch vụ:";
            // 
            // frmBilliards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 571);
            this.Controls.Add(this.grpDichVu);
            this.Controls.Add(this.grpThongTinBan);
            this.Controls.Add(this.flpBanBida);
            this.Name = "frmBilliards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Bàn Bida & Dịch Vụ Giải Trí (Billiards Club Management System)";
            this.Load += new System.EventHandler(this.frmBilliards_Load);
            this.grpThongTinBan.ResumeLayout(false);
            this.grpThongTinBan.PerformLayout();
            this.grpDichVu.ResumeLayout(false);
            this.grpDichVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpBanBida;
        private System.Windows.Forms.GroupBox grpThongTinBan;
        private System.Windows.Forms.Button btnMoBan;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label lblTenBanDangChon;
        private System.Windows.Forms.Label lblGiaGioTxt;
        private System.Windows.Forms.Label lblGiaGio;
        private System.Windows.Forms.Label lblGioBatDauTxt;
        private System.Windows.Forms.Label lblGioBatDau;
        private System.Windows.Forms.Label lblTienGioChoiTxt;
        private System.Windows.Forms.Label lblTienGioChoi;
        private System.Windows.Forms.Label lblTienDichVuTxt;
        private System.Windows.Forms.Label lblTienDichVu;
        private System.Windows.Forms.Label lblTongTienTxt;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnCapNhatTienGio;
        private System.Windows.Forms.Label lblLoaiBanTxt;
        private System.Windows.Forms.Label lblLoaiBan;
        private System.Windows.Forms.GroupBox grpDichVu;
        private System.Windows.Forms.Label lblChonDV;
        private System.Windows.Forms.ComboBox cboDichVu;
        private System.Windows.Forms.Label lblSoLuongDV;
        private System.Windows.Forms.NumericUpDown nudSoLuongDV;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.Button btnTangSL;
    }
}
