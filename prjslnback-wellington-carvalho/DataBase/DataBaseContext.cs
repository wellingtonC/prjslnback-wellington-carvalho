using prjslnback_wellington_carvalho.Models;
using Microsoft.EntityFrameworkCore;

namespace prjslnback_wellington_carvalho.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) :
            base(options)
        {
        }
        public DbSet<UserDTO> User { get; set; }
    }
}
