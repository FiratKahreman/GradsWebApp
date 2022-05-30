using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradsApp.Core.Models
{ 
    public class SocialPost : BaseEntity
    {
        public string PostText { get; set; }
        public int Likes { get; set; }
        public int PostProfileId { get; set; }

        public UserProfile PostProfile { get; set; }
        public ICollection<SocialComment> SocialComments { get; set; }
    }
}
