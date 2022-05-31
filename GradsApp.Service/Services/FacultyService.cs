using AutoMapper;
using GradsApp.Core.DTOs;
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
        private readonly IMapper _mapper;


        public FacultyService(IFacultyRepository facultyRepository, IMapper mapper)
        {
            _facultyRepository = facultyRepository;
            _mapper = mapper;
        }

        public async Task<List<FacultyWithProgramDTO>> GetAll()
        {
            return await _facultyRepository.GetAllWithFaculty();
            //var response = _mapper.Map<List<FacultyWithProgramDTO>>(list);


        }
    }
}
