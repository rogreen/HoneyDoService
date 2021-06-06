using Microsoft.EntityFrameworkCore;
using System;

namespace HoneyDoService.Models
{
    public class HoneyDoItemContext : DbContext
    {
        public HoneyDoItemContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<HoneyDoItem> HoneyDoItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HoneyDoItem>().HasData(new HoneyDoItem
            {
                Id = 1,
                Description = "Clean litter box",
                AssignedTo = "Me",
                Priority = "High",
                Recurrence = "Monthly",
                Category = "Home indoors",
                DueDate = DateTime.Today.AddDays(-2)

            }, new HoneyDoItem
            {
                Id = 2,
                Description = "Grocery Shoop",
                AssignedTo = "Us",
                Priority = "High",
                Recurrence = "Weekly",
                Category = "Errand",
                DueDate = DateTime.Today.AddDays(2)
            });
        }
    }
}
