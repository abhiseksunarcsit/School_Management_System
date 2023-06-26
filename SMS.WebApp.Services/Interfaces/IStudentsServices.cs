using SMS.WebApp.Data.Healper;
using SMS.WebApp.Data.Models.Emums;
using SMS.WebApp.Data.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.WebApp.Services.Interfaces
{
    public interface IStudentsServices
    {
        Task<DataResult> CreateStudents(StudentViewModel studentArgs);
        Task<DataResult> UpdateStudents(StudentViewModel StudentArgs);
        Task<DataResult> DeleteStudents(Guid studentId);
        Task<DataResult<StudentViewModel>> GetAllStudents();
        Task<DataResult<GenderEnums>> GetGenderList();
        Task<DataResult<StudentViewModel>> GetStudentbyId(Guid studentId);
    }
}
