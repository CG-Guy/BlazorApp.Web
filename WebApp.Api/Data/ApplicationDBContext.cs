using WebApp.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace WebApp.API.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed users
            modelBuilder.Entity<User>().HasData(GetSeedUsers());
        }

        private List<User> GetSeedUsers()
        {
            var users = new List<User>();

            //Names
            var firstNames = new string[] { "John", "Michael", "David", "James", "Peter", "Mark", "Paul", "Andrew", "Steven", "Robert" };
            var lastNames = new string[] { "Smith", "Johnson", "Williams", "Brown", "Jones", "Miller", "Davis", "Garcia", "Wilson", "Taylor" };
            var domains = new string[] { "gmail.com", "yahoo.com", "outlook.com" };
            var random = new Random();

            // Generate 10 users with random names
            for (int i = 0; i < 10; i++)
            {
                var firstName = firstNames[random.Next(firstNames.Length)];
                var lastName = lastNames[random.Next(lastNames.Length)];

                var user = new User
                {
                    UserId = i + 1,
                    FirstName = firstName,
                    LastName = lastName,
                    Email = $"{firstName.ToLower()}.{lastName.ToLower()}{random.Next(100)}@{domains[random.Next(domains.Length)]}", // Generate random email
                    CreatedAt = DateTime.Now
                };

                users.Add(user);
            }

            return users;
        }
    }
}
