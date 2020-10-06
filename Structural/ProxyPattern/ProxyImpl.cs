using System;

namespace ProxyPattern
{
    public class ProxyImpl
    {
        public void Run()
        {
            ProxySubject proxy = new ProxySubject();

            proxy.Request();
        }
    }
}
