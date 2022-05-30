using GradsApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradsApp.Service.IServices
{
    public interface ISocialCommentService
    {
        public Task<List<SocialComment>> GetAll();
        public Task CreatePost(SocialComment comment);
    }
}
