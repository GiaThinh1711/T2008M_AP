using ConsoleApplication1.Laps1;

namespace ConsoleApplication1.Laps2
{
    public class Fashion : Product
    {
        public string Color;
        public string Size;

        public void Check()
        {
            base.CheckHang(33.5);
        }
    }
}