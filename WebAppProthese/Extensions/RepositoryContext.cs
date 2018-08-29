using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace WebAppProthese.Extensions
{
   
        public class RepositoryContext : DbContext
        {
            public RepositoryContext(DbContextOptions options)
                : base(options)
            {
            }

            public DbSet<Users> Users { get; set; }
            public DbSet<Dentiste> Dentiste { get; set; }
        }
    
}