using System.Data;
using System.Data.SqlClient;

namespace BilliardsClubManagement.DAL
{
    public class BanBidaDAL
    {
        public DataTable GetAllBanBida()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT MaBan, TenBan, LoaiBan, GiaTheoGio, TrangThai FROM BanBida";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
