using Gestai.Backend.Stock.Core.Models;

namespace Gestai.Backend.Stock.Core.Contracts;

public interface IStockGateway
{
  Task<StockItem> IncrementProductAsync(int productId, int quantity);
  Task<StockItem> DecrementProductAsync(int productId, int quantity);
  Task<StockItem> CreateProductAsync(StockItem item);
  Task<StockItem> EditProductAsync(int productId, string name, string description);
  Task DeleteProductAsync(int productId);
  Task DeleteProductAsync(Product product);
  Task<IEnumerable<StockItem>> GetNegativeProductsAsync();
  
}