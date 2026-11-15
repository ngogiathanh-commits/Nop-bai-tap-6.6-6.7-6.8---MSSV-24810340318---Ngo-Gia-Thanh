using System.Data;
using BilliardsClubManagement.DAL;

namespace BilliardsClubManagement.BUS
{
    public class BanBidaBUS
    {
        private BanBidaDAL dal = new BanBidaDAL();
        public DataTable GetAllBanBida() => dal.GetAllBanBida();
    }
}
