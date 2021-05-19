using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication1.Laps1
{
    public class Product {
        public int Id;
        public String Name;
        public double Price;
        public double Qty;
        public String Desc;
        public String Image;
        public List<string>  Gallery = new List<string>();

        public Product() {
        }

        public Product(int id, string name, double price, double qty, string desc, string image, List<string> gallery) {
            Id = id;
            Name = name;
            Price = price;
            Qty = qty;
            Desc = desc;
            Image = image;
            Gallery = gallery;
        }

        public void GetInfo()
        {
            Console.WriteLine("Id: ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Price: ");
            Price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qty: ");
            Qty = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Desc: ");
            Desc = Console.ReadLine();
        }

        public bool CheckHang(double Qty)
        {
            return (Qty > 0)?true:false;
        }

        public bool AddImage( String Image)
        {
            if (Gallery.Count < 10)
                return false;
                Gallery.Add(Image);
                return true;
        }

        public void RemoveImage(String Image)
        {
            Console.WriteLine("Your list image:  ");
            foreach (var VARIABLE in Gallery)
            {
                Console.WriteLine(VARIABLE);
            }
            Console.WriteLine("Choose the image you want to remove: ");
            Console.ReadLine();
        }
    }
}