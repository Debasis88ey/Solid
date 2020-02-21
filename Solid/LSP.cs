using System;
using System.Collections.Generic;
using System.Text;

namespace Solid
{
    public abstract class Shape
    {
       public abstract void Print();
    }
    public class Rectangle : Shape
    {
        public override void Print()
        {
            Console.WriteLine("1. Rectangle");
        }
    }

    public class Squre : Shape
    {
        public override void Print()
        {
            Console.WriteLine("2. Squre");
        }
    }
}
