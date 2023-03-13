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

    context.SaveChanges();
  }
}
