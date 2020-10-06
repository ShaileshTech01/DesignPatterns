using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class ConcreteImplementorB: Implementor
    {
        public override void OperationImpl()
        {
            Console.WriteLine("ConcreteImplementorB OperationImpl");
        }
    }
}
