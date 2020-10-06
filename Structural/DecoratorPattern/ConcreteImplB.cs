using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class ConcreteImplB: Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("Add new Behaviour");
            Console.WriteLine("ConcreteImplB called");
        }
    }
}
