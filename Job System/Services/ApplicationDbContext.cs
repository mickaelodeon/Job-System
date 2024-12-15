using Job_System.Models;
using JobPortal.Models;
using Microsoft.EntityFrameworkCore;

namespace Job_System.Services
{
    public class ApplicationDbContext : DbContext
    {
        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        //{
        //}
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Job> Jobs { get; set; }//TABLE DIAY NI SIYA
        public DbSet<User> Users { get; set; }//a property so that we can access the table
    }
}
