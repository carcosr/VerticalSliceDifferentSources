
using Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace webapi.Data.SQL;

public class SqlDbContext : DbContext
{
  public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options) { }

  public DbSet<Person> People { get; set; }
  public DbSet<Employee> Employees { get; set; }

}
