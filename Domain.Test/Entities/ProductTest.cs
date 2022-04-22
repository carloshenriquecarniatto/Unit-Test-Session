using System;
using Domain.Entity;
using Shouldly;
using Xunit;

namespace Domain.Test.Entities;

public class ProductTest
{
    [Fact]
    public void Product_Should_Be_Cannot_Be_Created_Without_Name()
    {
        //Arrange
        var product = new Product("Product 1",0.0m);
        
        //Assert
        Assert.NotNull(product.Name);
    }
    
    [Fact]
    public void Product_With_Empty_Name_Should_Be_Throws_Argument_Expection()
    {
        Should.Throw<ArgumentException>(() =>
        {
            var product = new Product("",0.0m);
        });
    }
    
    [Fact]
    public void Product_With_Zero_Price_Should_Be_One()
    {
        var product = new Product("Product 1",0.0m);
        
        product.Price.ShouldBe(1.0m);
    }
}