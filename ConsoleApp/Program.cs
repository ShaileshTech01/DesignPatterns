using System;
using AdapterPattern;
using BridgePattern;
using CompositePattern;
using DecoratorPattern;
using FacadePattern;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //AdapterImplementation adapterImplementation = new AdapterImplementation();
            //adapterImplementation.Run();
            //BridgeImpl bridgeImpl = new BridgeImpl();
            //bridgeImpl.Run();
            //CompositeImpl compositeImpl = new CompositeImpl();
            //compositeImpl.Run();
            //decoratorImpl decoratorImpl = new decoratorImpl();
            //decoratorImpl.Run();
            FacadeImpl facadeImpl = new FacadeImpl();
            facadeImpl.Run();

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
