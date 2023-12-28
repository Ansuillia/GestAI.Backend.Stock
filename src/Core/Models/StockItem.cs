namespace Gestai.Backend.Stock.Core.Models;

public class StockItem
{
  public Product? Product { get; set; }
  private int _quantity;
  public int Quantity => _quantity;

  protected StockItem()
  {
    
  }

  public StockItem(Product product)
  {
    Product = product;
  }
  
  public void Increment(int quantity)
  {
    _quantity += quantity;
  }

  public void Decrement(int quantity)
  {
    _quantity -= quantity;
  }
}