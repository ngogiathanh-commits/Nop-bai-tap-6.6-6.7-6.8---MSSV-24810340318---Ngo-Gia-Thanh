using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using LibraryManagement.BUS;
using LibraryManagement.DTO;

namespace LibraryManagement.GUI
{
    public partial class frmLibrary : Form
    {
        private DocGiaBUS dgBUS = new DocGiaBUS();
        private DauSachBUS sachBUS = new DauSachBUS();
        private PhieuMuonBUS pmBUS = new PhieuMuonBUS();

        private List<ChiTietMuonDTO> listGioMuon = new List<ChiTietMuonDTO>();
        private int selectedMaSach = -1;
        private int selectedMaDocGia = -1;

        public frmLibrary()
        {
            InitializeComponent();
        }

        private void frmLibrary_Load(object sender, EventArgs e)
        {
            cboLocTrangThai.SelectedIndex = 0; 
            cboTheLoai.SelectedIndex = 0;      
            dtpHanTra.Value = DateTime.Now.AddDays(14);

            LoadAllCombosAndGrids();
            LoadBaoCaoVaCanhBao();
        }

        private void LoadAllCombosAndGrids()
        {
            
            DataTable dtDG = dgBUS.GetAllDocGia();
            dgvDocGia.DataSource = dtDG;

            cboDocGiaMuon.DataSource = dtDG.Copy();
            cboDocGiaMuon.DisplayMember = "HoTen";
            cboDocGiaMuon.ValueMember = "MaDocGia";

            DataTable dtDGFilter = dtDG.Copy();
            DataRow drAll = dtDGFilter.NewRow();
            drAll["MaDocGia"] = 0;
            drAll["HoTen"] = "-- Tất cả độc giả --";
            drAll["Email"] = "";
            drAll["NgayHetHanThe"] = DateTime.Now;
            dtDGFilter.Rows.InsertAt(drAll, 0);

            cboLocDocGia.DataSource = dtDGFilter;
            cboLocDocGia.DisplayMember = "HoTen";
            cboLocDocGia.ValueMember = "MaDocGia";

            
            DataTable dtSach = sachBUS.GetAllDauSach();
            dgvDauSach.DataSource = dtSach;

            cboSachMuon.DataSource = dtSach.Copy();
            cboSachMuon.DisplayMember = "TenSach";
            cboSachMuon.ValueMember = "MaSach";

           
            LocDanhSachPhieuMuon();
        }

        
        private void btnLocPhieu_Click(object sender, EventArgs e)
        {
            LocDanhSachPhieuMuon();
        }

