using System;

namespace ConsoleApplication1.ss3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Product p = new Product();
            p.ProductName1 = "Gucci";
            p.Price1 = 10000;
            p[0] = "1.png";
            p[1] = "2.png";
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(p[i]);
            }
        }
    }
}