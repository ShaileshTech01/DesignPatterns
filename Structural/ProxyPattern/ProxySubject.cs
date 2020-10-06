using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public class ProxySubject : Subject
    {
        private Subject realSubject;

        public override void Request()
        {
            if (realSubject == null)
                realSubject = new RealSubject();

            realSubject.Request();
        }
    }
}
