using System;
using System.Data;
using System.Data.SqlClient;
using ClinicSystem.DTO;

namespace ClinicSystem.DAL
{
    public class BenhNhanDAL
    {
        
        public BenhNhanDTO GetBenhNhanBySDT(string soDienThoai)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT MaBN, HoTen, SoDienThoai, NamSinh FROM BenhNhan WHERE SoDienThoai = @SoDienThoai";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@SoDienThoai", soDienThoai));

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new BenhNhanDTO
                        {
                            MaBN = Convert.ToInt32(reader["MaBN"]),
                            HoTen = reader["HoTen"].ToString(),
                            SoDienThoai = reader["SoDienThoai"].ToString(),
                            NamSinh = Convert.ToInt32(reader["NamSinh"])
                        };
                    }
                }
                return null;
            }
        }

        
        public bool TiepNhanVaTaoHoSo(BenhNhanDTO bn, HoSoKhamDTO hoSo, bool isNewPatient, out int maHoSoMoi, out string error)
        {
            maHoSoMoi = -1;
            error = "";

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    int maBN = bn.MaBN;

                    if (isNewPatient)
                    {
                        string sqlBN = @"INSERT INTO BenhNhan (HoTen, SoDienThoai, NamSinh) 
                                         VALUES (@HoTen, @SoDienThoai, @NamSinh);
                                         SELECT SCOPE_IDENTITY();";
                        SqlCommand cmdBN = new SqlCommand(sqlBN, conn, tran);
                        cmdBN.Parameters.AddWithValue("@HoTen", bn.HoTen);
                        cmdBN.Parameters.AddWithValue("@SoDienThoai", bn.SoDienThoai);
                        cmdBN.Parameters.AddWithValue("@NamSinh", bn.NamSinh);

                        maBN = Convert.ToInt32(cmdBN.ExecuteScalar());
                    }

                    string sqlHS = @"INSERT INTO HoSoKham (MaBN, NgayKham, TrieuChung, ChanDoan) 
                                     VALUES (@MaBN, GETDATE(), @TrieuChung, N'');
                                     SELECT SCOPE_IDENTITY();";
                    SqlCommand cmdHS = new SqlCommand(sqlHS, conn, tran);
                    cmdHS.Parameters.AddWithValue("@MaBN", maBN);
                    cmdHS.Parameters.AddWithValue("@TrieuChung", (object)hoSo.TrieuChung ?? DBNull.Value);

                    maHoSoMoi = Convert.ToInt32(cmdHS.ExecuteScalar());

                    tran.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    error = "Lỗi tiếp nhận bệnh nhân: " + ex.Message;
                    return false;
                }
            }
        }

        
        public DataTable GetAllHoSoKham()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"SELECT hs.MaHoSo, 
                                        CONCAT(N'HS#', hs.MaHoSo, ' - ', bn.HoTen, ' (', bn.SoDienThoai, ')') AS HienThiHoSo,
                                        bn.MaBN, bn.HoTen, bn.SoDienThoai, bn.NamSinh, hs.NgayKham, hs.TrieuChung, hs.ChanDoan
                                 FROM HoSoKham hs
                                 JOIN BenhNhan bn ON hs.MaBN = bn.MaBN
                                 ORDER BY hs.MaHoSo DESC";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
