using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestai.Backend.Stock.Business.UseCases;
using Gestai.Backend.Stock.Core.Contracts;
using Gestai.Backend.Stock.Core.Models;
using Gestai.Backend.Stock.UnitTests.Fixtures;

namespace Gestai.Backend.Stock.UnitTests.Business.UseCases
{
  public class StockUseCaseTests
  {
    [Fact]
    public async Task When_Call_CreateProductAsync_Should_Have_Perform_Success()
    {
      var fakeGateway = A.Fake<IStockGateway>();
      A.CallTo(() => fakeGateway.CreateProductAsync(A<ProductStock>._))
        .Returns(Task.FromResult(A.Dummy<ProductStock>()));

      var stockUseCase = new StockUseCase(fakeGateway);
      var result = await stockUseCase.CreateProductAsync(A.Dummy<Product>(), 10);
      A.CallTo(() => fakeGateway.CreateProductAsync(A<ProductStock>._)).MustHaveHappenedOnceExactly();
    }
  }
}
