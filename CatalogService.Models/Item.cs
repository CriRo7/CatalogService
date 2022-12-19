using System.Text.Json.Serialization;

namespace CatalogService.Models;

public class Item
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    
    public Guid CategoryId { get; set; }
    [JsonIgnore]
    public virtual Category? Category { get; set; }
}