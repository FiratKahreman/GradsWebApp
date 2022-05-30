using GradsApp.Core.Models;
using GradsApp.Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradsApp.Repository.Repositories
{
    public class SocialCommentRepository : GenericRepository<SocialComment>, ISocialCommentRepository
    {
        public SocialCommentRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
