using System.Data;
using System.Data.SqlClient;
using LibraryManagement.DTO;

namespace LibraryManagement.DAL
{
    public class DauSachDAL
    {
        public DataTable GetAllDauSach()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT MaSach, TenSach, TheLoai, SoLuongCon FROM DauSach";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public bool InsertDauSach(DauSachDTO sach)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"INSERT INTO DauSach (TenSach, TheLoai, SoLuongCon) 
                                 VALUES (@TenSach, @TheLoai, @SoLuongCon)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenSach", sach.TenSach);
                cmd.Parameters.AddWithValue("@TheLoai", sach.TheLoai);
                cmd.Parameters.AddWithValue("@SoLuongCon", sach.SoLuongCon);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateDauSach(DauSachDTO sach)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"UPDATE DauSach 
                                 SET TenSach = @TenSach, TheLoai = @TheLoai, SoLuongCon = @SoLuongCon 
                                 WHERE MaSach = @MaSach";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSach", sach.MaSach);
                cmd.Parameters.AddWithValue("@TenSach", sach.TenSach);
                cmd.Parameters.AddWithValue("@TheLoai", sach.TheLoai);
                cmd.Parameters.AddWithValue("@SoLuongCon", sach.SoLuongCon);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteDauSach(int maSach)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "DELETE FROM DauSach WHERE MaSach = @MaSach";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSach", maSach);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
