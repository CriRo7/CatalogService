using CatalogService.Models;
using Microsoft.EntityFrameworkCore;

namespace CatalogService.DataContext;

public class CatalogServiceDataBaseContext: DbContext
{
    public CatalogServiceDataBaseContext(DbContextOptions<CatalogServiceDataBaseContext> options): base(options)
    { }

    public DbSet<Category> Categories { get; set; }

    public DbSet<Item>? Items { get; set; }
}