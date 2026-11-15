using System.Data;
using System.Data.SqlClient;
using ClinicSystem.DTO;

namespace ClinicSystem.DAL
{
    public class ThuocDAL
    {
        public DataTable GetAllThuoc()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT MaThuoc, TenThuoc, DonViTinh, DonGia, SoLuongTon FROM Thuoc";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public bool InsertThuoc(ThuocDTO thuoc)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"INSERT INTO Thuoc (TenThuoc, DonViTinh, DonGia, SoLuongTon) 
                                 VALUES (@TenThuoc, @DonViTinh, @DonGia, @SoLuongTon)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenThuoc", thuoc.TenThuoc);
                cmd.Parameters.AddWithValue("@DonViTinh", thuoc.DonViTinh);
                cmd.Parameters.AddWithValue("@DonGia", thuoc.DonGia);
                cmd.Parameters.AddWithValue("@SoLuongTon", thuoc.SoLuongTon);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateDonGiaThuoc(int maThuoc, string tenThuoc, string donViTinh, decimal donGiaMoi)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"UPDATE Thuoc 
                                 SET TenThuoc = @TenThuoc, DonViTinh = @DonViTinh, DonGia = @DonGia 
                                 WHERE MaThuoc = @MaThuoc";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaThuoc", maThuoc);
                cmd.Parameters.AddWithValue("@TenThuoc", tenThuoc);
                cmd.Parameters.AddWithValue("@DonViTinh", donViTinh);
                cmd.Parameters.AddWithValue("@DonGia", donGiaMoi);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool NhapThemTonKho(int maThuoc, int soLuongNhap)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "UPDATE Thuoc SET SoLuongTon = SoLuongTon + @SoLuongNhap WHERE MaThuoc = @MaThuoc";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaThuoc", maThuoc);
                cmd.Parameters.AddWithValue("@SoLuongNhap", soLuongNhap);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
