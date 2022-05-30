using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradsApp.Core.Models
{
    public class SocialComment : BaseEntity
    {
        public string CommentText { get; set; }
        public int PostId { get; set; }
        public int CommentProfileId { get; set; }


        public SocialPost SocialPost { get; set; }
        public UserProfile CommentProfile { get; set; }
    }
}
