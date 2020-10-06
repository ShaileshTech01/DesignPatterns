using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FlyWeightPattern
{
    public class FlyweightFactory
    {
        private Hashtable flyweights = new Hashtable();

        public Flyweight GetFlyweight(string key)
        {
            return ((Flyweight)flyweights[key]);
        }
        public FlyweightFactory()
        {
            flyweights.Add("X", new ConcreteFlyweight());
            flyweights.Add("Y", new ConcreteFlyweight());
            flyweights.Add("Z", new ConcreteFlyweight());
        }
    }
}
