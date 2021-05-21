using System;

namespace ConsoleApplication1.ss2
{
    public abstract class Animal
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

        public abstract void Running();
    }
}