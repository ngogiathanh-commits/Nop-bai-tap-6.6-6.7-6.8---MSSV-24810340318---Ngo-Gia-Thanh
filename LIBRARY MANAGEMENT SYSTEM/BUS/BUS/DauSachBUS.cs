using System.Data;
using LibraryManagement.DAL;
using LibraryManagement.DTO;

namespace LibraryManagement.BUS
{
    public class DauSachBUS
    {
        private DauSachDAL dal = new DauSachDAL();

        public DataTable GetAllDauSach() => dal.GetAllDauSach();

        public bool ThemDauSach(DauSachDTO sach, out string error)
        {
            error = "";
            if (string.IsNullOrWhiteSpace(sach.TenSach))
            {
                error = "Tên đầu sách không được để trống!";
                return false;
            }
            if (sach.SoLuongCon < 0)
            {
                error = "Số lượng sách còn phải lớn hơn hoặc bằng 0!";
                return false;
            }
            return dal.InsertDauSach(sach);
        }

        public bool SuaDauSach(DauSachDTO sach, out string error)
        {
            error = "";
            if (string.IsNullOrWhiteSpace(sach.TenSach))
            {
                error = "Tên đầu sách không được để trống!";
                return false;
            }
            if (sach.SoLuongCon < 0)
            {
                error = "Số lượng sách còn không được âm!";
                return false;
            }
            return dal.UpdateDauSach(sach);
        }

        public bool XoaDauSach(int maSach) => dal.DeleteDauSach(maSach);
    }
}
