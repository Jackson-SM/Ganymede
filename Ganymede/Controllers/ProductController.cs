using Ganymede.Entities;
using Ganymede.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Ganymede.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            return await _productRepository.GetProducts();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductById(Guid id)
        {
            return await _productRepository.GetProductById(id);
        }
    }
}
