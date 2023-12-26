
using Amazon.Lambda.APIGatewayEvents;

namespace Gestai.Backend.Estoque.App.Contracts.Behaviors;

public interface IApiGatewayBehavior : IDisposable
{
  Task<APIGatewayProxyResponse> ExecuteAsync();
}