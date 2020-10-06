using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class Abstraction
    {
        public Implementor Implementor { set; get; }

        public virtual void Operation()
        {
            Implementor.OperationImpl();
        }
    }
}
