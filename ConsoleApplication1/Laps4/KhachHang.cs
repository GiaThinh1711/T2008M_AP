using System;

namespace ConsoleApplication1.Laps4
{
    public class KhachHang
    {
        public int Id;
        public string Name;
        public DateTime NgayXuatHoaDon;
        public int SoLuong;

        public KhachHang()
        {
        }

        public KhachHang(int id, string name, DateTime ngayXuatHoaDon, int soLuong)
        {
            Id = id;
            Name = name;
            NgayXuatHoaDon = ngayXuatHoaDon;
            SoLuong = soLuong;
        }

        public int Id1
        {
            get => Id;
            set => Id = value;
        }

        public string Name1
        {
            get => Name;
            set => Name = value;
        }

        public DateTime NgayXuatHoaDon1
        {
            get => NgayXuatHoaDon;
            set => NgayXuatHoaDon = value;
        }

        public int SoLuong1
        {
            get => SoLuong;
            set => SoLuong = value;
        }

        public virtual int ThanhTien()
        {
            return 0 ;
        }

        public void XuatHoaDon()
        {
            Console.WriteLine("Id: " + Id1);
            Console.WriteLine("Name: " + Name1);
            Console.WriteLine("Ngay xuat hoa don: " + NgayXuatHoaDon1);
            Console.WriteLine("So luong: " + SoLuong1);
        }
    }
}