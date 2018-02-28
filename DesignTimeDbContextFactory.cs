using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EF21MigrationsIssue
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<TestDbContext>
    {
        public TestDbContext CreateDbContext(string[] args)
        {
            var builder =
                new DbContextOptionsBuilder<TestDbContext>()
                .UseSqlServer("Server=.;Database=EF21_Migrations_Issue;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new TestDbContext(builder.Options);
        }
    }
}