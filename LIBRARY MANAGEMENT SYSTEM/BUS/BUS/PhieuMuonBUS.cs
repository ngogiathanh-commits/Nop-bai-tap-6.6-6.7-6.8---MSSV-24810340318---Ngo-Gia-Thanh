using System;
using System.Collections.Generic;
using System.Data;
using LibraryManagement.DAL;
using LibraryManagement.DTO;

namespace LibraryManagement.BUS
{
    public class PhieuMuonBUS
    {
        private PhieuMuonDAL pmDAL = new PhieuMuonDAL();
        private DocGiaDAL dgDAL = new DocGiaDAL();

        public DataTable GetPhieuMuonFiltered(int? maDocGia, string trangThai)
        {
            return pmDAL.GetPhieuMuonFiltered(maDocGia, trangThai);
        }

        public bool LapPhieuMuon(PhieuMuonDTO phieu, List<ChiTietMuonDTO> listChiTiet, out string error)
        {
            error = "";
            if (listChiTiet == null || listChiTiet.Count == 0)
            {
                error = "Vui lòng chọn ít nhất 1 đầu sách để lập phiếu mượn!";
                return false;
            }
            if (phieu.HanTra.Date < DateTime.Now.Date)
            {
                error = "Hạn trả sách phải lớn hơn hoặc bằng ngày hiện tại!";
                return false;
            }
            
            if (!dgDAL.KiemTraTheConHan(phieu.MaDocGia))
            {
                error = "Thẻ thư viện của độc giả này đã HẾT HẠN! Không thể lập phiếu mượn mới.";
                return false;
            }

            return pmDAL.LapPhieuMuonWithTransaction(phieu, listChiTiet, out error);
        }

        public bool TraSach(int maPhieu, out string error) => pmDAL.TraSach(maPhieu, out error);

        public List<string> GetPhieuMuonQuaHan() => pmDAL.GetPhieuMuonQuaHan();

        public int GetTongLuotSachMuon() => pmDAL.GetTongLuotSachMuon();

        public DataTable GetThongKeMuonTheoTheLoai() => pmDAL.GetThongKeMuonTheoTheLoai();
    }
}
