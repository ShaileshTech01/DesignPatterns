using System;

namespace AdapterPattern
{
    public class AdapterImplementation
    {
        public void Run()
        {
            Console.WriteLine("Adapter Pattern .....");
            Target target = new Adapter();
            target.Request();
            Console.ReadKey();
        }
    }
}
