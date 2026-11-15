using System.Data;
using ClinicSystem.DAL;
using ClinicSystem.DTO;

namespace ClinicSystem.BUS
{
    public class ThuocBUS
    {
        private ThuocDAL dal = new ThuocDAL();

        public DataTable GetAllThuoc() => dal.GetAllThuoc();

        public bool ThemThuocMoi(ThuocDTO thuoc, out string error)
        {
            error = "";
            if (string.IsNullOrWhiteSpace(thuoc.TenThuoc))
            {
                error = "Tên thuốc không được để trống!";
                return false;
            }
            if (thuoc.DonGia < 0 || thuoc.SoLuongTon < 0)
            {
                error = "Đơn giá và số lượng tồn không được âm!";
                return false;
            }
            return dal.InsertThuoc(thuoc);
        }

        public bool CapNhatDonGia(int maThuoc, string tenThuoc, string donViTinh, decimal donGiaMoi, out string error)
        {
            error = "";
            if (string.IsNullOrWhiteSpace(tenThuoc))
            {
                error = "Tên thuốc không được để trống!";
                return false;
            }
            if (donGiaMoi < 0)
            {
                error = "Đơn giá mới không được âm!";
                return false;
            }
            return dal.UpdateDonGiaThuoc(maThuoc, tenThuoc, donViTinh, donGiaMoi);
        }

        public bool NhapThemTonKho(int maThuoc, int soLuongNhap, out string error)
        {
            error = "";
            if (soLuongNhap <= 0)
            {
                error = "Số lượng nhập thêm phải lớn hơn 0!";
                return false;
            }
            return dal.NhapThemTonKho(maThuoc, soLuongNhap);
        }
    }
}