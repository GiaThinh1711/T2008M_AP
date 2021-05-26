using System;
using System.Linq.Expressions;
using System.Threading;

namespace ConsoleApplication1.ss5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Thread t = new Thread(ShowMsg);
            t.Start();
            Thread t2 = new Thread(SayHello);
            t2.Start("T2008M"); 
            new Thread(delegate(Object obj)
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine("Anonymus");
                    try
                    {
                        Thread.Sleep(1000);
                    }
                    catch (Exception e)
                    {
                    }
                }
            }).Start();
        }

        public static void ShowMsg()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("DMM.com");
                try
                {
                    Thread.Sleep(1000);
                }
                catch (Exception e)
                {
                    
                }
            }
        }

        public static void SayHello(Object obj)
        {
            for (int i = 0; i < 20; i++)
            {
                string msg = (string) obj;
                Console.WriteLine(msg);
                try
                {
                    Thread.Sleep(1000);
                }
                catch (Exception e)
                {
                    
                }
            }
        }
    }
}