

using Amazon.Lambda.APIGatewayEvents;
using Gestai.Backend.Estoque.App.Exeptions;
using Microsoft.Extensions.DependencyInjection;
using Gestai.Backend.Estoque.App.Common;

namespace Gestai.Backend.Estoque.App.Handlers.ApiGateway;

public class ApiGatewayExecutor
{
  private readonly ServiceProvider _serviceProvider;
  private readonly ApiGatewayInvokeRequest _apiGatewayInvokeRequest;
  public ApiGatewayExecutor(ServiceProvider serviceProvider, ApiGatewayInvokeRequest apiGatewayInvokeRequest)
  {
    _serviceProvider = serviceProvider;
    _apiGatewayInvokeRequest = apiGatewayInvokeRequest;
  }

  public async Task<APIGatewayProxyResponse> RunAsync()
  {
    try
    {
      using var behavior = _apiGatewayInvokeRequest.MakeBehavior(_serviceProvider);
      return await behavior.ExecuteAsync();
    }
    catch (MethodNotAllowedException)
    {
      return HttpResponse.MethodNotAllowed();
    }
    catch(Exception)
    {
      return HttpResponse.InternalServerError();
    }
  }
}