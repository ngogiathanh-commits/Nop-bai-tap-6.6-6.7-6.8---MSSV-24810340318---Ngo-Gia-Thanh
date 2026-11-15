using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicSystem.BUS;
using ClinicSystem.DTO;

namespace ClinicSystem.GUI
{
    public partial class frmClinic : Form
    {
        private BenhNhanBUS bnBUS = new BenhNhanBUS();
        private ThuocBUS thuocBUS = new ThuocBUS();
        private DonThuocBUS donThuocBUS = new DonThuocBUS();

        private BenhNhanDTO currentBenhNhan = null;
        private bool isNewPatient = true;
        private List<ChiTietDonThuocDTO> listChiTietDon = new List<ChiTietDonThuocDTO>();
        private int selectedMaThuocKho = -1;

        public frmClinic()
        {
            InitializeComponent();
        }

        private void frmClinic_Load(object sender, EventArgs e)
        {
            cboDonViTinh.SelectedIndex = 0;
            LoadDanhSachHoSo();
            LoadDanhSachThuoc();
            LoadDanhSachDonThuoc();
            CapNhatTongTienDon();
        }

        private void LoadDanhSachHoSo()
        {
            DataTable dt = bnBUS.GetAllHoSoKham();
            cboHoSoKham.DataSource = dt;
            cboHoSoKham.DisplayMember = "HienThiHoSo";
            cboHoSoKham.ValueMember = "MaHoSo";
        }

        private void LoadDanhSachThuoc()
        {
            DataTable dt = thuocBUS.GetAllThuoc();
            cboThuoc.DataSource = dt;
            cboThuoc.DisplayMember = "TenThuoc";
            cboThuoc.ValueMember = "MaThuoc";

            dgvKhoThuoc.DataSource = dt.Copy();
        }

        private void LoadDanhSachDonThuoc()
        {
            dgvDonThuoc.DataSource = donThuocBUS.GetAllDonThuoc();
        }

