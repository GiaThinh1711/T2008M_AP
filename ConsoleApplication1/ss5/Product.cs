namespace ConsoleApplication1.ss5
{
    public delegate void InStockProduct();
    public class Product
    {
        private int Price;
        private bool inStock;
        private int Qty;
        public event InStockProduct CheckStockProduct;

        public Product()
        {
            if(CheckStockProduct == null){}
            CheckStockProduct += UpdateStock;
        }

        public int Price1
        {
            get => Price;
            set => Price = value;
        }

        public bool InStock
        {
            get => inStock;
            set => inStock = value;
        }

        public int Qty1
        {
            get => Qty;
            set => Qty = value;
        }

        public void UpdateStock()
        {
            if (Qty > 0)
            {
                InStock = true;
            }
            else
            {
                InStock = false;
            }
        }

        public bool ChangePrice(int newPrice)
        {
            Price = newPrice;
            CheckStockProduct();
            return true;
        }
        public bool ChangeStock(int Qty)
        {
            Qty += this.Qty;
            CheckStockProduct();
            return true;
        }
    }
}