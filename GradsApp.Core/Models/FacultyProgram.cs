using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradsApp.Core.Models
{
    public class FacultyProgram : BaseEntity
    {
        public string ProgramName { get; set; }
        public int FacultyId { get; set; }

        public Faculty Faculty { get; set; }
        public ICollection<UserProfile> UserProfiles { get; set; }
    }
}
