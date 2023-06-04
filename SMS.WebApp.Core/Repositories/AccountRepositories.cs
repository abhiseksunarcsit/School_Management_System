using Microsoft.AspNetCore.Identity;
using SMS.WebApp.Core.IRepositories;
using SMS.WebApp.Data.Healper;
using SMS.WebApp.Data.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.WebApp.Core.Repositories
{
    public class AccountRepositories : IAccountRepositories
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        public AccountRepositories(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;


        }
       
        public Task<DataResult> Login(LoginViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<DataResult> Register(RegisterViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
