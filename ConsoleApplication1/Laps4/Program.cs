using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Laps4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<KhachHang> ds = new List<KhachHang>();
            KhachHangVN khvn = new KhachHangVN();
            khvn.Id1 = 1;
            khvn.Name1 = "Nguyen Gia Thinh";
            khvn.NgayXuatHoaDon1 = DateTime.Today;
            khvn.SoLuong1 = 1300;
            khvn.XuatHoaDon();
            ds.Add(khvn);
            KhachHangNuocNgoai khnn = new KhachHangNuocNgoai();
            khnn.SoLuong1 = 366;
            ds.Add(khnn);
        }
    }
}