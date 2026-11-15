using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using LibraryManagement.DTO;

namespace LibraryManagement.DAL
{
    public class PhieuMuonDAL
    {
        
        public DataTable GetPhieuMuonFiltered(int? maDocGia, string trangThai)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"SELECT pm.MaPhieu, pm.MaDocGia, dg.HoTen AS DocGia, pm.NgayMuon, pm.HanTra, pm.TrangThai,
                                        ISNULL(STUFF((
                                            SELECT ', ' + ds.TenSach + ' (x' + CAST(ct.SoLuong AS VARCHAR) + ')'
                                            FROM ChiTietMuon ct
                                            JOIN DauSach ds ON ct.MaSach = ds.MaSach
                                            WHERE ct.MaPhieu = pm.MaPhieu
                                            FOR XML PATH('')
                                        ), 1, 2, ''), N'Không có sách') AS DanhSachMuon
                                 FROM PhieuMuon pm
                                 JOIN DocGia dg ON pm.MaDocGia = dg.MaDocGia
                                 WHERE 1 = 1";

                if (maDocGia.HasValue && maDocGia.Value > 0)
                {
                    query += " AND pm.MaDocGia = @MaDocGia";
                }
                if (!string.IsNullOrEmpty(trangThai) && trangThai != "Tất cả")
                {
                    query += " AND pm.TrangThai = @TrangThai";
                }

