using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradsApp.Core.Models
{
    public class Faculty : BaseEntity
    {
        public string FacultyName { get; set; }
        public string Location { get; set; }

        public ICollection<FacultyProgram> FacultyPrograms { get; set; }
        public ICollection<UserProfile> UserProfiles { get; set; }
    }
}
