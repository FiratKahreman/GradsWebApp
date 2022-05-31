using GradsApp.Core.DTOs;
using GradsApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradsApp.Service.IServices
{
    public interface IFacultyService
    {
        public Task<List<FacultyWithProgramDTO>> GetAll();
    }
}
