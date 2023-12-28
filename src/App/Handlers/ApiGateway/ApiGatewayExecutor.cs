

using Amazon.Lambda.APIGatewayEvents;
using Gestai.Backend.Stock.App.Common;
using Gestai.Backend.Stock.App.Exeptions;
using Microsoft.Extensions.DependencyInjection;

namespace Gestai.Backend.Stock.App.Handlers.ApiGateway;

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