using System.Data;
using LibraryManagement.DAL;
using LibraryManagement.DTO;

namespace LibraryManagement.BUS
{
    public class DocGiaBUS
    {
        private DocGiaDAL dal = new DocGiaDAL();

        public DataTable GetAllDocGia() => dal.GetAllDocGia();

        public bool ThemDocGia(DocGiaDTO dg, out string error)
        {
            error = "";
            if (string.IsNullOrWhiteSpace(dg.HoTen))
            {
                error = "Họ tên độc giả không được để trống!";
                return false;
            }
            if (string.IsNullOrWhiteSpace(dg.Email))
            {
                error = "Email độc giả không được để trống!";
                return false;
            }
            return dal.InsertDocGia(dg);
        }

        public bool SuaDocGia(DocGiaDTO dg, out string error)
        {
            error = "";
            if (string.IsNullOrWhiteSpace(dg.HoTen) || string.IsNullOrWhiteSpace(dg.Email))
            {
                error = "Vui lòng nhập đầy đủ Họ tên và Email!";
                return false;
            }
            return dal.UpdateDocGia(dg);
        }

        public bool XoaDocGia(int maDocGia) => dal.DeleteDocGia(maDocGia);

        public bool KiemTraTheConHan(int maDocGia) => dal.KiemTraTheConHan(maDocGia);
    }
}
