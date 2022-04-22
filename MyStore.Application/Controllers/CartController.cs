using Domain.Entity;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MyStore.Application.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CartController : ControllerBase
{
    private readonly ICartRepository _cartRepository;

    public CartController(ICartRepository cartRepository)
    {
        _cartRepository = cartRepository;
    }

    [HttpGet("{id}")]
    public Cart GetCart(Guid id)
    {
        return _cartRepository.GetByIdAsync(id);
    }

    [HttpPost("{productId}")]
    public IActionResult AddToCart(int productId)
    {
        throw new NotImplementedException("Not implemented.");
    }

    [HttpDelete("{productId}")]
    public IActionResult RemoveFromCart(int productId)
    {
        throw new NotImplementedException("Not implemented.");
    }
}