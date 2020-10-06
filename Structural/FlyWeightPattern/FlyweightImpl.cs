using System;

namespace FlyWeightPattern
{
    public class FlyweightImpl
    {
        public void Run()
        {
            int extrinsicState = 22;

            FlyweightFactory factory = new FlyweightFactory();

            //work with different flyweight instance
            Flyweight fx = factory.GetFlyweight("X");
            fx.Operation(--extrinsicState);

            Flyweight fy = factory.GetFlyweight("Y");
            fy.Operation(--extrinsicState);

            Flyweight fz = factory.GetFlyweight("Z");
            fz.Operation(--extrinsicState);

            UnSharedConcreteFlyweight uf = new UnSharedConcreteFlyweight();
            uf.Operation(--extrinsicState);

        }
    }
}
