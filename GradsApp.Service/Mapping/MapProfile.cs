using AutoMapper;
using GradsApp.Core.DTOs;
using GradsApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradsApp.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<SocialPost, CreatePostDTO>().ReverseMap();
            CreateMap<SocialComment, SocialCommentDTO>().ReverseMap();
            CreateMap<UserProfile, UserProfileDTO>().ReverseMap();
            CreateMap<Card, CardDTO>().ReverseMap();
            CreateMap<UserProfile, SignUpDTO>().ReverseMap();
            CreateMap<(UserProfile, SocialPost), ProfileWithPostsDTO>().ReverseMap();
                

        }
    }
}
