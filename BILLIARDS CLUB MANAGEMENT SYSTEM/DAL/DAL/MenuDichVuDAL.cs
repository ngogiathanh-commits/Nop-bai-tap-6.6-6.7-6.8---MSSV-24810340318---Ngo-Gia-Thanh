using System.Data;
using System.Data.SqlClient;

namespace BilliardsClubManagement.DAL
{
    public class MenuDichVuDAL
    {
        public DataTable GetAllMenuDichVu()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT MaDV, TenDV, DonGia, TonKho FROM MenuDichVu";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
