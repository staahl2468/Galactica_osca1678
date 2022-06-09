using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica_osca1678
{
    public enum Startype { YellowDwarf, White, BlueNeutron, RedGiant }
    internal class Star : SpaceObjects
    {
        public Type Type { get; set; }
        public int Temperature { get; set; }
        public List <Planet> PlanetList { get; set; }
    }
}
