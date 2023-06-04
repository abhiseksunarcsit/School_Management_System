using Microsoft.AspNetCore.Identity;
using SMS.WebApp.Data.Healper;
using SMS.WebApp.Data.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.WebApp.Core.IRepositories
{
    public interface IAccountRepositories
    {
       
        Task<DataResult> Login(LoginViewModel model);
        Task<DataResult> Register(RegisterViewModel model);
        

    }
}
