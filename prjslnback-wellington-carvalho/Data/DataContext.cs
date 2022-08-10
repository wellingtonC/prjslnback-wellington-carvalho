using Microsoft.EntityFrameworkCore;
using prjslnback_wellington_carvalho.Models;

namespace prjslnback_wellington_carvalho.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
           : base(options)
        {
        }

        public DbSet<User> ListUser { get; set; }
    }
}
