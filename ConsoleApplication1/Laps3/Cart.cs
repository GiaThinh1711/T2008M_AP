using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Laps3
{
    public class Cart
    {
        public int Id;
        public string Name;
        public double GrandTotal;
        public List<string> ProductList = new List<string>();
        public string City;
        public string Country;

        public Cart()
        {
        }

        public void SetID(int id)
        {
            this.Id = id;
        }
 
        public int GetID()
        {
            return this.Id;
        }
 
        public void SetName(string name)
        {
            this.Name = name;
        }
        public void SetGrandTotal(double grandtotal)
        {
            GrandTotal = grandtotal;
        }
        public void SetCity(string city)
        {
            this.City = city;
        }

        public void SetCountry(string country)
        {
            this.Country = country;
        }
        public Cart(int id, string name, double grandTotal, string city, string country)
        {
            Id = id;
            Name = name;
            GrandTotal = grandTotal;
            City = city;
            Country = country;
        }
    }
}