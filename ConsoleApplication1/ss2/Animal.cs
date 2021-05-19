using System;

namespace ConsoleApplication1.ss2
{
    public class Animal
    {
        public string Kind;
        public void Eat()
        {
            Console.WriteLine("An cut");
        }

        public virtual void Dosomething()
        {
            Console.WriteLine("Nhu cc");
        }
    }
}