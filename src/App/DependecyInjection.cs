using Microsoft.Extensions.DependencyInjection;

namespace Gestai.Backend.Stock.App;

public static class DependencyInjection
{
  public static ServiceProvider ResolveDependencies()
  {
    var services = new ServiceCollection();


    return services.BuildServiceProvider();
  }
}