using Amazon.Lambda.APIGatewayEvents;

namespace Gestai.Backend.Estoque.Core.Contracts;

public interface IApiGatewayExecutor
{
  Task<APIGatewayProxyResponse> MakeBehavior(APIGatewayProxyRequest request);
}