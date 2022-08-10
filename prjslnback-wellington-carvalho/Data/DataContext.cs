using prjslnback_wellington_carvalho.Models;
using Microsoft.EntityFrameworkCore;

namespace prjslnback_wellington_carvalho.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :
            base(options)
        {
        }
        public DbSet<User> User { get; set; }
    }
}
