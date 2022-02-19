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
    }
}
