using Domain.Entity;

namespace MyStore.Application.Models;

public record CartDto
{
    public IReadOnlyList<Product> Products { get;} = new List<Product>();
    public int Quantity { get; init; }
    public decimal TotalPrice { get; init; }
    public DateTime Date { get; init; }
    public bool IsPaid { get; init; }
    public bool IsDeleted { get; init; }
}
