using System.Net;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace Gestai.Backend.Estoque.App;

public class Function
{
  public Function()
  {

  }

  public async Task<APIGatewayProxyResponse> HandlerAsync(APIGatewayProxyRequest request, ILambdaContext context)
  {
    return await Task.FromResult(
      new APIGatewayProxyResponse
      {
        Body = "teste",
        StatusCode = (int)HttpStatusCode.OK
      });
  }
}