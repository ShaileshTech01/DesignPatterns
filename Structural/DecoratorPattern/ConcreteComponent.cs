﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponenet Called");
        }
    }
}
