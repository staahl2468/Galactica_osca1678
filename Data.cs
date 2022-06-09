using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica_osca1678
{
    internal class Data
    {
        public Star Sun = new Star();

        private List<Planet> planets;

        public Data()
        {
            planets = new List<Planet>();
            AddPlanets();
            Sun.PlanetList = planets;

            void AddPlanets()
            {
                Planet mercury = new Planet() { Name = "Mecury", Diameter = 4879, RevolutionPeriod = 88, RotationPeriod = 1407, Id = 0, Type = PlanetType.Terrestial };
                Planet venus = new Planet() { Name = "Venus", Diameter = 12104, RevolutionPeriod = 224, RotationPeriod = -5832, Id = 1, Type = PlanetType.Terrestial };
                Planet earth = new Planet() { Name = "Earth", Diameter = 12756, RevolutionPeriod = 365, RotationPeriod = 24, Id = 2, Type = PlanetType.Terrestial };
                Planet mars = new Planet() { Name = "Mars", Diameter = 6792, RevolutionPeriod = 687, RotationPeriod = 24, Id = 3, Type = PlanetType.Terrestial };
                Planet jupiter = new Planet() { Name = "Jupitor", Diameter = 142984, RevolutionPeriod = 4331, RotationPeriod = 10, Id = 4, Type = PlanetType.Gas_Giant };
                Planet saturn = new Planet() { Name = "Saturn", Diameter = 120536, RevolutionPeriod = 10747, RotationPeriod = 10, Id = 5, Type = PlanetType.Gas_Giant };
                Planet uranus = new Planet() { Name = "Uranus", Diameter = 51118, RevolutionPeriod = 30589, RotationPeriod = -17, Id = 6, Type = PlanetType.Gas_Giant };
                Planet neptune = new Planet() { Name = "Neptune", Diameter = 49528, RevolutionPeriod = 59800, RotationPeriod = 16, Id = 7, Type = PlanetType.Gas_Giant };
                Planet pluto = new Planet() { Name = "Pluto", Diameter = 2376, RevolutionPeriod = 90560, RotationPeriod = 153, Id = 8, Type = PlanetType.Dwarf };

                earth.MoonList = new() { new Moon { Name = "Luna", Orbiting = earth, } };
                mars.MoonList = new()
                {
                    new Moon { Name = "Phobos", Orbiting = mars, },
                    new Moon { Name = "Deimos", Orbiting = mars, }
                };

                planets.Add(mercury);
                planets.Add(venus);
                planets.Add(earth);
                planets.Add(mars);
                planets.Add(jupiter);
                planets.Add(saturn);
                planets.Add(uranus);
                planets.Add(neptune);
                planets.Add(pluto);
            }
        }

    }
}
