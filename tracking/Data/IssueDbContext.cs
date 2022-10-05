using Microsoft.EntityFrameworkCore;
using tracking.Models;

namespace tracking.Data
{
    public class IssueDbContext : DbContext
    {
        public IssueDbContext(DbContextOptions<IssueDbContext> Options):base(Options)
        {

        }
        public DbSet<Issue> Issues { get; set; }    
    }
}
