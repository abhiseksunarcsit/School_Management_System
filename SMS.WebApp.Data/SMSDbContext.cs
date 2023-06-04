using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SMS.WebApp.Data
{
    public class SMSDbContext:IdentityDbContext
    {
        public SMSDbContext(DbContextOptions<SMSDbContext> options) : base(options)
        {

        }

    }
}