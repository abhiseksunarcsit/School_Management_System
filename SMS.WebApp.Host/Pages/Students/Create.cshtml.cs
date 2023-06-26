using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SMS.WebApp.Data.Models.Emums;
using SMS.WebApp.Data.Models.ViewModels;
using SMS.WebApp.Services.Interfaces;
using SMS.WebApp.Services.Services;

namespace SMS.WebApp.Host.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly IStudentsServices _studentsService;

        [BindProperty]
        public StudentViewModel StudentViewModel { get; set; }
        [BindProperty]
        public List<GenderEnums> GenderList { get; set; }
        public CreateModel(IStudentsServices studentsService)
        {
            _studentsService = studentsService;
        }
        public async Task<IActionResult> OnGet()
        {
            var result = await _studentsService.GetGenderList();
            if(result.Data != null)
            {
                GenderList = result.Data;

            }
            return Page();
        }
        public async Task<IActionResult> OnPost()
        {
            StudentViewModel.UserName = User.Identity.Name;
            if (ModelState.IsValid)
            {
                var response = await _studentsService.CreateStudents(StudentViewModel);
                if (response.Success)
                {
                    return RedirectToPage("/Students/Index");
                }
                else
                {
                    return Page();
                }
            }
            return Page();

        }
    }
}
