using System;
using System.ComponentModel.Design;
using ConsoleApplication1.Laps1;

namespace ConsoleApplication1.Laps3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Menu:
            Console.WriteLine("1.Add Product");
            Console.WriteLine("2.Remove Product");
            Console.WriteLine("3.Payment");
            Console.WriteLine("4.Exit");
            Console.WriteLine("Choose one: ");
            string number = Console.ReadLine();
            string Name;
            double Price;
            switch (number)
            {
                case "1":
                    Console.WriteLine("Enter product:");
                    Name = Console.ReadLine();
                    Price:
                    Console.WriteLine("Enter price: ");
                    try
                    {
                        Price = Double.Parse(Console.ReadLine());
                    }                    
                    catch(Exception e)
                    {
                        Console.WriteLine("Wrong typeof price");
                        Console.ReadLine();
                        goto Price;
                    }
                    Console.WriteLine("Added success!");
                    goto Menu; 
                case "2":
                    Console.WriteLine("Remove product: ");
                    Name = Console.ReadLine();
                    Console.WriteLine("Removed success!");
                    goto Menu;
                case "3":
                    Console.WriteLine("Payment: ");
                    goto Menu;
                case "4":
                    break;
                default:
                    Console.WriteLine("Get only values from 1 to 4");
                    Console.ReadLine();
                    goto Menu;
            }
        }
    }
}