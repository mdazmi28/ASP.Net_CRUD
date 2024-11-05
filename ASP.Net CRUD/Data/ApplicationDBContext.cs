using ASP.Net_CRUD.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASP.Net_CRUD.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }

        //Employee - Which is set as a Entity
        public DbSet<Employee> Employees { get; set; }
    }
}
