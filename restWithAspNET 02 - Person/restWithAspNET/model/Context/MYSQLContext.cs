using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restWithAspNET.model.Context
{
    public class MYSQLContext : DbContext
    {
        public MYSQLContext()
        {

        }

        public MYSQLContext(DbContextOptions<MYSQLContext> options) : base(options) {}
        
        public DbSet<person> Persons { get; set; }
        
    }
}
