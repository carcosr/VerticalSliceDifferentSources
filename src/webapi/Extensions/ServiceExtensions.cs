using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using webapi.Data.SQL;

namespace webapi.Extensions;

public static class ServiceExtensions
{
  public static void ConfigureServices(this IServiceCollection services)
  {
    services.AddAutoMapper(typeof(Program).Assembly);
    services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(Program).Assembly));

    services.AddDbContext<SqlDbContext>(options =>
    {
      options.UseInMemoryDatabase("vs_DB")
        .ConfigureWarnings(builder => builder.Ignore(InMemoryEventId.TransactionIgnoredWarning));
    });

    services.AddScoped<ServiceManager.IServiceManager, ServiceManager.ServiceManager>();

  }
}
