using Microsoft.EntityFrameworkCore;
using RealisTest.Data;

namespace RealisTest.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RealisTestContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RealisTestContext>>()))
            {
                if (context == null || context.TestInput == null)
                {
                    throw new ArgumentNullException("Null RealisTestContext");
                }

                if (context.TestInput.Any())
                {
                    return;
                }

                context.TestInput.AddRange(
                    new TestInput
                    {
                        Name = "Test 1",
                        inputDate = DateTime.Parse("2022-02-18"),
                        inputTime = DateTime.Parse("21:05"),
                    },

                    new TestInput
                    {
                        Name = "Second input",
                        inputDate = DateTime.Parse("2006-12-21"),
                        inputTime = DateTime.Parse("10:48"),
                    },

                    new TestInput
                    {
                        Name = "Last one",
                        inputDate = DateTime.Parse("1984-04-27"),
                        inputTime = DateTime.Parse("03:15"),
                    }
                );
                context.SaveChanges();
            }
        }
    }
}