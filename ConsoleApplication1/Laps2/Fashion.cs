using ConsoleApplication1.Laps1;

namespace ConsoleApplication1.Laps2
{
    public class Fashion : Product
    {
        public string Color;
        public string Size;

        public bool CheckColorAndSize(string c, string s)
        {
            if (Color.Equals(c) && Size.Equals(s) && Qty > 0)
                return true;
            return false;
        }
    }
}