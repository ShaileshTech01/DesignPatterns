using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class Adapter: Target
    {
        Adaptee adaptee = new Adaptee();

        public override void Request()
        {
            adaptee.SpecificRequest();
        }
    }
}
