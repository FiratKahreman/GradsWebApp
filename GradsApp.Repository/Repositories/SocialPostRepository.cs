using GradsApp.Core.Models;
using GradsApp.Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradsApp.Repository.Repositories
{
    internal class SocialPostRepository : GenericRepository<SocialPost>, ISocialPostRepository
    {
        public SocialPostRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
