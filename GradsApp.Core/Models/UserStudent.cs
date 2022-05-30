using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradsApp.Core.Models
{
    public class UserStudent : BaseEntity
    {
        public int UserProfileId { get; set; }
        public int FacultyId { get; set; }
        public UserProfile UserProfile { get; set; }
        public Faculty Faculty { get; set; }
    }
}
