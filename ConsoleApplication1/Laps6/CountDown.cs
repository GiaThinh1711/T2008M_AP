using System;
using System.Threading;

namespace ConsoleApplication1.Laps6
{
    public class CountDown
    {
        public static void Main(string[] args)
        {
            Thread t = new Thread(Clock);
            t.Start();
        }

        public static void Clock()
        {
           //string x = "10:59";
           int x = 10;
           int y = 0;
           do
           {
               Console.WriteLine(x + ":" + y);
               try
               {
                   Thread.Sleep(100);
               }
               catch (Exception e)
               {
               }
               y--;
               while (y<0)
               {
                   y = 59;
                   x--;  
               }
           } while (x>=0);
           Console.WriteLine("Time up");
        }
    }
}