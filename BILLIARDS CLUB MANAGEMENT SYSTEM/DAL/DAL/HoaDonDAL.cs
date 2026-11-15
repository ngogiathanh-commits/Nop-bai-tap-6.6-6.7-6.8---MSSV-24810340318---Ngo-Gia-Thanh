using System;
using System.Data;
using System.Data.SqlClient;
using BilliardsClubManagement.DTO;

namespace BilliardsClubManagement.DAL
{
    public class HoaDonDAL
    {
        // Lấy hóa đơn chưa thanh toán của bàn đang chơi
        public HoaDonDTO GetHoaDonActiveByMaBan(int maBan)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT * FROM HoaDon WHERE MaBan = @MaBan AND TrangThai = 0";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaBan", maBan);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new HoaDonDTO
                        {
                            MaHD = Convert.ToInt32(reader["MaHD"]),
                            MaBan = Convert.ToInt32(reader["MaBan"]),
                            GioBatDau = Convert.ToDateTime(reader["GioBatDau"]),
                            TienGioChoi = Convert.ToDecimal(reader["TienGioChoi"]),
                            TienDichVu = Convert.ToDecimal(reader["TienDichVu"]),
                            TrangThai = Convert.ToBoolean(reader["TrangThai"])
                        };
                    }
                }
                return null;
            }
        }

        // Mở bàn: Tạo HoaDon mới (GioBatDau = GETDATE()) và đổi TrangThai bàn sang "Đang chơi"
        public bool MoBan(int maBan)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();
                try
                {
                    // 1. Tạo Hóa đơn mới
                    string insertHD = "INSERT INTO HoaDon (MaBan, GioBatDau, TrangThai) VALUES (@MaBan, GETDATE(), 0)";
                    SqlCommand cmdHD = new SqlCommand(insertHD, conn, tran);
                    cmdHD.Parameters.AddWithValue("@MaBan", maBan);
                    cmdHD.ExecuteNonQuery();

                    // 2. Chuyển trạng thái bàn sang "Đang chơi"
                    string updateBan = "UPDATE BanBida SET TrangThai = N'Đang chơi' WHERE MaBan = @MaBan";
                    SqlCommand cmdBan = new SqlCommand(updateBan, conn, tran);
                    cmdBan.Parameters.AddWithValue("@MaBan", maBan);
                    cmdBan.ExecuteNonQuery();

                    tran.Commit();
                    return true;
                }
                catch
                {
                    tran.Rollback();
                    return false;
                }
            }
        }

        // Mô hình ngắt kết nối (Disconnected Model): Nạp chi tiết dịch vụ bằng SqlDataAdapter + DataTable
        public DataTable GetChiTietHoaDonByMaHD(int maHD)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"SELECT c.MaDV, m.TenDV, c.SoLuong, c.DonGia, (c.SoLuong * c.DonGia) AS ThanhTien 
                                 FROM ChiTietHoaDon c 
                                 JOIN MenuDichVu m ON c.MaDV = m.MaDV 
                                 WHERE c.MaHD = @MaHD";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHD", maHD);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // Thêm món mới hoặc tăng số lượng món đã gọi
        public bool ThemHoacTangDichVu(int maHD, int maDV, int soLuongThem, decimal donGia)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"
                    IF EXISTS (SELECT 1 FROM ChiTietHoaDon WHERE MaHD = @MaHD AND MaDV = @MaDV)
                        UPDATE ChiTietHoaDon SET SoLuong = SoLuong + @SoLuong WHERE MaHD = @MaHD AND MaDV = @MaDV
                    ELSE
                        INSERT INTO ChiTietHoaDon (MaHD, MaDV, SoLuong, DonGia) VALUES (@MaHD, @MaDV, @SoLuong, @DonGia)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHD", maHD);
                cmd.Parameters.AddWithValue("@MaDV", maDV);
                cmd.Parameters.AddWithValue("@SoLuong", soLuongThem);
                cmd.Parameters.AddWithValue("@DonGia", donGia);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Cập nhật trực tiếp số lượng từ DataTable trên giao diện
        public bool CapNhatSoLuongDichVu(int maHD, int maDV, int soLuongMoi)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "UPDATE ChiTietHoaDon SET SoLuong = @SoLuong WHERE MaHD = @MaHD AND MaDV = @MaDV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SoLuong", soLuongMoi);
                cmd.Parameters.AddWithValue("@MaHD", maHD);
                cmd.Parameters.AddWithValue("@MaDV", maDV);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Thanh toán hóa đơn bằng SqlTransaction
        public bool ThanhToanWithTransaction(int maHD, int maBan, decimal tienGioChoi, decimal tienDichVu, out string error)
        {
            error = "";
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    // Lấy danh sách dịch vụ đã gọi trong hóa đơn
                    string sqlGetCT = "SELECT MaDV, SoLuong FROM ChiTietHoaDon WHERE MaHD = @MaHD";
                    SqlCommand cmdCT = new SqlCommand(sqlGetCT, conn, tran);
                    cmdCT.Parameters.AddWithValue("@MaHD", maHD);

                    SqlDataAdapter da = new SqlDataAdapter(cmdCT);
                    DataTable dtCT = new DataTable();
                    da.Fill(dtCT);

                    // 2. Trừ TonKho tương ứng trong bảng MenuDichVu (bỏ qua nếu là dịch vụ thuê gậy)
                    foreach (DataRow row in dtCT.Rows)
                    {
                        int maDV = Convert.ToInt32(row["MaDV"]);
                        int soLuong = Convert.ToInt32(row["SoLuong"]);

                        string sqlCheck = "SELECT TenDV, TonKho FROM MenuDichVu WHERE MaDV = @MaDV";
                        SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn, tran);
                        cmdCheck.Parameters.AddWithValue("@MaDV", maDV);

                        string tenDV = "";
                        int tonKho = 0;
                        using (SqlDataReader reader = cmdCheck.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                tenDV = reader["TenDV"].ToString();
                                tonKho = Convert.ToInt32(reader["TonKho"]);
                            }
                        }

                        // Bỏ qua trừ kho nếu là dịch vụ thuê gậy
                        bool isThueGay = tenDV.StartsWith("Thuê gậy", StringComparison.OrdinalIgnoreCase);
                        if (!isThueGay)
                        {
                            if (tonKho < soLuong)
                            {
                                tran.Rollback();
                                error = $"Mặt hàng '{tenDV}' không đủ tồn kho! (Tồn: {tonKho}, Gọi: {soLuong})";
                                return false;
                            }

                            string sqlTruKho = "UPDATE MenuDichVu SET TonKho = TonKho - @SoLuong WHERE MaDV = @MaDV";
                            SqlCommand cmdTru = new SqlCommand(sqlTruKho, conn, tran);
                            cmdTru.Parameters.AddWithValue("@SoLuong", soLuong);
                            cmdTru.Parameters.AddWithValue("@MaDV", maDV);
                            cmdTru.ExecuteNonQuery();
                        }
                    }

                    // 1. Cập nhật GioKetThuc, TienGioChoi, TienDichVu, TrangThai = 1 cho HoaDon
                    string sqlUpdateHD = @"UPDATE HoaDon 
                                           SET GioKetThuc = GETDATE(), TienGioChoi = @TienGioChoi, 
                                               TienDichVu = @TienDichVu, TrangThai = 1 
                                           WHERE MaHD = @MaHD";
                    SqlCommand cmdUpdateHD = new SqlCommand(sqlUpdateHD, conn, tran);
                    cmdUpdateHD.Parameters.AddWithValue("@TienGioChoi", tienGioChoi);
                    cmdUpdateHD.Parameters.AddWithValue("@TienDichVu", tienDichVu);
                    cmdUpdateHD.Parameters.AddWithValue("@MaHD", maHD);
                    cmdUpdateHD.ExecuteNonQuery();

                    // 3. Cập nhật trạng thái BanBida về "Trống"
                    string sqlUpdateBan = "UPDATE BanBida SET TrangThai = N'Trống' WHERE MaBan = @MaBan";
                    SqlCommand cmdUpdateBan = new SqlCommand(sqlUpdateBan, conn, tran);
                    cmdUpdateBan.Parameters.AddWithValue("@MaBan", maBan);
                    cmdUpdateBan.ExecuteNonQuery();

                    // 4. Commit Transaction
                    tran.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    error = "Lỗi SqlTransaction khi thanh toán: " + ex.Message;
                    return false;
                }
            }
        }
    }
}
