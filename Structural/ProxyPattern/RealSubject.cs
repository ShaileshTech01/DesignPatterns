using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("RealSubject Request");
        }
    }
}
