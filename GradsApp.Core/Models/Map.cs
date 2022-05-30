using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradsApp.Core.Models
{
    public class Map : BaseEntity
    {
        // Buraya Harita ile ilgili veri tabanında ne tutulması gerekiyorsa onun yazılması gerekiyor.

        public string Coordinate { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

    }
}
