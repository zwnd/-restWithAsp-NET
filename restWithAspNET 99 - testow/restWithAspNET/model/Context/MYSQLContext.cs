using Microsoft.EntityFrameworkCore;

namespace restWithAspNET.model.Context
{
    public class MYSQLContext : DbContext
    {
        public MYSQLContext()
        {

        }

        public MYSQLContext(DbContextOptions<MYSQLContext> options) : base(options) {}
        
        public DbSet<persona> Persons { get; set; }
        
    }
}
