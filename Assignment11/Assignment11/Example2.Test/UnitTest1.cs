namespace Example2.Test
{
    [TestFixture]
    public class Tests
    {
        private QuanLySinhVien quanLySinhVien;

        [SetUp]
        public void Setup()
        {
            quanLySinhVien = new QuanLySinhVien();
        }

        [Test]
        public void ThemSinhVien_HopLe_ThemThanhCong()
        {
            SinhVien sinhVien = new SinhVien { MaSo = "SV001", HoTen = "Nguyen Van A", DiemTrungBinh = 8.5 };
            quanLySinhVien.ThemSinhVien(sinhVien);
            List<SinhVien> danhSach = quanLySinhVien.LayDanhSachSinhVien();
            Assert.IsTrue(danhSach.Contains(sinhVien));
        }


        [Test]
        public void XoaSinhVien_KhongTonTaiSinhVien_KhongThayDoiDanhSach()
        {
            quanLySinhVien.XoaSinhVien("SV002");
            List<SinhVien> danhSach = quanLySinhVien.LayDanhSachSinhVien();
            Assert.AreEqual(0, danhSach.Count);
        }
    }
}