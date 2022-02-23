using System;
using abstract_factory.normal_class;
using abstract_factory.normal_class.Zones;

namespace abstract_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var bolivia= new Bolivia(new Altiplano());
            bolivia.AboutCities();
            bolivia.AboutNatives();
            Console.ReadLine();
        }
    }
}
