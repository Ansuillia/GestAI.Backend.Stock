using Gestai.Backend.Stock.Core.Models;

namespace Gestai.Backend.Stock.Core.Contracts;

public interface IStockUseCase
{
  Task<StockItem> IncrementProductAsync(int productId, int quantity);
  Task<StockItem> DecrementProductAsync(int productId, int quantity);
  Task<StockItem> CreateProductAsync(Product product, int quantity);
  Task<StockItem> EditProductAsync(int productId, string name, string description);
  Task DeleteProductAsync(int productId);
  Task DeleteProductAsync(Product product);
  Task<IEnumerable<StockItem>> GetNegativeProductsAsync();
  
}