namespace ConsoleApplication1.Laps4
{
    public class KhachHangNuocNgoai : KhachHang
    {
        public string QuocTich;

        public string QuocTich1
        {
            get => QuocTich;
            set => QuocTich = value;
        }

        public override int ThanhTien()
        {
            base.ThanhTien();
            return SoLuong1 * 50;
        }
    }
}