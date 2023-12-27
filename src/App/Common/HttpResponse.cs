
using Amazon.Lambda.APIGatewayEvents;
using System.Text.Json;

namespace Gestai.Backend.Stock.App.Common;

public static class HttpResponse
{
  private static readonly Dictionary<string, string> _defaultHeaders = new()
  {
    { "Access-Control-Allow-Headers", "Content-Type, Authorization, X-Amz-Date, X-Api-Key, X-Amz-Secutiry-Token" },
    { "Access-Control-Allow-Methods", "GET,HEAD,OPTIONS" },
    { "Access-Control-Allow-Origin", "*" },
  };

  public static APIGatewayProxyResponse Ok(object data, bool withCorsHeaders = true)
    => new()
    {
      StatusCode = 200,
      Body = JsonSerializer.Serialize(new { data }),
      Headers = withCorsHeaders ? _defaultHeaders : null
    };

  public static APIGatewayProxyResponse Created(object data, bool withCorsHeaders = true)
    => new()
    {
      StatusCode = 201,
      Body = JsonSerializer.Serialize(new { data }),
      Headers = withCorsHeaders ? _defaultHeaders : null
    };

  public static APIGatewayProxyResponse Accepted(object data, bool withCorsHeaders = true)
    => new()
    {
      StatusCode = 202,
      Body = JsonSerializer.Serialize(new { data }),
      Headers = withCorsHeaders ? _defaultHeaders : null
    };

  public static APIGatewayProxyResponse NoContent(bool withCorsHeaders = true)
    => new()
    {
      StatusCode = 204,
      Headers = withCorsHeaders ? _defaultHeaders : null
    };

  public static APIGatewayProxyResponse BadRequest(string erroCode, string errorMessage, bool withCorsHeaders = true)
    => new()
    {
      StatusCode = 400,
      Body = JsonSerializer.Serialize(new { messages = new object[] { new { Codigo = erroCode, Mensagem = errorMessage } } }),
      Headers = withCorsHeaders ? _defaultHeaders : null
    };

  public static APIGatewayProxyResponse MethodNotAllowed(bool withCorsHeaders = true)
  => new() {
    StatusCode = 405,
    Headers = withCorsHeaders? _defaultHeaders : null
  };

  public static APIGatewayProxyResponse InternalServerError(bool withCorsHeaders = true)
  => new() {
    StatusCode = 500,
    Headers = withCorsHeaders? _defaultHeaders : null
  };

}