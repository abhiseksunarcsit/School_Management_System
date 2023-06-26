using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SMS.WebApp.Data.Models.Emums;
using SMS.WebApp.Data.Models.ViewModels;
using SMS.WebApp.Services.Interfaces;
using SMS.WebApp.Services.Services;

namespace SMS.WebApp.Host.Pages.Students
{
    public class UpdateModel : PageModel
    {
        private readonly IStudentsServices _studentServices;
        [BindProperty]
        public StudentViewModel StudentViewModel { get; set; }
        [BindProperty]
        public List<GenderEnums> GenderList { get; set; }
        public UpdateModel(IStudentsServices studentServices)
        {
            _studentServices = studentServices;
        }
        public async void OnGet(Guid id)
        {
            //get student by id
            var response = await _studentServices.GetStudentbyId(id);
            var resp = await _studentServices.GetGenderList();
            if(response.Data != null)
            {
                StudentViewModel = response.Data.FirstOrDefault();

            }
            if(resp.Data != null)
            {
                GenderList = resp.Data;    
            }
            
        }
        public async Task<IActionResult> OnPost()
        {
            var response = await _studentServices.UpdateStudents(StudentViewModel);
            if(response.Success)
            {
                return RedirectToPage("/Students/Index");

            }
            return Page();
        }
    }
}
