using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BilliardsClubManagement.BUS;
using BilliardsClubManagement.DTO;

namespace BilliardsClubManagement.GUI
{
    public partial class frmBilliards : Form
    {
        private BanBidaBUS banBUS = new BanBidaBUS();
        private MenuDichVuBUS menuBUS = new MenuDichVuBUS();
        private HoaDonBUS hoaDonBUS = new HoaDonBUS();

        private int selectedMaBan = -1;
        private string selectedTenBan = "";
        private string selectedLoaiBan = "";
        private decimal selectedGiaTheoGio = 0;
        private string selectedTrangThaiBan = "";

        private HoaDonDTO currentHoaDon = null;
        private DataTable dtChiTietDV = null;

        public frmBilliards()
        {
            InitializeComponent();
        }

        private void frmBilliards_Load(object sender, EventArgs e)
        {
            LoadSoDoBanBida();
            LoadMenuDichVuCombo();
        }

        // 1. HIỂN THỊ SƠ ĐỒ BÀN BIDA DẠNG BUTTON ĐỘNG
        private void LoadSoDoBanBida()
        {
            flpBanBida.Controls.Clear();
            DataTable dtBan = banBUS.GetAllBanBida();

            foreach (DataRow row in dtBan.Rows)
            {
                string tenBan = row["TenBan"].ToString();
                string loaiBan = row["LoaiBan"].ToString();
                string trangThai = row["TrangThai"].ToString();

                Button btn = new Button
                {
                    Width = 120,
                    Height = 95,
                    Text = $"{tenBan}\n({loaiBan})\n[{trangThai}]",
                    Tag = row,
                    Font = new Font("Arial", 9, FontStyle.Bold),
                    Margin = new Padding(6)
                };

                // Bàn "Trống" màu xanh lá, bàn "Đang chơi" màu cam/đỏ
                if (trangThai == "Trống")
                {
                    btn.BackColor = Color.LightGreen;
                    btn.ForeColor = Color.Black;
                }
                else
                {
                    btn.BackColor = Color.OrangeRed;
                    btn.ForeColor = Color.White;
                }

                btn.Click += BtnBan_Click;
                flpBanBida.Controls.Add(btn);
            }
        }

        // SỰ KIỆN CHỌN BÀN BIDA TRÊN SƠ ĐỒ
        private void BtnBan_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            DataRow row = btn.Tag as DataRow;

            selectedMaBan = Convert.ToInt32(row["MaBan"]);
            selectedTenBan = row["TenBan"].ToString();
            selectedLoaiBan = row["LoaiBan"].ToString();
            selectedGiaTheoGio = Convert.ToDecimal(row["GiaTheoGio"]);
            selectedTrangThaiBan = row["TrangThai"].ToString();

            lblTenBanDangChon.Text = selectedTenBan;
            lblLoaiBan.Text = selectedLoaiBan;
            lblGiaGio.Text = $"{selectedGiaTheoGio:N0} VNĐ/Giờ";

            if (selectedTrangThaiBan == "Đang chơi")
            {
                btnMoBan.Enabled = false;
                btnThanhToan.Enabled = true;
                btnThemDV.Enabled = true;
                btnTangSL.Enabled = true;

                currentHoaDon = hoaDonBUS.GetHoaDonActiveByMaBan(selectedMaBan);
                if (currentHoaDon != null)
                {
                    lblGioBatDau.Text = currentHoaDon.GioBatDau.ToString("dd/MM/yyyy HH:mm:ss");
                    LoadDichVuHoaDon(currentHoaDon.MaHD);
                }
            }
            else
            {
                btnMoBan.Enabled = true;
                btnThanhToan.Enabled = false;
                btnThemDV.Enabled = false;
                btnTangSL.Enabled = false;

                lblGioBatDau.Text = "--:--";
                currentHoaDon = null;
                dtChiTietDV = null;
                dgvDichVu.DataSource = null;
                TinhTongTienTamTinh();
            }
        }

