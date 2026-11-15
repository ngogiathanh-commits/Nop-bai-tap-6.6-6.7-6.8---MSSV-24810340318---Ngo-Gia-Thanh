using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ClinicSystem.DTO;

namespace ClinicSystem.DAL
{
    public class DonThuocDAL
    {
       
        public bool LuuVaXuatDonThuocWithTransaction(int maHoSo, string chanDoan, DonThuocDTO donThuoc, List<ChiTietDonThuocDTO> listChiTiet, out int maDonMoi, out string errorMessage)
        {
            maDonMoi = -1;
            errorMessage = "";

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                   
                    string sqlUpdateHS = "UPDATE HoSoKham SET ChanDoan = @ChanDoan WHERE MaHoSo = @MaHoSo";
                    SqlCommand cmdHS = new SqlCommand(sqlUpdateHS, conn, tran);
                    cmdHS.Parameters.AddWithValue("@ChanDoan", chanDoan);
                    cmdHS.Parameters.AddWithValue("@MaHoSo", maHoSo);
                    cmdHS.ExecuteNonQuery();

                    
                    string sqlDon = @"INSERT INTO DonThuoc (MaHoSo, TienKham, TongTien, TrangThai) 
                                      VALUES (@MaHoSo, @TienKham, @TongTien, N'Chờ lấy thuốc');
                                      SELECT SCOPE_IDENTITY();";
                    SqlCommand cmdDon = new SqlCommand(sqlDon, conn, tran);
                    cmdDon.Parameters.AddWithValue("@MaHoSo", maHoSo);
                    cmdDon.Parameters.AddWithValue("@TienKham", donThuoc.TienKham);
                    cmdDon.Parameters.AddWithValue("@TongTien", donThuoc.TongTien);

                    maDonMoi = Convert.ToInt32(cmdDon.ExecuteScalar());

                    
                    foreach (var item in listChiTiet)
                    {
                        string sqlCheckTon = "SELECT SoLuongTon FROM Thuoc WHERE MaThuoc = @MaThuoc";
                        SqlCommand cmdCheck = new SqlCommand(sqlCheckTon, conn, tran);
                        cmdCheck.Parameters.AddWithValue("@MaThuoc", item.MaThuoc);

                        object tonObj = cmdCheck.ExecuteScalar();
                        int tonHienTai = tonObj != null ? Convert.ToInt32(tonObj) : 0;

                        if (tonHienTai < item.SoLuong)
                        {
                            
                            tran.Rollback();
                            errorMessage = $"Thuốc '{item.TenThuoc}' không đủ số lượng tồn trong kho! (Tồn: {tonHienTai}, Kê đơn: {item.SoLuong})";
                            return false;
                        }

                        
                        string sqlCT = @"INSERT INTO ChiTietDonThuoc (MaDon, MaThuoc, SoLuong, LieuDung) 
                                         VALUES (@MaDon, @MaThuoc, @SoLuong, @LieuDung)";
                        SqlCommand cmdCT = new SqlCommand(sqlCT, conn, tran);
                        cmdCT.Parameters.AddWithValue("@MaDon", maDonMoi);
                        cmdCT.Parameters.AddWithValue("@MaThuoc", item.MaThuoc);
                        cmdCT.Parameters.AddWithValue("@SoLuong", item.SoLuong);
                        cmdCT.Parameters.AddWithValue("@LieuDung", (object)item.LieuDung ?? DBNull.Value);
                        cmdCT.ExecuteNonQuery();

                       
                        string sqlTruTon = "UPDATE Thuoc SET SoLuongTon = SoLuongTon - @SoLuong WHERE MaThuoc = @MaThuoc";
                        SqlCommand cmdTru = new SqlCommand(sqlTruTon, conn, tran);
                        cmdTru.Parameters.AddWithValue("@SoLuong", item.SoLuong);
                        cmdTru.Parameters.AddWithValue("@MaThuoc", item.MaThuoc);
                        cmdTru.ExecuteNonQuery();
                    }

                    
                    tran.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    errorMessage = "Lỗi hệ thống SqlTransaction: " + ex.Message;
                    return false;
                }
            }
        }

        
        public DataTable GetAllDonThuoc()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"SELECT dt.MaDon, dt.MaHoSo, bn.HoTen AS BenhNhan, bn.SoDienThoai, 
                                        hs.ChanDoan, dt.TienKham, dt.TongTien, dt.TrangThai
                                 FROM DonThuoc dt
                                 JOIN HoSoKham hs ON dt.MaHoSo = hs.MaHoSo
                                 JOIN BenhNhan bn ON hs.MaBN = bn.MaBN
                                 ORDER BY dt.MaDon DESC";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        
        public DataTable GetChiTietDonThuoc(int maDon)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"SELECT ct.MaThuoc, t.TenThuoc, t.DonViTinh, ct.SoLuong, t.DonGia, 
                                        (ct.SoLuong * t.DonGia) AS ThanhTien, ct.LieuDung
                                 FROM ChiTietDonThuoc ct
                                 JOIN Thuoc t ON ct.MaThuoc = t.MaThuoc
                                 WHERE ct.MaDon = @MaDon";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaDon", maDon);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        
        public bool ThanhToanDonThuoc(int maDon)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "UPDATE DonThuoc SET TrangThai = N'Đã thanh toán' WHERE MaDon = @MaDon";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaDon", maDon);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
