using System.Data;
using ClinicSystem.DAL;
using ClinicSystem.DTO;

namespace ClinicSystem.BUS
{
    public class BenhNhanBUS
    {
        private BenhNhanDAL dal = new BenhNhanDAL();

        public BenhNhanDTO GetBenhNhanBySDT(string soDienThoai)
        {
            if (string.IsNullOrWhiteSpace(soDienThoai)) return null;
            return dal.GetBenhNhanBySDT(soDienThoai.Trim());
        }

        public bool TiepNhanVaTaoHoSo(BenhNhanDTO bn, HoSoKhamDTO hoSo, bool isNewPatient, out int maHoSoMoi, out string error)
        {
            maHoSoMoi = -1;
            error = "";

            if (string.IsNullOrWhiteSpace(bn.HoTen) || string.IsNullOrWhiteSpace(bn.SoDienThoai))
            {
                error = "Họ tên và Số điện thoại bệnh nhân không được để trống!";
                return false;
            }
            if (string.IsNullOrWhiteSpace(hoSo.TrieuChung))
            {
                error = "Vui lòng nhập triệu chứng lâm sàng của bệnh nhân!";
                return false;
            }

            return dal.TiepNhanVaTaoHoSo(bn, hoSo, isNewPatient, out maHoSoMoi, out error);
        }

        public DataTable GetAllHoSoKham() => dal.GetAllHoSoKham();
    }
}