        // 1. TRA CỨU BỆNH NHÂN THEO SỐ ĐIỆN THOẠI BẰNG SQLPARAMETER
        private void btnTimBN_Click(object sender, EventArgs e)
        {
            string sdt = txtTimSDT.Text.Trim();
            currentBenhNhan = bnBUS.GetBenhNhanBySDT(sdt);

            if (currentBenhNhan != null)
            {
                isNewPatient = false;
                txtHoTen.Text = currentBenhNhan.HoTen;
                txtSDT.Text = currentBenhNhan.SoDienThoai;
                nudNamSinh.Value = currentBenhNhan.NamSinh;
                txtTrieuChung.Clear();

                MessageBox.Show($"Tìm thấy bệnh nhân cũ: {currentBenhNhan.HoTen} (Năm sinh: {currentBenhNhan.NamSinh}).\nNhập triệu chứng và bấm Tiếp nhận để tạo Hồ sơ khám mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                isNewPatient = true;
                currentBenhNhan = null;
                txtHoTen.Clear();
                txtSDT.Text = sdt;
                nudNamSinh.Value = 1995;
                txtTrieuChung.Clear();

                MessageBox.Show("Bệnh nhân mới! Vui lòng nhập đầy đủ thông tin bệnh nhân và triệu chứng để tiếp nhận.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // 2. TIẾP NHẬN BỆNH NHÂN & TẠO HỒ SƠ KHÁM
        private void btnTiepNhan_Click(object sender, EventArgs e)
        {
            BenhNhanDTO bn = new BenhNhanDTO
            {
                MaBN = currentBenhNhan?.MaBN ?? 0,
                HoTen = txtHoTen.Text.Trim(),
                SoDienThoai = txtSDT.Text.Trim(),
                NamSinh = (int)nudNamSinh.Value
            };

            HoSoKhamDTO hs = new HoSoKhamDTO
            {
                TrieuChung = txtTrieuChung.Text.Trim()
            };

            if (bnBUS.TiepNhanVaTaoHoSo(bn, hs, isNewPatient, out int maHoSoMoi, out string error))
            {
                MessageBox.Show($"Tiếp nhận thành công! Đã tạo Hồ Sơ Khám #{maHoSoMoi}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachHoSo();
                cboHoSoKham.SelectedValue = maHoSoMoi;
                isNewPatient = false;
            }
            else
            {
                MessageBox.Show(error, "Lỗi Tiếp Nhận", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. THÊM THUỐC VÀO ĐƠN TẠM & TÍNH TỔNG TIỀN
        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            if (cboThuoc.SelectedValue == null) return;

            int maThuoc = Convert.ToInt32(cboThuoc.SelectedValue);
            DataRowView drv = cboThuoc.SelectedItem as DataRowView;
            string tenThuoc = drv["TenThuoc"].ToString();
            string donViTinh = drv["DonViTinh"].ToString();
            decimal donGia = Convert.ToDecimal(drv["DonGia"]);

            int soLuong = (int)nudSoLuongThuoc.Value;
            string lieuDung = txtLieuDung.Text.Trim();

            var existing = listChiTietDon.FirstOrDefault(x => x.MaThuoc == maThuoc);
            if (existing != null)
            {
                existing.SoLuong += soLuong;
                existing.LieuDung = lieuDung;
            }
            else
            {
                listChiTietDon.Add(new ChiTietDonThuocDTO
                {
                    MaThuoc = maThuoc,
                    TenThuoc = tenThuoc,
                    DonViTinh = donViTinh,
                    DonGia = donGia,
                    SoLuong = soLuong,
                    LieuDung = lieuDung
                });
            }

            CapNhatGridVaTongTien();
        }

        private void nudTienKham_ValueChanged(object sender, EventArgs e)
        {
            CapNhatTongTienDon();
        }

        private void CapNhatGridVaTongTien()
        {
            dgvChiTietDon.DataSource = null;
            dgvChiTietDon.DataSource = listChiTietDon;
            CapNhatTongTienDon();
        }

        private void CapNhatTongTienDon()
        {
            decimal tienKham = nudTienKham.Value;
            decimal tienThuoc = listChiTietDon.Sum(x => x.ThanhTien);
            decimal tongCong = tienKham + tienThuoc;
            lblTongTienDon.Text = $"{tongCong:N0} VNĐ";
        }

        // 4. LƯU & XUẤT ĐƠN THUỐC BẰNG SQLTRANSACTION
        private void btnLuuXuatDon_Click(object sender, EventArgs e)
        {
            if (cboHoSoKham.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn hồ sơ khám của bệnh nhân!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maHoSo = Convert.ToInt32(cboHoSoKham.SelectedValue);
            string chanDoan = txtChanDoan.Text.Trim();
            decimal tienKham = nudTienKham.Value;
            decimal tongTien = tienKham + listChiTietDon.Sum(x => x.ThanhTien);

            DonThuocDTO don = new DonThuocDTO
            {
                MaHoSo = maHoSo,
                TienKham = tienKham,
                TongTien = tongTien
            };

            if (donThuocBUS.LuuVaXuatDonThuoc(maHoSo, chanDoan, don, listChiTietDon, out int maDonMoi, out string error))
            {
                MessageBox.Show($"Lưu & Xuất Đơn Thuốc #{maDonMoi} thành công!\nĐã tự động trừ số lượng tồn kho dược phẩm.", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listChiTietDon.Clear();
                txtChanDoan.Clear();
                CapNhatGridVaTongTien();
                LoadDanhSachThuoc();
                LoadDanhSachDonThuoc();
            }
            else
            {
                MessageBox.Show(error, "Cảnh Báo Tồn Kho / SqlTransaction Rollback", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 5. THANH TOÁN & IN HÓA ĐƠN VIỆN PHÍ
        private void dgvDonThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDonThuoc.Rows[e.RowIndex];
                int maDon = Convert.ToInt32(row.Cells["MaDon"].Value);
                dgvChiTietHoaDon.DataSource = donThuocBUS.GetChiTietDonThuoc(maDon);
                HienThiHoaDonIn(row);
            }
        }

        private void HienThiHoaDonIn(DataGridViewRow row)
        {
            int maDon = Convert.ToInt32(row.Cells["MaDon"].Value);
            string benhNhan = row.Cells["BenhNhan"].Value.ToString();
            string sdt = row.Cells["SoDienThoai"].Value.ToString();
            string chanDoan = row.Cells["ChanDoan"].Value.ToString();
            decimal tienKham = Convert.ToDecimal(row.Cells["TienKham"].Value);
            decimal tongTien = Convert.ToDecimal(row.Cells["TongTien"].Value);
            string trangThai = row.Cells["TrangThai"].Value.ToString();

            DataTable dtCT = donThuocBUS.GetChiTietDonThuoc(maDon);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("==========================================================");
            sb.AppendLine("           HÓA ĐƠN KHÁM BỆNH & CẤP PHÁT THUỐC             ");
            sb.AppendLine("==========================================================");
            sb.AppendLine($"Mã Đơn Thuốc : #{maDon}          Trạng thái: {trangThai}");
            sb.AppendLine($"Bệnh nhân    : {benhNhan} - SĐT: {sdt}");
            sb.AppendLine($"Chẩn đoán    : {chanDoan}");
            sb.AppendLine("----------------------------------------------------------");
            sb.AppendLine($"{"Tên Thuốc",-24} {"SL",4} {"Đơn Giá",12} {"Thành Tiền",13}");
            sb.AppendLine("----------------------------------------------------------");

            foreach (DataRow r in dtCT.Rows)
            {
                string ten = r["TenThuoc"].ToString();
                if (ten.Length > 23) ten = ten.Substring(0, 23);
                int sl = Convert.ToInt32(r["SoLuong"]);
                decimal dg = Convert.ToDecimal(r["DonGia"]);
                decimal tt = Convert.ToDecimal(r["ThanhTien"]);
                sb.AppendLine($"{ten,-24} {sl,4} {dg,12:N0} {tt,13:N0}");
            }

            sb.AppendLine("----------------------------------------------------------");
            sb.AppendLine($"Tiền khám bệnh                  : {tienKham,22:N0} VNĐ");
            sb.AppendLine($"Tiền thuốc                      : {(tongTien - tienKham),22:N0} VNĐ");
            sb.AppendLine($"TỔNG CHI PHÍ THANH TOÁN         : {tongTien,22:N0} VNĐ");
            sb.AppendLine("==========================================================");

            txtHoaDonPreview.Text = sb.ToString();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvDonThuoc.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn đơn thuốc cần thanh toán!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvDonThuoc.CurrentRow;
            int maDon = Convert.ToInt32(row.Cells["MaDon"].Value);
            string trangThai = row.Cells["TrangThai"].Value.ToString();
            decimal tongTien = Convert.ToDecimal(row.Cells["TongTien"].Value);

            if (trangThai == "Đã thanh toán")
            {
                MessageBox.Show("Đơn thuốc này đã được thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show($"Xác nhận thanh toán Đơn Thuốc #{maDon}?\nTổng chi phí: {tongTien:N0} VNĐ", "Xác Nhận Thanh Toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (donThuocBUS.ThanhToanDonThuoc(maDon))
                {
                    MessageBox.Show("Thanh toán thành công! Đã chuyển trạng thái sang 'Đã thanh toán'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachDonThuoc();
                }
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (dgvDonThuoc.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn đơn thuốc cần in hóa đơn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HienThiHoaDonIn(dgvDonThuoc.CurrentRow);
            MessageBox.Show("Đã xuất nội dung Hóa đơn khám bệnh & Đơn thuốc ra khung xem trước!", "In Hóa Đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 6. QUẢN LÝ DANH MỤC & KHO THUỐC (CRUD)
        private void dgvKhoThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhoThuoc.Rows[e.RowIndex];
                selectedMaThuocKho = Convert.ToInt32(row.Cells["MaThuoc"].Value);
                txtTenThuoc.Text = row.Cells["TenThuoc"].Value.ToString();
                cboDonViTinh.Text = row.Cells["DonViTinh"].Value.ToString();
                nudDonGiaThuoc.Value = Convert.ToDecimal(row.Cells["DonGia"].Value);
                nudSoLuongTon.Value = Convert.ToDecimal(row.Cells["SoLuongTon"].Value);
            }
        }

        private void btnThemThuocMoi_Click(object sender, EventArgs e)
        {
            ThuocDTO t = new ThuocDTO
            {
                TenThuoc = txtTenThuoc.Text.Trim(),
                DonViTinh = cboDonViTinh.Text,
                DonGia = nudDonGiaThuoc.Value,
                SoLuongTon = (int)nudSoLuongTon.Value
            };

            if (thuocBUS.ThemThuocMoi(t, out string error))
            {
                MessageBox.Show("Thêm thuốc mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachThuoc();
            }
            else
            {
                MessageBox.Show(error, "Lỗi Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCapNhatGia_Click(object sender, EventArgs e)
        {
            if (selectedMaThuocKho == -1)
            {
                MessageBox.Show("Vui lòng chọn thuốc trong bảng bên dưới!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (thuocBUS.CapNhatDonGia(selectedMaThuocKho, txtTenThuoc.Text.Trim(), cboDonViTinh.Text, nudDonGiaThuoc.Value, out string error))
            {
                MessageBox.Show("Cập nhật thông tin & đơn giá thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachThuoc();
            }
            else
            {
                MessageBox.Show(error, "Lỗi Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNhapThemKho_Click(object sender, EventArgs e)
        {
            if (selectedMaThuocKho == -1)
            {
                MessageBox.Show("Vui lòng chọn thuốc cần nhập thêm tồn kho!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int soLuongNhap = (int)nudSoLuongNhapThem.Value;
            if (thuocBUS.NhapThemTonKho(selectedMaThuocKho, soLuongNhap, out string error))
            {
                MessageBox.Show($"Đã nhập thêm {soLuongNhap} đơn vị vào kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachThuoc();
            }
            else
            {
                MessageBox.Show(error, "Lỗi Nhập Kho", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}