using System.Net;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.TestUtilities;
using Amazon.XRay.Model;
using Gestai.Backend.Estoque.App;

namespace Gestai.Backend.Estoque.UnitTests;

public class FuntionTests
{
  [Fact]
  public async Task When_Call_Function_Handler_With_Get_Should_Perform_Success()
  {
    // Given
    var request = new APIGatewayProxyRequest
    {
      HttpMethod = HttpMethod.Get.ToString(),
    };

    var context = new TestLambdaContext();

    var function = new Function();
  
    // When
    var result = await function.HandlerAsync(request, context);

    // Then
    result.StatusCode.Should().Be((int)HttpStatusCode.OK);
    result.Body.Should().NotBeNull();
  }
}