        // 2. MỞ BÀN BIDA
        private void btnMoBan_Click(object sender, EventArgs e)
        {
            if (selectedMaBan == -1 || selectedTrangThaiBan != "Trống") return;

            if (hoaDonBUS.MoBan(selectedMaBan))
            {
                MessageBox.Show($"Mở {selectedTenBan} thành công! Bắt đầu tính giờ chơi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSoDoBanBida();
                ResetFormState();
            }
            else
            {
                MessageBox.Show("Không thể mở bàn! Vui lòng kiểm tra kết nối CSDL.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. GỌI ĐỒ UỐNG / THUÊ PHỤ KIỆN (DISCONNECTED MODEL - DATATABLE)
        private void LoadMenuDichVuCombo()
        {
            cboDichVu.DataSource = menuBUS.GetAllMenuDichVu();
            cboDichVu.DisplayMember = "TenDV";
            cboDichVu.ValueMember = "MaDV";
        }

        private void LoadDichVuHoaDon(int maHD)
        {
            // Nạp dữ liệu vào DataTable ngắt kết nối qua SqlDataAdapter
            dtChiTietDV = hoaDonBUS.GetChiTietHoaDonByMaHD(maHD);
            dgvDichVu.DataSource = dtChiTietDV;

            if (dgvDichVu.Columns["MaDV"] != null) dgvDichVu.Columns["MaDV"].ReadOnly = true;
            if (dgvDichVu.Columns["TenDV"] != null) dgvDichVu.Columns["TenDV"].ReadOnly = true;
            if (dgvDichVu.Columns["DonGia"] != null) dgvDichVu.Columns["DonGia"].ReadOnly = true;
            if (dgvDichVu.Columns["ThanhTien"] != null) dgvDichVu.Columns["ThanhTien"].ReadOnly = true;
            if (dgvDichVu.Columns["SoLuong"] != null) dgvDichVu.Columns["SoLuong"].ReadOnly = false;

            TinhTongTienTamTinh();
        }

        // Thêm món mới hoặc cộng dồn số lượng
        private void btnThemDV_Click(object sender, EventArgs e)
        {
            if (currentHoaDon == null || cboDichVu.SelectedValue == null) return;

            int maDV = Convert.ToInt32(cboDichVu.SelectedValue);
            DataRowView drv = cboDichVu.SelectedItem as DataRowView;
            decimal donGia = Convert.ToDecimal(drv["DonGia"]);
            int soLuong = (int)nudSoLuongDV.Value;

            if (hoaDonBUS.ThemHoacTangDichVu(currentHoaDon.MaHD, maDV, soLuong, donGia))
            {
                LoadDichVuHoaDon(currentHoaDon.MaHD);
            }
        }

        // Tăng nhanh số lượng (+1) cho món đang chọn trên DataGridView
        private void btnTangSL_Click(object sender, EventArgs e)
        {
            if (currentHoaDon == null || dgvDichVu.CurrentRow == null) return;

            int maDV = Convert.ToInt32(dgvDichVu.CurrentRow.Cells["MaDV"].Value);
            decimal donGia = Convert.ToDecimal(dgvDichVu.CurrentRow.Cells["DonGia"].Value);

            if (hoaDonBUS.ThemHoacTangDichVu(currentHoaDon.MaHD, maDV, 1, donGia))
            {
                LoadDichVuHoaDon(currentHoaDon.MaHD);
            }
        }

        // Sửa trực tiếp cột SoLuong trên DataGridView (Disconnected DataTable)
        private void dgvDichVu_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (currentHoaDon == null || e.RowIndex < 0) return;

            if (dgvDichVu.Columns[e.ColumnIndex].Name == "SoLuong")
            {
                DataGridViewRow row = dgvDichVu.Rows[e.RowIndex];
                int maDV = Convert.ToInt32(row.Cells["MaDV"].Value);

                if (int.TryParse(row.Cells["SoLuong"].Value?.ToString(), out int soLuongMoi) && soLuongMoi > 0)
                {
                    hoaDonBUS.CapNhatSoLuongDichVu(currentHoaDon.MaHD, maDV, soLuongMoi);
                    LoadDichVuHoaDon(currentHoaDon.MaHD);
                }
                else
                {
                    MessageBox.Show("Số lượng dịch vụ phải là số nguyên lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadDichVuHoaDon(currentHoaDon.MaHD);
                }
            }
        }

        // 4. TÍNH TIỀN GIỜ THEO BLOCK 15 PHÚT & THANH TOÁN (SQLTRANSACTION)
        private (decimal tienGioChoi, decimal tienDichVu, int soPhutThucTe, decimal soGioLamTron) TinhChiTietTien()
        {
            decimal tienDV = 0;
            if (dtChiTietDV != null)
            {
                foreach (DataRow row in dtChiTietDV.Rows)
                {
                    tienDV += Convert.ToDecimal(row["ThanhTien"]);
                }
            }

            decimal tienGio = 0;
            int soPhut = 0;
            decimal soGioTron = 0;

            if (currentHoaDon != null)
            {
                TimeSpan duration = DateTime.Now - currentHoaDon.GioBatDau;
                soPhut = Math.Max(1, (int)Math.Ceiling(duration.TotalMinutes));

                // Làm tròn theo block 15 phút (1 block = 0.25 giờ)
                int soBlock15Phut = (int)Math.Ceiling(soPhut / 15.0);
                soGioTron = soBlock15Phut * 0.25m;
                tienGio = soGioTron * selectedGiaTheoGio;
            }

            return (tienGio, tienDV, soPhut, soGioTron);
        }

        private void TinhTongTienTamTinh()
        {
            var kq = TinhChiTietTien();

            lblTienDichVu.Text = $"{kq.tienDichVu:N0} VNĐ";
            if (currentHoaDon != null)
            {
                lblTienGioChoi.Text = $"{kq.tienGioChoi:N0} VNĐ ({kq.soPhutThucTe} phút -> {kq.soGioLamTron:0.##}h)";
            }
            else
            {
                lblTienGioChoi.Text = "0 VNĐ";
            }

            decimal tongCong = kq.tienGioChoi + kq.tienDichVu;
            lblTongTien.Text = $"{tongCong:N0} VNĐ";
        }

        private void btnCapNhatTienGio_Click(object sender, EventArgs e)
        {
            if (currentHoaDon != null)
            {
                TinhTongTienTamTinh();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (currentHoaDon == null) return;

            var kq = TinhChiTietTien();
            decimal tongCong = kq.tienGioChoi + kq.tienDichVu;

            string msg = $"XÁC NHẬN THANH TOÁN {selectedTenBan}\n" +
                         $"Thời gian chơi: {kq.soPhutThucTe} phút (Làm tròn: {kq.soGioLamTron:0.##} giờ)\n" +
                         $"Tiền giờ chơi : {kq.tienGioChoi:N0} VNĐ\n" +
                         $"Tiền dịch vụ  : {kq.tienDichVu:N0} VNĐ\n" +
                         $"----------------------------------------\n" +
                         $"TỔNG THANH TOÁN: {tongCong:N0} VNĐ";

            if (MessageBox.Show(msg, "Xác Nhận Thanh Toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (hoaDonBUS.ThanhToanWithTransaction(currentHoaDon.MaHD, selectedMaBan, kq.tienGioChoi, kq.tienDichVu, out string error))
                {
                    MessageBox.Show("Thanh toán thành công! Bàn đã chuyển về trạng thái 'Trống'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSoDoBanBida();
                    LoadMenuDichVuCombo();
                    ResetFormState();
                }
                else
                {
                    MessageBox.Show(error, "Lỗi SqlTransaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ResetFormState()
        {
            selectedMaBan = -1;
            selectedTrangThaiBan = "";
            currentHoaDon = null;
            dtChiTietDV = null;

            lblTenBanDangChon.Text = "Chưa chọn bàn";
            lblLoaiBan.Text = "---";
            lblGiaGio.Text = "0 VNĐ/Giờ";
            lblGioBatDau.Text = "--:--";
            lblTienGioChoi.Text = "0 VNĐ";
            lblTienDichVu.Text = "0 VNĐ";
            lblTongTien.Text = "0 VNĐ";

            dgvDichVu.DataSource = null;
            btnMoBan.Enabled = false;
            btnThanhToan.Enabled = false;
            btnThemDV.Enabled = false;
            btnTangSL.Enabled = false;
        }
    }
}
