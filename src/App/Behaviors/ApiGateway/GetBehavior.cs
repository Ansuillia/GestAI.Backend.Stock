using Amazon.Lambda.APIGatewayEvents;
using Gestai.Backend.Estoque.App.Common;
using Gestai.Backend.Estoque.App.Contracts.Behaviors;
using Gestai.Backend.Estoque.App.Handlers.ApiGateway;
using Microsoft.Extensions.DependencyInjection;

namespace Gestai.Backend.Estoque.App.Behaviors.ApiGateway;

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