using Microsoft.EntityFrameworkCore;
using StackJudgeEf.Model;

namespace StackJudgeEf
{
    public class AppDbContext : DbContext
    {
        public DbSet<CompanyModel> Companies { get; set; }
        public DbSet<AddressModel> Address { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> dbContext) : base(dbContext)
        {
        }
    }
}