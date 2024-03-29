using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SMS.WebApp.Core.IRepositories;
using SMS.WebApp.Core.Repositories;
using SMS.WebApp.Data;
using SMS.WebApp.Services.Interfaces;
using SMS.WebApp.Services.Services;

namespace SMS.WebApp.Host
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<SMSDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<SMSDbContext>().AddDefaultTokenProviders();
            builder.Services.AddTransient<IAccountRepositories,AccountRepositories>();
            builder.Services.AddTransient<IAccountServices,AccountServices>();
            builder.Services.AddTransient<IStudentsRepositories,StudentsRepositories>();
            builder.Services.AddTransient<IStudentsServices,StudentsServices>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }

    }
}