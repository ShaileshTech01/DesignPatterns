using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        { }

        public override void Add(Component component)
        {
            Console.WriteLine("Cannot add to a Leaf");    
        }

        public override void Remove(Component component)
        {
            Console.WriteLine("Cannot remove from a Leaf");
        }

        public override void Show(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
        }
    }
}