                query += " ORDER BY pm.NgayMuon DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                if (maDocGia.HasValue && maDocGia.Value > 0)
                {
                    cmd.Parameters.Add(new SqlParameter("@MaDocGia", maDocGia.Value));
                }
                if (!string.IsNullOrEmpty(trangThai) && trangThai != "Tất cả")
                {
                    cmd.Parameters.Add(new SqlParameter("@TrangThai", trangThai));
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        
        public bool LapPhieuMuonWithTransaction(PhieuMuonDTO phieu, List<ChiTietMuonDTO> listChiTiet, out string error)
        {
            error = "";
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    
                    string sqlPM = @"INSERT INTO PhieuMuon (MaDocGia, NgayMuon, HanTra, TrangThai) 
                                     VALUES (@MaDocGia, GETDATE(), @HanTra, N'Đang mượn');
                                     SELECT SCOPE_IDENTITY();";
                    SqlCommand cmdPM = new SqlCommand(sqlPM, conn, tran);
                    cmdPM.Parameters.AddWithValue("@MaDocGia", phieu.MaDocGia);
                    cmdPM.Parameters.AddWithValue("@HanTra", phieu.HanTra);

                    int maPhieu = Convert.ToInt32(cmdPM.ExecuteScalar());

                    
                    foreach (var item in listChiTiet)
                    {
                        string sqlCheck = "SELECT SoLuongCon FROM DauSach WHERE MaSach = @MaSach";
                        SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn, tran);
                        cmdCheck.Parameters.AddWithValue("@MaSach", item.MaSach);
                        int soLuongCon = Convert.ToInt32(cmdCheck.ExecuteScalar());

                        if (soLuongCon < item.SoLuong)
                        {
                            tran.Rollback();
                            error = $"Sách '{item.TenSach}' không đủ số lượng trong kho! (Còn: {soLuongCon}, Mượn: {item.SoLuong})";
                            return false;
                        }

                        string sqlCT = "INSERT INTO ChiTietMuon (MaPhieu, MaSach, SoLuong) VALUES (@MaPhieu, @MaSach, @SoLuong)";
                        SqlCommand cmdCT = new SqlCommand(sqlCT, conn, tran);
                        cmdCT.Parameters.AddWithValue("@MaPhieu", maPhieu);
                        cmdCT.Parameters.AddWithValue("@MaSach", item.MaSach);
                        cmdCT.Parameters.AddWithValue("@SoLuong", item.SoLuong);
                        cmdCT.ExecuteNonQuery();

                        string sqlTru = "UPDATE DauSach SET SoLuongCon = SoLuongCon - @SoLuong WHERE MaSach = @MaSach";
                        SqlCommand cmdTru = new SqlCommand(sqlTru, conn, tran);
                        cmdTru.Parameters.AddWithValue("@SoLuong", item.SoLuong);
                        cmdTru.Parameters.AddWithValue("@MaSach", item.MaSach);
                        cmdTru.ExecuteNonQuery();
                    }

                    tran.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    error = "Lỗi SqlTransaction khi lập phiếu mượn: " + ex.Message;
                    return false;
                }
            }
        }

        
        public bool TraSach(int maPhieu, out string error)
        {
            error = "";
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                   
                    string sqlCheckStatus = "SELECT TrangThai FROM PhieuMuon WHERE MaPhieu = @MaPhieu";
                    SqlCommand cmdStatus = new SqlCommand(sqlCheckStatus, conn, tran);
                    cmdStatus.Parameters.Add(new SqlParameter("@MaPhieu", maPhieu));
                    string currentStatus = cmdStatus.ExecuteScalar()?.ToString();

                    if (currentStatus == "Đã trả")
                    {
                        tran.Rollback();
                        error = "Phiếu mượn này đã được trả trước đó!";
                        return false;
                    }

                    
                    string sqlGetCT = "SELECT MaSach, SoLuong FROM ChiTietMuon WHERE MaPhieu = @MaPhieu";
                    SqlCommand cmdGetCT = new SqlCommand(sqlGetCT, conn, tran);
                    cmdGetCT.Parameters.Add(new SqlParameter("@MaPhieu", maPhieu));

                    SqlDataAdapter da = new SqlDataAdapter(cmdGetCT);
                    DataTable dtCT = new DataTable();
                    da.Fill(dtCT);

                    foreach (DataRow row in dtCT.Rows)
                    {
                        int maSach = Convert.ToInt32(row["MaSach"]);
                        int soLuong = Convert.ToInt32(row["SoLuong"]);

                        string sqlCongKho = "UPDATE DauSach SET SoLuongCon = SoLuongCon + @SoLuong WHERE MaSach = @MaSach";
                        SqlCommand cmdCong = new SqlCommand(sqlCongKho, conn, tran);
                        cmdCong.Parameters.Add(new SqlParameter("@SoLuong", soLuong));
                        cmdCong.Parameters.Add(new SqlParameter("@MaSach", maSach));
                        cmdCong.ExecuteNonQuery();
                    }

                    
                    string sqlUpdatePM = "UPDATE PhieuMuon SET TrangThai = @TrangThai WHERE MaPhieu = @MaPhieu";
                    SqlCommand cmdUpdatePM = new SqlCommand(sqlUpdatePM, conn, tran);
                    cmdUpdatePM.Parameters.Add(new SqlParameter("@TrangThai", "Đã trả"));
                    cmdUpdatePM.Parameters.Add(new SqlParameter("@MaPhieu", maPhieu));
                    cmdUpdatePM.ExecuteNonQuery();

                    tran.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    error = "Lỗi khi cập nhật trả sách: " + ex.Message;
                    return false;
                }
            }
        }

        
        public List<string> GetPhieuMuonQuaHan()
        {
            List<string> result = new List<string>();
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"SELECT pm.MaPhieu, dg.HoTen, dg.Email, pm.HanTra, pm.TrangThai
                                 FROM PhieuMuon pm
                                 JOIN DocGia dg ON pm.MaDocGia = dg.MaDocGia
                                 WHERE pm.HanTra < GETDATE() AND pm.TrangThai != N'Đã trả'
                                 ORDER BY pm.HanTra ASC";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int maPhieu = Convert.ToInt32(reader["MaPhieu"]);
                        string hoTen = reader["HoTen"].ToString();
                        string email = reader["Email"].ToString();
                        DateTime hanTra = Convert.ToDateTime(reader["HanTra"]);
                        string trangThai = reader["TrangThai"].ToString();

                        result.Add($"Phiếu #{maPhieu} | Độc giả: {hoTen} ({email}) | Hạn trả: {hanTra:dd/MM/yyyy} | Trạng thái: {trangThai}");
                    }
                }
            }
            return result;
        }

        
        public int GetTongLuotSachMuon()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT ISNULL(SUM(SoLuong), 0) FROM ChiTietMuon";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        
        public DataTable GetThongKeMuonTheoTheLoai()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"SELECT ds.TheLoai AS [Thể Loại Sách], 
                                        COUNT(DISTINCT ct.MaPhieu) AS [Số Phiếu Mượn],
                                        ISNULL(SUM(ct.SoLuong), 0) AS [Tổng Số Cuốn Mượn]
                                 FROM DauSach ds
                                 LEFT JOIN ChiTietMuon ct ON ds.MaSach = ct.MaSach
                                 GROUP BY ds.TheLoai
                                 ORDER BY [Tổng Số Cuốn Mượn] DESC";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
