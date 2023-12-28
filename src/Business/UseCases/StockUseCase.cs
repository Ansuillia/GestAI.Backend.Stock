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
  public async Task<StockItem> CreateProductAsync(Product product, int quantity)
  {
    var stockItem = new StockItem(product);
    stockItem.Increment(quantity);
    return await _stockGateway.CreateProductAsync(stockItem);
  }

  public Task<StockItem> DecrementProductAsync(int productId, int quantity)
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

  public Task<StockItem> EditProductAsync(int productId, string name, string description)
  {
    throw new NotImplementedException();
  }

  public Task<IEnumerable<StockItem>> GetNegativeProductsAsync()
  {
    throw new NotImplementedException();
  }

  public Task<StockItem> IncrementProductAsync(int productId, int quantity)
  {
    throw new NotImplementedException();
  }
}