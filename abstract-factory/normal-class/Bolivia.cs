using System;
using System.Collections.Generic;
using System.Linq;
using abstract_factory.abstractClass;

namespace abstract_factory.normal_class
{
    public class Bolivia
    {
        private List<Native> _Natives;
        private List<City> _Cities;

        public Bolivia(Zone zone)
        {
            _Natives = zone.CreateNatives();
            _Cities = zone.CreateCities();
        }

        public void AboutCities()
        {
            Console.WriteLine("The cities that make up this zone are:");
            var nameCities = _Cities.Select(x => x.GetType().Name).ToList();
            Console.WriteLine($"    * {string.Join(", ", nameCities)}");
            _Cities.ForEach(c =>
            {
                Console.WriteLine($"The city of {c.GetType().Name} coexits with the natives:");
                _Natives.ForEach(n =>
                {
                    c.ShowOriginalTowns(n);
                });
            });


        }
        public void AboutNatives()
        {
            var nameNativies = _Natives.Select(x => x.GetType().Name).ToList();
            Console.WriteLine("The natives that make up the area of the valleys are:");
            Console.WriteLine($"        {string.Join(", ", nameNativies)}");

            _Natives.ForEach(n =>
               {
                   Console.WriteLine($"- {n.GetType().Name} their tipical activities are: ");
                   n.ShowTipicalActivities();
               });
        }
    }
}