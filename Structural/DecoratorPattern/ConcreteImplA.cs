using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class ConcreteImplA: Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("Add new state");
            Console.WriteLine("ConcreteImplA called");
        }
    }
}
