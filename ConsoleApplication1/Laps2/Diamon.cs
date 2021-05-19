using System;
using ConsoleApplication1.Laps1;

namespace ConsoleApplication1.Laps2
{
    public class Diamon : Product
    {
        public double Cara;

        public void CheckReal()
        {
            if (Cara > 10)
            {
                Console.WriteLine("It's real");
            }
            else
            {
                Console.WriteLine("It's fake");
            }
        }
    }
}