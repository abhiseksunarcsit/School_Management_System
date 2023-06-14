using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SMS.WebApp.Core.IRepositories;
using SMS.WebApp.Data;
using SMS.WebApp.Data.Healper;
using SMS.WebApp.Data.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.WebApp.Core.Repositories
{
    public class StudentsRepositories:IStudentsRepositories
    {
        private readonly SMSDbContext _context;
        public StudentsRepositories(SMSDbContext context) 
        {
            _context = context;

        }

        public async Task<DataResult> CreateStudents(Students studentArgs)
        {
            DataResult result = new DataResult();
            try
            {
                await _context.Students.AddAsync(studentArgs);
                await _context.SaveChangesAsync();
                result.Success = true;
                result.Message = "Student Created Successfully";

            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;

            }
           
            return result;


        }

        public async Task<DataResult> DeleteStudents(Guid studentId)
        {
            
            DataResult result = new DataResult();
            try 
            { 
                await _context.Students.Where(w=>w.Id==studentId).ExecuteDeleteAsync();
                await _context.SaveChangesAsync();
                result.Success = true;
                result.Message = "Student delete Successfully";
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return result;
        }

        public async Task<DataResult<Students>> GetAllStudents()
        {
            DataResult<Students> result = new DataResult<Students>();
            try
            {
                //var re = _context.Students.Select(s => s.DOB);
                //re.Where(w => w.Year > 2010);
                result.Data = await _context.Students.ToListAsync();
                result.Success= true;
                result.Message = "Get Students";

            }catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return result;
        }

        public async Task<DataResult> UpdateStudents(Students StudentArgs)
        {
            DataResult result = new DataResult();
            try
            {
               var student= await _context.Students.Where(w => w.Id == StudentArgs.Id).FirstAsync();
               if (student!=null)
                {
                    student.FirstName = StudentArgs.FirstName;
                    student.LastName = StudentArgs.LastName;
                    student.PhoneNumber = StudentArgs.PhoneNumber;
                }
               await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                result.Success = false;
            }
            return result;
        }
    }
}
