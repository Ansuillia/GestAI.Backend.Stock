using Gestai.Backend.Stock.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Gestai.Backend.Stock.Infra.Data;

public class StockContext : DbContext
{
  public DbSet<Product> Products { get; set; }
  public DbSet<ProductStock> Stock { get; set; }

  public string DbPath { get; }
  public StockContext()
  {
    var folder = Environment.SpecialFolder.LocalApplicationData;
    var path = Environment.GetFolderPath(folder);
    DbPath = System.IO.Path.Join(path, "stock.db");
  }

  protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseSqlite($"Data Source={DbPath}");
}