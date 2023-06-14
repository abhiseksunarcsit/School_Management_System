using SMS.WebApp.Core.IRepositories;
using SMS.WebApp.Data.Healper;
using SMS.WebApp.Data.Models.DataModels;
using SMS.WebApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.WebApp.Services.Services
{
    public class StudentsServices:IStudentsServices
    {
        private readonly IStudentsRepositories _repo;
        public StudentsServices(IStudentsRepositories repo)
        {
            _repo = repo;

        }

        public async Task<DataResult> CreateStudents(Students studentArgs)
        {
            var result = await _repo.CreateStudents(studentArgs);
            return result;
        }

        public async Task<DataResult> DeleteStudents(Guid studentId)
        {
            var result = await _repo.DeleteStudents(studentId);
            return result;
        }

        public async Task<DataResult<Students>> GetAllStudents()
        {
            var result = await _repo.GetAllStudents();
            return result;
        }

        public  async Task<DataResult> UpdateStudents(Students StudentArgs)
        {
            var result = await _repo.UpdateStudents(StudentArgs);
            return result;
        }
    

       
    }
}
