using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradsApp.Core.Models
{
    public class Picture : BaseEntity
    {
        public string Description { get; set; }
        public string Link { get; set; }
    }
}
