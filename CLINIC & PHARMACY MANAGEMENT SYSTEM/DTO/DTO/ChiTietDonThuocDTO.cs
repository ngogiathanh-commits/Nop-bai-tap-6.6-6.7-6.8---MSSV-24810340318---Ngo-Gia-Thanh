namespace ClinicSystem.DTO
{
    public class ChiTietDonThuocDTO
    {
        public int MaDon { get; set; }
        public int MaThuoc { get; set; }
        public string TenThuoc { get; set; }
        public string DonViTinh { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuong { get; set; }
        public string LieuDung { get; set; }
        public decimal ThanhTien => SoLuong * DonGia;
    }
}
