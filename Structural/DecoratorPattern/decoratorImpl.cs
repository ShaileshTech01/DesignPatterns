using System;

namespace DecoratorPattern
{
    public class decoratorImpl
    {
        public void Run()
        {
            ConcreteComponent concreteComponent = new ConcreteComponent();
            ConcreteImplA concreteImplA = new ConcreteImplA();
            ConcreteImplB concreteImplB = new ConcreteImplB();

            concreteImplA.SetComponent(concreteComponent);
            concreteImplB.SetComponent(concreteImplA);

            concreteImplB.Operation();
        }

    }
}
