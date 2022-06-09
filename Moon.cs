using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica_osca1678
{
    internal sealed class Moon : Planet
    {
        public Planet? Orbiting { get; set; }
    }
}
