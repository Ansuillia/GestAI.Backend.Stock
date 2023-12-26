using Gestai.Backend.Estoque.App.Handlers.ApiGateway;
using Microsoft.Extensions.DependencyInjection;

namespace Gestai.Backend.Estoque.App.Behaviors.ApiGateway;
public abstract class BaseBehavior : IDisposable
{
  protected readonly ApiGatewayInvokeRequest Request;
  protected readonly IServiceScope Scope;
  public BaseBehavior(IServiceProvider serviceProvider, ApiGatewayInvokeRequest request)
  {
    Request = request;
    Scope = serviceProvider.CreateScope();
  }

  public void Dispose()
  {
    Dispose(true);
    GC.SuppressFinalize(this);
  }

  public virtual void Dispose(bool disposing)
  {

  }
}