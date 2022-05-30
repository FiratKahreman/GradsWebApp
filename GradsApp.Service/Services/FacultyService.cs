using GradsApp.Core.Models;
using GradsApp.Repository.IRepositories;
using GradsApp.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradsApp.Service.Services
{
    public class FacultyService : IFacultyService
    {
        public readonly IFacultyRepository _facultyRepository;

        public FacultyService(IFacultyRepository facultyRepository)
        {
            _facultyRepository = facultyRepository;
        }

        public async Task<List<Faculty>> GetAll()
        {
            return await _facultyRepository.GetAllAsync();
        }
    }
}
