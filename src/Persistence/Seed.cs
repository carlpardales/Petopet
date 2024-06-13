using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Customers.Any()) return;

            var customers = new List<Customer>
            {
                new()                {
                    Id = Guid.NewGuid(),
                    Name = "John Doe",
                    Sex = "Male",
                    DateOfBirth = DateTime.SpecifyKind( new DateTime(1985, 5, 23), DateTimeKind.Utc),
                    Address = "123 Main St, Anytown, USA",
                    Email = "john.doe@example.com",
                    Phone = "555-1234",
                    Mobile = "555-5678"
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Jane Smith",
                    Sex = "Female",
                    DateOfBirth = DateTime.SpecifyKind(new DateTime(1990, 8, 12), DateTimeKind.Utc),
                    Address = "456 Oak St, Sometown, USA",
                    Email = "jane.smith@example.com",
                    Phone = "555-8765",
                    Mobile = "555-4321"
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Robert Johnson",
                    Sex = "Male",
                    DateOfBirth = DateTime.SpecifyKind(new DateTime(1978, 11, 30), DateTimeKind.Utc),
                    Address = "789 Pine St, Othertown, USA",
                    Email = "robert.johnson@example.com",
                    Phone = "555-1122",
                    Mobile = "555-3344"
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Emily Davis",
                    Sex = "Female",
                    DateOfBirth = DateTime.SpecifyKind(new DateTime(1983, 2, 14), DateTimeKind.Utc),
                    Address = "321 Elm St, Anycity, USA",
                    Email = "emily.davis@example.com",
                    Phone = "555-2233",
                    Mobile = "555-4455"
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Michael Brown",
                    Sex = "Male",
                    DateOfBirth = DateTime.SpecifyKind(new DateTime(1992, 7, 21), DateTimeKind.Utc),
                    Address = "654 Maple St, Smalltown, USA",
                    Email = "michael.brown@example.com",
                    Phone = "555-6677",
                    Mobile = "555-7788"
                }
            };

            await context.Customers.AddRangeAsync(customers);
            await context.SaveChangesAsync();
        }
    }
}