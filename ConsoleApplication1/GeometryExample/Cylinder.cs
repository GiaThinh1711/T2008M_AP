using System;

namespace ConsoleApplication1.GeometryExample
{
    public class Cylinder
    {
        public double Radius;
        public double Height;
        public double BaseArea;
        public double LateralArea;
        public double TotalArea;
        public double Volume;

        public double Radius1
        {
            get => Radius;
            set => Radius = value;
        }

        public double Height1
        {
            get => Height;
            set => Height = value;
        }

        public double BaseArea1
        {
            get => BaseArea;
            set => BaseArea = value;
        }

        public double LateralArea1
        {
            get => LateralArea;
            set => LateralArea = value;
        }

        public double TotalArea1
        {
            get => TotalArea;
            set => TotalArea = value;
        }

        public double Volume1
        {
            get => Volume;
            set => Volume = value;
        }

        //public void Input()
        //{
           // Console.WriteLine("Radius: ");
           // Radius1 = Convert.ToDouble(Console.ReadLine());
          //  Console.WriteLine("Height: ");
           // Height1 = Convert.ToDouble(Console.ReadLine());
      //  }
        
        public void Process()
        {
            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;
        }

        public void Result()
        {
            Console.WriteLine("Base: " + BaseArea + "; " + "Lateral: " + LateralArea + "; " + "Total: " + TotalArea + "; " + "Volume: " + Volume);
        }

        public static void Main(string[] args)
        {
            Cylinder cl = new Cylinder();
            Console.WriteLine("Enter the demenstion of the cylinder");
            Console.WriteLine("Radius: ");
            cl.Radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Height: ");
            cl.Height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Cylinder Characteristics");
            cl.Process();
            cl.Result();
        }
    }
}