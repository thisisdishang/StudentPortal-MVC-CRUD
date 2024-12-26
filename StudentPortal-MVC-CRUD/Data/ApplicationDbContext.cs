using Microsoft.EntityFrameworkCore;
using StudentPortal_MVC_CRUD.Models.Entities;

namespace StudentPortal_MVC_CRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Assignment> Assignment { get; set; }
    }
}
