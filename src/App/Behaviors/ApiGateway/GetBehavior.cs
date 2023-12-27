using Amazon.Lambda.APIGatewayEvents;
using Gestai.Backend.Stock.App.Common;
using Gestai.Backend.Stock.App.Contracts.Behaviors;
using Gestai.Backend.Stock.App.Handlers.ApiGateway;
using Microsoft.Extensions.DependencyInjection;

namespace Gestai.Backend.Stock.App.Behaviors.ApiGateway;

public class GetBehavior : BaseBehavior, IApiGatewayBehavior
{
  public GetBehavior(ServiceProvider serviceProvider, ApiGatewayInvokeRequest request) : base(serviceProvider, request)
  {
  }

  public async Task<APIGatewayProxyResponse> ExecuteAsync()
  {
    return await Task.FromResult(HttpResponse.Ok(new { Message = "Hello World "} ));
  }
}