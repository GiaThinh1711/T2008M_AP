using System.Collections.Generic;

namespace ConsoleApplication1.ss3
{
    public class Product
    {
        private string ProductName;
        private decimal Price;
        public List<string> Gallery = new List<string>();
//index
        public string this[int index]
        {
            get
            {
                return Gallery[index];
            }
            set
            {
                Gallery[index] = value;
            }
        }
    //Properties
    public List<string> Gallery1
    {
        get => Gallery;
        set => Gallery = value;
    }

    public string ProductName1
        {
            get => ProductName;
            set => ProductName = value;
        }

        public decimal Price1
        {
            get
            {
                return Price + 10;
            }
            set
            {
                Price = value;
            }
        }
    }
}