using SMS.WebApp.Data.Healper;
using SMS.WebApp.Data.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.WebApp.Services.Interfaces
{
    public interface IStudentsServices
    {
        Task<DataResult> CreateStudents(Students studentArgs);
        Task<DataResult> UpdateStudents(Students StudentArgs);
        Task<DataResult> DeleteStudents(Guid studentId);
        Task<DataResult<Students>> GetAllStudents();
    }
}
