using GradsApp.Core.DTOs;

namespace Grads.Web.Models
{
    public class SocialModel
    {
        public List<SocialPostDTO>? SocialPostDTOs { get; set; }
        public SocialPostDTO? SocialPostDTO { get; set; }
        public CreateCommentDTO? PostCommentsDTO { get; set; }
        public CreatePostDTO? CreatePostDTO { get; set; }

    }
}
