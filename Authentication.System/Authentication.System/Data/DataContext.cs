using Authentication.System.Model;
using Microsoft.EntityFrameworkCore;

namespace Authentication.System.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
            : base(options)
        {
        }

        public DbSet<Users> User { get; set; }
    }
}
