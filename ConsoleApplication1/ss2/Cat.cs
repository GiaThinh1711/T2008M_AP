using System;

namespace ConsoleApplication1.ss2
{
    public class Cat : Animal
    {
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