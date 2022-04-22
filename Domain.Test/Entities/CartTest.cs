using Domain.Entity;
using Shouldly;
using Xunit;

namespace Domain.Test.Entities;

public class CartTest
{
    [Fact]
    public void Cart_Should_Be_Created_With_Empty_List_Of_Items()
    {
        var cart = new Cart();

        Assert.Empty(cart.Products);
    }
    
    [Fact]
    public void When_Added_Product_To_Cart_Should_be_Cart_Count_Itens_Not_Equals_Zero()
    {
        var cart = new Cart();
        var product = new Product("Product", 10);
        cart.AddProduct(product);
        cart.Products.Count.ShouldBe(1);
    }
    [Fact]
    public void When_Added_Product_Null_To_Cart_Should_be_Cart_Count_Itens_Equals_Zero()
    {
        var cart = new Cart();
        cart.AddProduct(null);
        cart.Products.Count.ShouldBe(0);
    }
    
    [Fact]
    public void When_Added_Product_With_Price_To_Cart_Should_be_Cart_Total_Price_Equals_Teen()
    {
        var cart = new Cart();
        var product = new Product("Product", 10);
        cart.AddProduct(product);
        cart.TotalPrice.ShouldBe(10);
    }
}