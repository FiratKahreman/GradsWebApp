using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradsApp.Core.DTOs
{
    public class ProfileWithPostsDTO
    {        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsGrad { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public int PictureId { get; set; }
        public DateTime? GraduationDate { get; set; }
        public bool IsWorking { get; set; }
        public bool GotCard { get; set; }
        public string GradType { get; set; }
        public string PostTitle { get; set; }
        public string PostText { get; set; }
        public int Likes { get; set; }
        public int PostProfileId { get; set; }

    }
}
