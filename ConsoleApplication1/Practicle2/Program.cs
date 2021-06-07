using System;

namespace ConsoleApplication1.Practicle2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Tiger tiger = new Tiger();
            tiger.SetMe("Tiger",100);
            tiger.Show();
            Lion lion = new Lion();
            lion.SetMe("Lion",200);
            lion.Show();
        }
    }
}