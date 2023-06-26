using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SMS.WebApp.Data.Models.ViewModels;
using SMS.WebApp.Services.Interfaces;
using SMS.WebApp.Services.Services;

namespace SMS.WebApp.Host.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly IStudentsServices _studentsServices;
        [BindProperty]
        public List<StudentViewModel> Students { get; set; }
        public IndexModel (IStudentsServices studentsServices)
        {
            _studentsServices = studentsServices;
        }
        public async Task<IActionResult> OnGet(Guid id)
        {
            var result =await _studentsServices.GetAllStudents();
            if(result.Success)
            {
                Students = result.Data;
                return Page();
            }
            else
            {
                return NotFound();
            }
         
        }

        public async Task<IActionResult> OnPostDelete(Guid id)
        {
            var result = await _studentsServices.DeleteStudents(id);
            if (result.Success)
            {
                return Page();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
