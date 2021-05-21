using System;
using ConsoleApplication1.Laps1;

namespace ConsoleApplication1.Laps2
{
    public class Diamon : Product
    {
        public double Cara;

        public bool CheckReal()
        {
            if (Cara > 10)
                return true;
            return false;
        }
    }
}