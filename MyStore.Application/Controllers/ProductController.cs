using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using MyStore.Application.Models;

namespace MyStore.Application.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductRepository _productRepository;

    public ProductController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        throw new NotImplementedException("Not implemented.");
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        throw new NotImplementedException("Not implemented.");
    }

    [HttpPost]
    public IActionResult Create([FromBody] ProductDTO productDto)
    {
        throw new NotImplementedException("Not implemented.");
    }

    [HttpPut("{id}")]
    public IActionResult Update(Guid id, [FromBody] ProductDTO product)
    {
        throw new NotImplementedException("Not implemented.");
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        throw new NotImplementedException("Not implemented.");
    }
}