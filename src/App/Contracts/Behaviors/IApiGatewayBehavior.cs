
using Amazon.Lambda.APIGatewayEvents;

namespace Gestai.Backend.Stock.App.Contracts.Behaviors;

public interface IApiGatewayBehavior : IDisposable
{
  Task<APIGatewayProxyResponse> ExecuteAsync();
}