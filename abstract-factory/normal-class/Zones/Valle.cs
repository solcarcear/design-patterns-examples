using System.Collections.Generic;
using abstract_factory.abstractClass;
using abstract_factory.normal_class.Cities;
using abstract_factory.normal_class.Natives;
namespace abstract_factory.normal_class.Zones
{
    public class Valle : Zone
    {
        public override List<City> CreateCities()
        {
            var listCities = new List<City>();
            listCities.Add(new Cochabamba());
            listCities.Add(new Chuquisaca());
            return listCities;
        }
        public override List<Native> CreateNatives()
        {
            var listNatives = new List<Native>();
            listNatives.Add(new Mataco());
            listNatives.Add(new Yuki());
            return listNatives;
        }
    }
}