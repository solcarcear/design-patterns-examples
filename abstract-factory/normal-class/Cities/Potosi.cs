using System;
using abstract_factory.abstractClass;

namespace abstract_factory.normal_class.Cities
{
    public class Potosi : City
    {
        public override void ShowOriginalTowns(Native n)
        {
            Console.WriteLine($"    - {n.GetType().Name}");

        }
    }
}