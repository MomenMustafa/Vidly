using System.Data.Entity;
using Vidly.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {

    }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<MembershipType> MembershipTypes { get; set; }
}