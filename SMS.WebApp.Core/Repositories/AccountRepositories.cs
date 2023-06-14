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
       
        public async Task<DataResult> LoginAsync(LoginViewModel model)
        {
            DataResult result = new DataResult();
            var user = await _userManager.FindByEmailAsync(model.Email);
            var response = await _signInManager.PasswordSignInAsync(user.UserName,model.Password,false,false) ;
            if(response.Succeeded)
            {
                result.Success = true;
                result.Message = "User Login success";
            }
            else
            {
                result.Success = false;
                result.Message = "User Login Failed";
            }
            return result; 
        }

        public async Task<DataResult> RegisterAsync(RegisterViewModel model)
        {
            DataResult result = new DataResult();
            var user = new IdentityUser
            {
                UserName = model.UserName,
                Email = model.Email,
               
            };

            var response = await _userManager.CreateAsync(user, model.Password);
            if (response.Succeeded)
            {
                
                result.Success = true;
                result.Message = "User Registration success";
                //is persistent means remenber me password
                await _signInManager.SignInAsync(user, isPersistent: false);
            }
            else
            {
                result.Success = false;
                result.Message = "User Registration Failed";
            }
            return result;
           
        }

        public async Task SignOutAsync()
        {
             await _signInManager.SignOutAsync();
            

           
        }
    }
}
