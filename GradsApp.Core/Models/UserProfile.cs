using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradsApp.Core.Models
{
    public class UserProfile : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public bool IsGrad { get; set; }        
        public string Phone { get; set; }
        public string Mail { get; set; }
        public int PictureId { get; set; }
        public DateTime? GraduationDate { get; set; }
        public bool IsWorking { get; set; }
        public bool GotCard { get; set; }
        public string GradType { get; set; }
        public int? CardId { get; set; }
        public string Token { get; set; }
        public ICollection<SocialPost> SocialPosts { get; set; }
        public ICollection<SocialComment> SocialComments { get; set; }        
        public FacultyProgram FacultyProgram { get; set; }
        public Card? ProfileCard { get; set; }

    }
}
