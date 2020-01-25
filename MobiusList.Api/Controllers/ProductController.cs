using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MobiusList.Core.Services;

namespace MobiusList.Api.Controllers
{
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("api/products")]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _productService.GetAllProducts();
            return Ok(products);
        }
    }
}