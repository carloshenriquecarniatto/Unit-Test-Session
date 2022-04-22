using System;
using Domain.Entity;
using Domain.Interfaces;
using Moq;
namespace MyStore.Application.Test.MockData;

public class MockCartBuilder
{
    public ICartRepository Build()
    {
        var mockCartRepository = new Mock<ICartRepository>();
        mockCartRepository.Setup(repo => repo.GetByIdAsync(It.IsAny<Guid>()))
            .Returns(MockCartData.GetCart());
        mockCartRepository.Setup(repo => repo.UpdateAsync(It.IsAny<Cart>()))
            .ReturnsAsync(MockCartData.GetCart());
        return mockCartRepository.Object;
    } 
    
    
}