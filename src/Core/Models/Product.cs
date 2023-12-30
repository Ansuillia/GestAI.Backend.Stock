namespace Gestai.Backend.Stock.Core.Models;

public class Product
{
  public int Id { get; set; }
  public string Name { get; set; }
  public string Description { get; set; }
  public string? Brand { get; set; }

  public Product(string name, string description)
  {
    Name = name;
    Description = description;
  }
}