using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace StackJudgeEf
{
    public class ContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var option = new DbContextOptionsBuilder<AppDbContext>();
            option.UseNpgsql("Host=localhost;Database=stuckjudge;Port=54320;Username=homestead;Password=secret;");

            return new AppDbContext(option.Options);
        }
    }
}