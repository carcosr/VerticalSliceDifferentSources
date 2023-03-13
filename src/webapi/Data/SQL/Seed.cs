namespace webapi.Data.SQL;

public class Seed
{
  public void SeedSqlData(SqlDbContext context)
  {
    context.People.Add(new Domain.Person
    {
      Id = 1,
      Name = "PacoPepe"
    });

    context.Employees.Add(new Domain.Employee
    {
      Id = 1,
      PersonId = 1
    });

    context.SaveChanges();
  }
}
