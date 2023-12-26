using System.Net;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.TestUtilities;
using Gestai.Backend.Estoque.App;
using Gestai.Backend.Estoque.Core.Contracts;

namespace Gestai.Backend.Estoque.UnitTests;

public class FuntionTests
{
  [Fact]
  public async Task When_Call_Function_Handler_With_Get_Should_Perform_Success()
  {
    // Given
    var context = new TestLambdaContext();
    var request = new APIGatewayProxyRequest
    {
      HttpMethod = HttpMethod.Get.ToString(),
    };
    var response = new APIGatewayProxyResponse{
      Body = "Tests",
      StatusCode = (int)HttpStatusCode.OK
    };

    var _fakeApiExecutor = A.Fake<IApiGatewayExecutor>();

    A.CallTo(() => _fakeApiExecutor.MakeBehavior(request)).Returns(Task.FromResult(response));

    var function = new Function();
  
    // When
    var result = await function.HandlerAsync(request, context);

    // Then
    result.StatusCode.Should().Be((int)HttpStatusCode.OK);
    result.Body.Should().NotBeNull();
  }
}