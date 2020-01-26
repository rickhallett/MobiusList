using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MobiusList.Api.Contracts.Request;
using MobiusList.Api.Resources;
using MobiusList.Data.Models;
using MobiusList.Data.Services;

namespace MobiusList.Api.Controllers
{
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper, ICategoryService categoryService)
        {
            _productService = productService;
            _mapper = mapper;
            _categoryService = categoryService;
        }

        [HttpGet("api/products")]
        public async Task<IActionResult> GetAllProducts([FromQuery] string category)
        {
            IEnumerable<Product> products = new List<Product>();
            
            if (string.IsNullOrEmpty(category))
            {
                products = await _productService.GetAllProductsAsync();
            }

            if (_categoryService.HasCategory(category))
            {
                products = await _productService.GetProductsByCategoryAsync(category);
            }

            var productResources = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductResource>>(products);
            return Ok(products);
        }

        [HttpPost("api/products")]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductRequest productRequest)
        {
            if (_categoryService.HasId(productRequest.CategoryId))
            {
                var newProduct = new Product
                {
                    Name = productRequest.Name,
                    Category = await _categoryService.GetCategoryById(productRequest.CategoryId),
                    Description = productRequest.Description,
                    Price = productRequest.Price
                };
                
                var created = await _productService.CreateProductAsync(newProduct);

                if (created)
                {
                    return Created("", newProduct);
                }
            }

            return StatusCode(400, "Category not available");
        }


    }
}