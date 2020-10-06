using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class Facade
    {
        private SubSystemOne one;
        private SubSystemTwo two;
        private SubSystemThree three;

        public Facade()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
        }

        public void MethodA()
        {
            Console.WriteLine("MethodA called");
            one.MethodOne();
            two.MethodTwo();
        }

        public void MethodB()
        {
            Console.WriteLine("MethodB called");
            three.MethodThree();
                one.MethodOne();
        }
    }
}
