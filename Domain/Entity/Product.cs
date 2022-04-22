namespace Domain.Entity;

public class Product : Entity
{
    public Product(string name, decimal price)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException(nameof(Name));
        Price = price <= 0 ? 1.0m : price;
        Name = name;
    }
    public string Name { get; private set; }
    public string Description { get; set; }
    public decimal Price { get; private set; }
    public string Image { get; set; }
    public string Category { get; set; }
}
