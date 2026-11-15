using System.Collections.Generic;
using System.Data;
using ClinicSystem.DAL;
using ClinicSystem.DTO;

namespace ClinicSystem.BUS
{
    public class DonThuocBUS
    {
        private DonThuocDAL dal = new DonThuocDAL();

        public bool LuuVaXuatDonThuoc(int maHoSo, string chanDoan, DonThuocDTO donThuoc, List<ChiTietDonThuocDTO> listChiTiet, out int maDonMoi, out string errorMessage)
        {
            maDonMoi = -1;
            errorMessage = "";

            if (maHoSo <= 0)
            {
                errorMessage = "Vui lòng chọn hồ sơ khám bệnh nhân!";
                return false;
            }
            if (string.IsNullOrWhiteSpace(chanDoan))
            {
                errorMessage = "Vui lòng nhập chẩn đoán bệnh trước khi kê đơn!";
                return false;
            }
            if (listChiTiet == null || listChiTiet.Count == 0)
            {
                errorMessage = "Vui lòng kê ít nhất 1 loại thuốc vào đơn!";
                return false;
            }

            return dal.LuuVaXuatDonThuocWithTransaction(maHoSo, chanDoan, donThuoc, listChiTiet, out maDonMoi, out errorMessage);
        }

        public DataTable GetAllDonThuoc() => dal.GetAllDonThuoc();

        public DataTable GetChiTietDonThuoc(int maDon) => dal.GetChiTietDonThuoc(maDon);

        public bool ThanhToanDonThuoc(int maDon) => dal.ThanhToanDonThuoc(maDon);
    }
}
