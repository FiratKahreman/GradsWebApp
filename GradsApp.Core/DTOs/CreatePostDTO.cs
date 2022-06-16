using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradsApp.Core.DTOs
{
    public class CreatePostDTO
    {
        public string PostTitle { get; set; }
        public string PostText { get; set; }
        public int PostProfileId { get; set; }
        public int Likes { get; set; } = 0;
    }
}
