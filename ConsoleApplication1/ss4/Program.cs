using System;

namespace ConsoleApplication1.ss4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                int x = 10;
                int y = 20;
                x++;
                float z = x / y;
                Console.WriteLine("z = " + z);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Sai r thang ngu");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
            }
        }
    }
}