namespace ShoppingAPI.Models;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }

    // Navigation
    public List<Product> Products { get; set; } = new();
}
