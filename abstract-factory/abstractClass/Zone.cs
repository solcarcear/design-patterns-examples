using System.Collections.Generic;

namespace abstract_factory.abstractClass
{
    public abstract class Zone
    {
        public abstract List<City> CreateCities();
        public abstract List<Native> CreateNatives();

    }
}