using System;

namespace ConsoleApplication1.Practicle2
{
    public class Lion : Tiger_Lion
    {
        public Lion()
        {
        }

        public override void Show()
        {
            Console.WriteLine("Name: " + base.Name+", Weight: " + base.Weight);
        }

        public override void SetMe(string Name, int Weight)
        {
            base.Weight = Weight;
            base.Name = Name;
        }
    }
}