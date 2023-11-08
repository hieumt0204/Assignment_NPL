using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    public class QuanLySinhVien
    {
        private List<SinhVien> danhSachSinhVien = new List<SinhVien>();
        public void ThemSinhVien(SinhVien sinhVien)
        {
            danhSachSinhVien.Add(sinhVien);
        }

        public void XoaSinhVien(string maSo)
        {
            danhSachSinhVien.RemoveAll(sv => sv.MaSo == maSo);
        }
        public void SuaSinhVien(string maSo, SinhVien sinhVienMoi)
        {
            int index = danhSachSinhVien.FindIndex(sv => sv.MaSo == maSo);
            if (index >= 0)
            {
                danhSachSinhVien[index] = sinhVienMoi;
            }
        }

        public SinhVien TimSinhVien(string maSo)
        {
            return danhSachSinhVien.FirstOrDefault(sv => sv.MaSo == maSo);
        }

        public List<SinhVien> SapXepSinhVienTheoDiem()
        {
            return danhSachSinhVien.OrderByDescending(sv => sv.DiemTrungBinh).ToList();
        }

        public List<SinhVien> LayDanhSachSinhVien()
        {
            return danhSachSinhVien;
        }
    }
}
