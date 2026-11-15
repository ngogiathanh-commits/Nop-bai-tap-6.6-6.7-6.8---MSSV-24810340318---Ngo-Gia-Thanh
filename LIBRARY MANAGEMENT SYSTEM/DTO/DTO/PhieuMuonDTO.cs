using System;

namespace LibraryManagement.DTO
{
    public class PhieuMuonDTO
    {
        public int MaPhieu { get; set; }
        public int MaDocGia { get; set; }
        public string HoTenDocGia { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime HanTra { get; set; }
        public string TrangThai { get; set; }
    }
}
