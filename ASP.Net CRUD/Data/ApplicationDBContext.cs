using ASP.Net_CRUD.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASP.Net_CRUD.Data
{
    public class ApplicationDBContext : DbContext
    {
        //public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options):base(options) 
        //{

        //}
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }

        //CRUD - Which is set as a Entity
        public DbSet<CRUD> crudDbContext { get; set; } 
    }
}
