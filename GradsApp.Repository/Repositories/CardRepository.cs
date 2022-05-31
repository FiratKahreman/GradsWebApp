using GradsApp.Core.Models;
using GradsApp.Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradsApp.Repository.Repositories
{
    public class CardRepository : GenericRepository<Card>, ICardRepository
    {
        private readonly AppDbContext _appDbContext;
        public CardRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }


    }
}
