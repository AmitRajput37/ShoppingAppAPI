using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingAppAPI.Models;

namespace ShoppingAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly ProductRepository _productRepository;
        public ProductsController()
        {
            _productRepository = new ProductRepository();
        }

        [HttpGet("all")]
        public ActionResult<List<Product>> GetAllProducts()
        {
            var products = _productRepository.GetAllProducts();
            return Ok(products);
        }

        [HttpGet]
        public ActionResult<List<Product>> GetProducts([FromQuery] string? search="")
        {
            var products = _productRepository.GetProducts(search);
            return Ok(products);
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProductById(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

    }
}
