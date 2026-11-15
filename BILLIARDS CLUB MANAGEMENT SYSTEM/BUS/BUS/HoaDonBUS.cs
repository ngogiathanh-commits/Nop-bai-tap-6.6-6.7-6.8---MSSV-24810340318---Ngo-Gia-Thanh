using System.Data;
using BilliardsClubManagement.DAL;
using BilliardsClubManagement.DTO;

namespace BilliardsClubManagement.BUS
{
    public class HoaDonBUS
    {
        private HoaDonDAL dal = new HoaDonDAL();

        public HoaDonDTO GetHoaDonActiveByMaBan(int maBan) => dal.GetHoaDonActiveByMaBan(maBan);

        public bool MoBan(int maBan) => dal.MoBan(maBan);

        public DataTable GetChiTietHoaDonByMaHD(int maHD) => dal.GetChiTietHoaDonByMaHD(maHD);

        public bool ThemHoacTangDichVu(int maHD, int maDV, int soLuongThem, decimal donGia)
        {
            if (soLuongThem <= 0) return false;
            return dal.ThemHoacTangDichVu(maHD, maDV, soLuongThem, donGia);
        }

        public bool CapNhatSoLuongDichVu(int maHD, int maDV, int soLuongMoi)
        {
            if (soLuongMoi <= 0) return false;
            return dal.CapNhatSoLuongDichVu(maHD, maDV, soLuongMoi);
        }

        public bool ThanhToanWithTransaction(int maHD, int maBan, decimal tienGioChoi, decimal tienDichVu, out string error)
        {
            return dal.ThanhToanWithTransaction(maHD, maBan, tienGioChoi, tienDichVu, out error);
        }
    }
}
