using System;

namespace BridgePattern
{
    public class BridgeImpl
    {
        public void Run()
        {
            Console.WriteLine("Bridge Pattern .....");

            Abstraction abstraction = new RefinedAbstraction();

            abstraction.Implementor = new ConcreteImplementorA();
            abstraction.Operation();

            abstraction.Implementor = new ConcreteImplementorB();
            abstraction.Operation();

        }
    }
}
