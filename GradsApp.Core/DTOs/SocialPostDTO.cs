using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradsApp.Core.DTOs
{
    public class SocialPostDTO
    {
        public int SocialPostId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsGrad { get; set; }
        public string PostTitle { get; set; }
        public string PostText { get; set; }
        public int Likes { get; set; } = 0;
        public int PostProfileId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public ICollection<SocialCommentDTO> PostComments { get; set; }

    }
}
