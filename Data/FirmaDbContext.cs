using FirmaDB_Migration.Models;
using Microsoft.EntityFrameworkCore;

namespace FirmaDB_Migration.Data
{
  public class FirmaDbContext: DbContext
  {

    public FirmaDbContext(DbContextOptions<FirmaDbContext> options)
      : base(options)
    {

    }

    DbSet<Employee> Employees { get; set; }
    DbSet<Child> Children { get; set; }

    DbSet<Item> Items { get; set; }

    DbSet<ItemLoan> Loans { get; set; }

    DbSet<LeaveRequest> LeaveRequests { get; set; }
    
    DbSet<Title> Titles { get; set; }

    DbSet<Vacation> Vacations { get; set; }
  }
}
