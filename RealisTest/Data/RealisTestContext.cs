#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RealisTest.Models;

namespace RealisTest.Data
{
    public class RealisTestContext : DbContext
    {
        public RealisTestContext (DbContextOptions<RealisTestContext> options)
            : base(options)
        {
        }

        public DbSet<RealisTest.Models.TestInput> TestInput { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TestInput>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id);
                entity.Property(e => e.Name);
                entity.Property(e => e.inputDate);
                entity.Property(e => e.inputTime);

                entity.HasData(new TestInput { Id = 1, Name = "Testing", inputDate = DateTime.Parse("2022-02-18"), inputTime = DateTime.Parse("21:05") });
            });
        }
    }
}
