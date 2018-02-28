using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EF21MigrationsIssue
{
    public class TestDbContext : DbContext
    {
        public DbSet<Bonus> Bonuses { get; set; }

        public TestDbContext(DbContextOptions<TestDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bonus>().SeedData(GetBonusSeedData_1());
        }

        private static Bonus[] GetBonusSeedData_1()
        {
            return new List<Bonus>
            {
                new Bonus
                {
                    Id = 1,
                    Name = "J",
                    Price = .2,
                },
                new Bonus
                {
                    Id = 2,
                    Name = "S",
                    Price = .5,
                },
                new Bonus
                {
                    Id = 3,
                    Name = "D",
                    MultipliesPoints = true,
                    MultiplyFactor = 2,
                    Price = .5,
                },
                new Bonus
                {
                    Id = 4,
                    Name = "I",
                    RequireSuccess = true,
                    ConquerorsPoints = true,
                    ConquerorAmount = 1,
                    Price = .5,
                },
                new Bonus
                {
                    Id = 5,
                    Name = "F",
                    RequireSuccess = true,
                    ConquerorsPoints = true,
                    ConquerorAmount = 1,
                    Price = .5,
                },
                new Bonus
                {
                    Id = 6,
                    Name = "G",
                    Price = .5,
                },
                new Bonus
                {
                    Id = 7,
                    Name = "J",
                    ConquerorsPoints = true,
                    ConquerorAmount = 2,
                    Price = null
                },
                new Bonus
                {
                    Id = 8,
                    Name = "Y",
                    Price = .5,
                },
            }.ToArray();
        }

        private static Bonus[] GetBonusSeedData_2()
        {
            return new List<Bonus>
            {
                new Bonus
                {
                    Id = 1,
                    Name = "J",
                    MultipliesPoints = false,
                    MultiplyFactor = null,
                    RequireSuccess = false,
                    ConquerorsPoints = false,
                    ConquerorAmount = null,
                    Price = .2,
                },
                new Bonus
                {
                    Id = 2,
                    Name = "S",
                    MultipliesPoints = false,
                    MultiplyFactor = null,
                    RequireSuccess = false,
                    ConquerorsPoints = false,
                    ConquerorAmount = null,
                    Price = .5,
                },
                new Bonus
                {
                    Id = 3,
                    Name = "D",
                    MultipliesPoints = true,
                    MultiplyFactor = 2,
                    RequireSuccess = false,
                    ConquerorsPoints = false,
                    ConquerorAmount = null,
                    Price = .5,
                },
                new Bonus
                {
                    Id = 4,
                    Name = "I",
                    MultipliesPoints = false,
                    MultiplyFactor = null,
                    RequireSuccess = true,
                    ConquerorsPoints = true,
                    ConquerorAmount = 1,
                    Price = .5,
                },
                new Bonus
                {
                    Id = 5,
                    Name = "F",
                    MultipliesPoints = false,
                    MultiplyFactor = null,
                    RequireSuccess = true,
                    ConquerorsPoints = true,
                    ConquerorAmount = 1,
                    Price = .5,
                },
                new Bonus
                {
                    Id = 6,
                    Name = "G",
                    MultipliesPoints = false,
                    MultiplyFactor = null,
                    RequireSuccess = false,
                    ConquerorsPoints = false,
                    ConquerorAmount = null,
                    Price = .5,
                },
                new Bonus
                {
                    Id = 7,
                    Name = "J",
                    MultipliesPoints = false,
                    MultiplyFactor = null,
                    RequireSuccess = false,
                    ConquerorsPoints = true,
                    ConquerorAmount = 2,
                    Price = null
                },
                new Bonus
                {
                    Id = 8,
                    Name = "Y",
                    MultipliesPoints = false,
                    MultiplyFactor = null,
                    RequireSuccess = false,
                    ConquerorsPoints = false,
                    ConquerorAmount = null,
                    Price = .5,
                },
            }.ToArray();
        }
    }
}