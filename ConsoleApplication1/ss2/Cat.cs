using System;

namespace ConsoleApplication1.ss2
{
    public class Cat : Animal,ICat,IAnimal
    {
        public override void Running()
        {
            Console.WriteLine("Meo Meo");
        }

        public void Speak()
        {
            Console.WriteLine("Nhu cc");
        }

        public void Live()
        {
            Console.WriteLine("DBRR");
        }

        public string Name;
        public void Meo()
        {
            //this = super + extend
            base.Dosomething();
            base.Eat();
        }

        public void Meo(string msg)
        {
            base.Dosomething();
            base.Eat();
            Console.WriteLine(msg);
        }

        public override void Dosomething()
        {
            Console.WriteLine("Meo Meo do some thing");
        }

        public new void Eat()
        {
            Console.WriteLine("Nhu CDB");
        }
    }
}