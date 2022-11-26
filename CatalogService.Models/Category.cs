namespace CatalogService.Models;

public class Category
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public ICollection<Item>? Items { get; set; }
}