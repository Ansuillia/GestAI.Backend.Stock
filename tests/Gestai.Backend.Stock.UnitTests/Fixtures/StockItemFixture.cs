using Gestai.Backend.Stock.Core.Models;

namespace Gestai.Backend.Stock.UnitTests.Fixtures;

public static class StockItemFixture
{
  public static IList<StockItem> StockItems
    => new List<StockItem>
    {
      new(new Product("Product One", "For sale"){ Id = 1 }),
      new(new Product("Product Two", "For sale"){ Id = 2 }),
      new(new Product("Product Three", "For sale"){ Id = 3 }),
      new(new Product("Product Four", "For sale"){ Id = 4 }),
      new(new Product("Product Five", "For sale"){ Id = 5 })
    };
}