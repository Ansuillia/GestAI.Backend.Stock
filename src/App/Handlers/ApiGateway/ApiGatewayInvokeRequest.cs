using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Gestai.Backend.Estoque.App.Behaviors.ApiGateway;
using Gestai.Backend.Estoque.App.Contracts.Behaviors;
using Gestai.Backend.Estoque.App.Exeptions;
using Microsoft.Extensions.DependencyInjection;

namespace Gestai.Backend.Estoque.App.Handlers.ApiGateway;

public class ApiGatewayInvokeRequest
{
  public readonly APIGatewayProxyRequest HttpRequest;
  public readonly ILambdaContext Context;
  public readonly string CorrelationID;

  public ApiGatewayInvokeRequest(APIGatewayProxyRequest request, ILambdaContext context)
  {
    HttpRequest = request;
    Context = context;
    if(request.Headers is not null && request.Headers.TryGetValue("correlation_id", out var correlationId))
      CorrelationID = correlationId;
    else
      CorrelationID = Guid.NewGuid().ToString();
  }

  public IApiGatewayBehavior MakeBehavior(ServiceProvider serviceProvider)
    => HttpRequest.HttpMethod switch
    {
      "GET" => new GetBehavior(serviceProvider, this),
      _ => throw new MethodNotAllowedException()
    };
}