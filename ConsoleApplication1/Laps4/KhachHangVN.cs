namespace ConsoleApplication1.Laps4
{
    public class KhachHangVN : KhachHang
    {
        public string DoiTuong;

        public string DoiTuong1
        {
            get => DoiTuong;
            set => DoiTuong = value;
        }

        public override int ThanhTien()
        {
            if (SoLuong1 < 50)
            {
                return SoLuong1 * 1000;
            }else if (SoLuong1 >= 50 && SoLuong1 < 100)
            {
                return (SoLuong1 - 50) * 1200 + 50 * 1000;
            }else if (SoLuong1 >= 100 && SoLuong1 < 200)
            {
                return (SoLuong1 - 100) * 1500 + 50 * 1200 + 50 * 1000;
            }
            else
            {
                return (SoLuong1 - 200) * 2000 + 100 * 1500 + 50 * 1200 + 50 * 1000;
            }
        }
    }
}