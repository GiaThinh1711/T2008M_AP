using System;

namespace ConsoleApplication1.Laps1
{
    public class Programs
    {
       public static void Main(string[] args)
        {
            Product product = new Product();
            product.GetInfo();
            Console.WriteLine(product.Qty);
            Console.WriteLine((product.CheckHang(product.Qty))?"In stock":"Out of stock");
            product.AddImage(product.Image);
            product.RemoveImage("Image");
        }
    }
}