using System.Data;
using BilliardsClubManagement.DAL;

namespace BilliardsClubManagement.BUS
{
    public class MenuDichVuBUS
    {
        private MenuDichVuDAL dal = new MenuDichVuDAL();
        public DataTable GetAllMenuDichVu() => dal.GetAllMenuDichVu();
    }
}
