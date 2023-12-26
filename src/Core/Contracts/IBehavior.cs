using Amazon.Lambda.APIGatewayEvents;

namespace Gestai.Backend.Estoque.Core.Contracts;

public interface IBehavior
{
  Task<APIGatewayProxyResponse> ExecuteAsync(APIGatewayProxyRequest request);
}