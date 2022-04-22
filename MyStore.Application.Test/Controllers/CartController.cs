using System;
using System.Collections.Generic;
using Domain.Entity;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using MyStore.Application.Controllers;
using MyStore.Application.Test.MockData;
using Shouldly;
using Xunit;

namespace MyStore.Application.Test.Controllers;

public class CartControllerTest
{
    private readonly ICartRepository _cartRepositoryMock;
    public CartControllerTest()
    {
        _cartRepositoryMock = new MockCartBuilder().Build();

    }
    
    // [Theory]
    // [InlineData("00000000-0000-0000-0000-000000000000")]
    // [InlineData("09d58865-f5c7-4353-b4cc-ad70d5805f92")]
    // public void When_Call_CartController_GetCart_Should_ReturnOk(Guid id)
    // {
    //     //Arrange
    //     var controller = new CartController(_cartRepositoryMock);
    //     
    //     //Act
    //     
    //     var result = controller.GetCart(id);
    //     
    //     //Assert
    //     result.ShouldBeOfType<OkObjectResult>();
    // }
    //
    [Theory]
    [MemberData(nameof(Data))]
    public void When_Call_CartController_GetCart_Should(Guid CartId,int expectedResult)
    {
        //Arrange
        var controller = new CartController(_cartRepositoryMock);
        
        //Act
        
        var result = controller.GetCart(CartId);
        
        //Assert
        result.Quantity.ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] { new Guid("00000000-0000-0000-0000-000000000000"),0 },
            new object[] { new Guid("09d58865-f5c7-4353-b4cc-ad70d5805f92"),1 },
            new object[] { new Guid("09d58865-f5c7-4353-b4cc-ad70d5805f92"),2 },
            new object[] { new Guid("09d58865-f5c7-4353-b4cc-ad70d5805f92"),3 },
        };
}