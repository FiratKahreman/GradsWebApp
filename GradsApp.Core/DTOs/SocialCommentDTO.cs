using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradsApp.Core.DTOs
{
    public class SocialCommentDTO
    {
        public string CommentText { get; set; }
        public int PostId { get; set; }
        public int CommentProfileId { get; set; }
    }
}
