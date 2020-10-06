using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeightPattern
{
    public class UnSharedConcreteFlyweight: Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("UnSharedConcreteFlyweight " + extrinsicstate);
        }
    }
}
