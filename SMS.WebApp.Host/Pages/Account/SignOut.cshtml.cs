using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SMS.WebApp.Data.Models.ViewModels;
using SMS.WebApp.Services.Interfaces;

namespace SMS.WebApp.Host.Pages.Account
{
    public class SignOutModel : PageModel
    {
        [BindProperty]
        public LoginViewModel Account { get; set; }

        private readonly IAccountServices _services;
        public SignOutModel(IAccountServices services)
        {
            _services = services;
        }

        public async Task<IActionResult> OnGet()
        {
            await _services.SignOutAsync();
            return RedirectToPage("/Account/SignIn");

            //RedirectToPage("/Account/SignIn");
        }

      
    }
}
