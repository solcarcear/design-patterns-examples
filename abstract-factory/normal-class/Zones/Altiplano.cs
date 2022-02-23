using System.Collections.Generic;
using abstract_factory.abstractClass;
using abstract_factory.normal_class.Cities;
using abstract_factory.normal_class.Natives;

namespace abstract_factory.normal_class.Zones
{
    public class Altiplano : Zone
    {
        public override List<City> CreateCities()
        {
            var listCities = new List<City>();
            listCities.Add(new LaPaz());
            listCities.Add(new Potosi());
            return listCities;
        }
        public override List<Native> CreateNatives()
        {
            var listNatives = new List<Native>();
            listNatives.Add(new Aymara());
            listNatives.Add(new Quechua());
            return listNatives;
        }
    }
}