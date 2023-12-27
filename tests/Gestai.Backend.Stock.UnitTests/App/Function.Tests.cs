using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.TestUtilities;
using Gestai.Backend.Stock.App;
using Gestai.Backend.Stock.App.Exeptions;
using Microsoft.Extensions.DependencyInjection;
using System.Net;

namespace Gestai.Backend.Stock.UnitTests;

public class FuntionTests
{
  [Fact]
  public async Task When_Call_Function_Handler_With_Get_Should_Perform_Success()
  {
    // Given
    var serviceCollection = new ServiceCollection();

    var context = new TestLambdaContext();
    var request = new APIGatewayProxyRequest
    {
      HttpMethod = HttpMethod.Get.ToString(),
    };

    var function = new Function(serviceCollection);

    // When
    var result = await function.HandlerAsync(request, context);

    // Then
    result.StatusCode.Should().Be((int)HttpStatusCode.OK);
    result.Body.Should().NotBeNull();
  }

  [Fact]
  public async Task When_Call_Function_Handler_With_MethodNotAllowed_Should_Perform_Error()
  {
    // Given
    var serviceCollection = new ServiceCollection();

    var context = new TestLambdaContext();
    var request = new APIGatewayProxyRequest
    {
      HttpMethod = HttpMethod.Delete.ToString(),
    };

    var function = new Function(serviceCollection);

    // When
    var result = await function.HandlerAsync(request, context);

    // Then
    result.StatusCode.Should().Be((int)HttpStatusCode.MethodNotAllowed);
  }
}