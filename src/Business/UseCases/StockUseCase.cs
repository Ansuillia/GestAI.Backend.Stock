using Gestai.Backend.Stock.Core.Contracts;
using Gestai.Backend.Stock.Core.Models;

namespace Gestai.Backend.Stock.Business.UseCases;

public class StockUseCase : IStockUseCase
{
  private readonly IStockGateway _stockGateway;
  public StockUseCase(IStockGateway stockGateway)
  {
    _stockGateway = stockGateway;
  }
  public async Task<ProductStock> CreateProductAsync(Product product, int quantity)
  {
    var Stock = new Stock(product);
    Stock.Increment(quantity);
    return await _stockGateway.CreateProductAsync(Stock);
  }

  public Task<ProductStock> DecrementProductAsync(int productId, int quantity)
  {
    throw new NotImplementedException();
  }

  public Task DeleteProductAsync(int productId)
  {
    throw new NotImplementedException();
  }

  public Task DeleteProductAsync(Product product)
  {
    throw new NotImplementedException();
  }

  public Task<ProductStock> EditProductAsync(int productId, string name, string description)
  {
    throw new NotImplementedException();
  }

  public Task<IEnumerable<ProductStock>> GetNegativeProductsAsync()
  {
    throw new NotImplementedException();
  }

  public Task<ProductStock> IncrementProductAsync(int productId, int quantity)
  {
    throw new NotImplementedException();
  }
}