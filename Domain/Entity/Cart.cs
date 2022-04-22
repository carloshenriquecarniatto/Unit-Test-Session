namespace Domain.Entity;

public class Cart : Entity
{
    public List<Product> Products { get; private set; } = new();
    public decimal Quantity { get; set; }
    public decimal TotalPrice { get; set; }
    public DateTime Date { get; set; }
    public bool IsPaid { get; set; }
    public bool IsDeleted { get; set; }
    public Guid UserId { get; set; }

    public void AddProduct(Product product)
    {
        if(product is null)
            Products = new List<Product>();
        else
        {
            Products.Add(product);
            Quantity += 1;
            TotalPrice += product.Price*Quantity;
        }
    }
}