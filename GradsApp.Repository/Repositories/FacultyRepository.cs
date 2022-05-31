using GradsApp.Core.DTOs;
using GradsApp.Core.Models;
using GradsApp.Repository.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradsApp.Repository.Repositories
{
    public class FacultyRepository : GenericRepository<Faculty>, IFacultyRepository
    {
        private readonly AppDbContext _appDbContext;
        public FacultyRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<FacultyWithProgramDTO>> GetAllWithFaculty()
        {
            //var response = await _appDbContext.Faculties.Join(x => x.FacultyPrograms).ToListAsync();

            List<FacultyWithProgramDTO> facultyWithPrograms = (from a in _appDbContext.Faculties
                                                   join b in _appDbContext.FacultyPrograms on a.Id equals b.FacultyId
                                                   

                                                   select new FacultyWithProgramDTO
                                                   {
                                                       FacultyName = a.FacultyName,
                                                       ProgramName = b.ProgramName,
                                                       Location = a.Location
                                                   }).ToList();
            return facultyWithPrograms;

        }

    }
}
