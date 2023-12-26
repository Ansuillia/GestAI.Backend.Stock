using System.Net;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Gestai.Backend.Estoque.App.Handlers.ApiGateway;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace Gestai.Backend.Estoque.App;

public class Function : IDisposable
{
  private readonly ServiceProvider _serviceProvider;
  public Function(IServiceCollection services)
  {
    _serviceProvider = services.BuildServiceProvider();
  }

  public Function()
  {
    _serviceProvider = DependencyInjection.ResolveDependencies();
  }

  public async Task<APIGatewayProxyResponse> HandlerAsync(APIGatewayProxyRequest request, ILambdaContext context)
   => await new ApiGatewayExecutor(_serviceProvider, new ApiGatewayInvokeRequest(request, context)).RunAsync();

  public void Dispose()
  {
    Dispose(true);
    GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing)
  {
    _serviceProvider.Dispose();
  }

}