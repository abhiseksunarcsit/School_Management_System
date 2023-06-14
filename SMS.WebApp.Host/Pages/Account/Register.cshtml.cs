using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SMS.WebApp.Data.Models.ViewModels;
using SMS.WebApp.Services.Interfaces;

namespace SMS.WebApp.Host.Pages.Account
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public RegisterViewModel Account { get; set; }

        private readonly IAccountServices _services;
        public RegisterModel(IAccountServices services)
        {
            _services = services;
        }
        public void OnGet()
        {
            

        }

        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
               
                var result = await _services.RegisterAsync(this.Account);
                if (result.Success)
                {
                   
                    return RedirectToPage("/Account/SignIn");
                }
                else
                    return Page();

            }
            
            return Page();

        }
    }
}
