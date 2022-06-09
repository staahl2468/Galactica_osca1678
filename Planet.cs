using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica_osca1678
{
    public enum PlanetType { Terrestial, Giant, Dwarf, Gas_Giant }
    internal class Planet : SpaceObjects
    {
        public PlanetType Type { get; set; }
        public int Diameter { get; set; }
        public int RotationPeriod { get; set; }
        public int RevolutionPeriod { get; set; }
        public List<Moon> MoonList { get; set; }
    }
}
