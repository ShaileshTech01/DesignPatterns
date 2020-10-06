using System;

namespace CompositePattern
{
    public class CompositeImpl
    {
        public void Run()
        {
            Console.WriteLine("Composite Pattern");

            Composite root = new Composite("root");
            //add leaf to root
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite component = new Composite("Compnent X");
            component.Add(new Leaf("Comp Leaf XA"));
            component.Add(new Leaf("Comp Leaf XB"));

            //add component to root
            root.Add(component);
            //add a new leaf 
            root.Add(new Leaf("Leaf C"));

            //Add and remove leaf
            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            root.Show(1);


        }
    }
}
