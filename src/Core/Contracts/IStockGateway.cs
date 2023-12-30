using Gestai.Backend.Stock.Core.Models;

namespace Gestai.Backend.Stock.Core.Contracts;

public interface IStockGateway
{
  Task<ProductStock> IncrementProductAsync(int productId, int quantity);
  Task<ProductStock> DecrementProductAsync(int productId, int quantity);
  Task<ProductStock> CreateProductAsync(ProductStock item);
  Task<ProductStock> EditProductAsync(int productId, string name, string description);
  Task DeleteProductAsync(int productId);
  Task DeleteProductAsync(Product product);
  Task<IEnumerable<ProductStock>> GetNegativeProductsAsync();
  
}