using System;

namespace FacadePattern
{
    public class FacadeImpl
    {
        public void Run()
        {
            Facade facade = new Facade();

            facade.MethodA();
            facade.MethodB();
        }
    }
}
