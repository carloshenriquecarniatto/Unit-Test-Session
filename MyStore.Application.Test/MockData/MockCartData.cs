using Domain.Entity;

namespace MyStore.Application.Test.MockData;

public static class MockCartData
{
    public static Cart GetCart()
    {
        return new Cart
        {
            Products =
            {
                new Product("Name",10m)
                {
                    Category = "Category",
                    Description = "Description",
                    Image = "Image",
                }
            }
        };
    }
}