using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SMS.WebApp.Data.Models.DataModels;

namespace SMS.WebApp.Data
{
    public class SMSDbContext:IdentityDbContext
    {
        public SMSDbContext(DbContextOptions<SMSDbContext> options) : base(options)
        {

        }
        //create dbset manually in codefirst apporach then write a migration code
        public DbSet<Students> Students { get; set; }

    }
}