        private void LocDanhSachPhieuMuon()
        {
            int? maDG = cboLocDocGia.SelectedValue != null ? Convert.ToInt32(cboLocDocGia.SelectedValue) : 0;
            string trangThai = cboLocTrangThai.SelectedItem?.ToString() ?? "Tất cả";
            dgvPhieuMuon.DataSource = pmBUS.GetPhieuMuonFiltered(maDG, trangThai);
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            if (dgvPhieuMuon.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn cần trả sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maPhieu = Convert.ToInt32(dgvPhieuMuon.CurrentRow.Cells["MaPhieu"].Value);
            string trangThai = dgvPhieuMuon.CurrentRow.Cells["TrangThai"].Value.ToString();

            if (trangThai == "Đã trả")
            {
                MessageBox.Show("Phiếu mượn này đã ở trạng thái 'Đã trả'!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show($"Xác nhận độc giả đã trả toàn bộ sách của Phiếu #{maPhieu}?", "Xác nhận Trả Sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (pmBUS.TraSach(maPhieu, out string error))
                {
                    MessageBox.Show("Trả sách thành công! Đã cập nhật trạng thái 'Đã trả' và hoàn trả số lượng tồn kho.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllCombosAndGrids();
                    LoadBaoCaoVaCanhBao();
                }
                else
                {
                    MessageBox.Show(error, "Lỗi Trả Sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

      
        private void btnThemSachVaoPhieu_Click(object sender, EventArgs e)
        {
            if (cboSachMuon.SelectedValue == null) return;

            int maSach = Convert.ToInt32(cboSachMuon.SelectedValue);
            DataRowView drv = cboSachMuon.SelectedItem as DataRowView;
            string tenSach = drv["TenSach"].ToString();
            int soLuong = (int)nudSoLuongMuon.Value;

            var existing = listGioMuon.FirstOrDefault(x => x.MaSach == maSach);
            if (existing != null)
            {
                existing.SoLuong += soLuong;
            }
            else
            {
                listGioMuon.Add(new ChiTietMuonDTO
                {
                    MaSach = maSach,
                    TenSach = tenSach,
                    SoLuong = soLuong
                });
            }

            dgvChiTietMuonTam.DataSource = null;
            dgvChiTietMuonTam.DataSource = listGioMuon;
        }

        private void btnLapPhieuMuon_Click(object sender, EventArgs e)
        {
            if (cboDocGiaMuon.SelectedValue == null) return;

            PhieuMuonDTO phieu = new PhieuMuonDTO
            {
                MaDocGia = Convert.ToInt32(cboDocGiaMuon.SelectedValue),
                HanTra = dtpHanTra.Value
            };

            if (pmBUS.LapPhieuMuon(phieu, listGioMuon, out string error))
            {
                MessageBox.Show("Lập phiếu mượn sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listGioMuon.Clear();
                dgvChiTietMuonTam.DataSource = null;
                LoadAllCombosAndGrids();
                LoadBaoCaoVaCanhBao();
            }
            else
            {
                MessageBox.Show(error, "Không Thể Lập Phiếu Mượn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void dgvDauSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDauSach.Rows[e.RowIndex];
                selectedMaSach = Convert.ToInt32(row.Cells["MaSach"].Value);
                txtTenSach.Text = row.Cells["TenSach"].Value.ToString();
                cboTheLoai.Text = row.Cells["TheLoai"].Value.ToString();
                nudSoLuongCon.Value = Convert.ToDecimal(row.Cells["SoLuongCon"].Value);
            }
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            DauSachDTO sach = new DauSachDTO
            {
                TenSach = txtTenSach.Text.Trim(),
                TheLoai = cboTheLoai.Text,
                SoLuongCon = (int)nudSoLuongCon.Value
            };

            if (sachBUS.ThemDauSach(sach, out string error))
            {
                MessageBox.Show("Thêm đầu sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllCombosAndGrids();
            }
            else
            {
                MessageBox.Show(error, "Lỗi Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            if (selectedMaSach == -1) return;

            DauSachDTO sach = new DauSachDTO
            {
                MaSach = selectedMaSach,
                TenSach = txtTenSach.Text.Trim(),
                TheLoai = cboTheLoai.Text,
                SoLuongCon = (int)nudSoLuongCon.Value
            };

            if (sachBUS.SuaDauSach(sach, out string error))
            {
                MessageBox.Show("Cập nhật đầu sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllCombosAndGrids();
            }
            else
            {
                MessageBox.Show(error, "Lỗi Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            if (selectedMaSach == -1) return;

            if (MessageBox.Show("Xác nhận xóa đầu sách này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (sachBUS.XoaDauSach(selectedMaSach))
                {
                    MessageBox.Show("Xóa đầu sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    selectedMaSach = -1;
                    LoadAllCombosAndGrids();
                }
            }
        }

        
        private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDocGia.Rows[e.RowIndex];
                selectedMaDocGia = Convert.ToInt32(row.Cells["MaDocGia"].Value);
                txtHoTenDG.Text = row.Cells["HoTen"].Value.ToString();
                txtEmailDG.Text = row.Cells["Email"].Value.ToString();
                dtpNgayHetHanThe.Value = Convert.ToDateTime(row.Cells["NgayHetHanThe"].Value);
            }
        }

        private void btnThemDG_Click(object sender, EventArgs e)
        {
            DocGiaDTO dg = new DocGiaDTO
            {
                HoTen = txtHoTenDG.Text.Trim(),
                Email = txtEmailDG.Text.Trim(),
                NgayHetHanThe = dtpNgayHetHanThe.Value
            };

            if (dgBUS.ThemDocGia(dg, out string error))
            {
                MessageBox.Show("Thêm độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllCombosAndGrids();
            }
            else
            {
                MessageBox.Show(error, "Lỗi Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSuaDG_Click(object sender, EventArgs e)
        {
            if (selectedMaDocGia == -1) return;

            DocGiaDTO dg = new DocGiaDTO
            {
                MaDocGia = selectedMaDocGia,
                HoTen = txtHoTenDG.Text.Trim(),
                Email = txtEmailDG.Text.Trim(),
                NgayHetHanThe = dtpNgayHetHanThe.Value
            };

            if (dgBUS.SuaDocGia(dg, out string error))
            {
                MessageBox.Show("Cập nhật thông tin độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllCombosAndGrids();
            }
            else
            {
                MessageBox.Show(error, "Lỗi Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaDG_Click(object sender, EventArgs e)
        {
            if (selectedMaDocGia == -1) return;

            if (MessageBox.Show("Xác nhận xóa độc giả này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgBUS.XoaDocGia(selectedMaDocGia))
                {
                    MessageBox.Show("Xóa độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    selectedMaDocGia = -1;
                    LoadAllCombosAndGrids();
                }
            }
        }

        
        private void LoadBaoCaoVaCanhBao()
        {
            lstPhieuQuaHan.Items.Clear();
            List<string> overdueList = pmBUS.GetPhieuMuonQuaHan();
            foreach (string item in overdueList)
            {
                lstPhieuQuaHan.Items.Add(item);
            }

            lblCanhBaoQuaHan.Text = overdueList.Count > 0
                ? $"CẢNH BÁO QUÁ HẠN (SqlDataReader): Có {overdueList.Count} phiếu mượn đã quá hạn trả!"
                : "CẢNH BÁO QUÁ HẠN: Không có phiếu mượn nào quá hạn.";

            int tongLuot = pmBUS.GetTongLuotSachMuon();
            lblTongLuotMuon.Text = $"Thống kê lượt mượn theo Thể loại (Tổng toàn thư viện: {tongLuot} cuốn đã mượn):";

            dgvThongKeTheLoai.DataSource = pmBUS.GetThongKeMuonTheoTheLoai();
        }

        private void btnLamMoiBaoCao_Click(object sender, EventArgs e)
        {
            LoadBaoCaoVaCanhBao();
        }
    }
}
