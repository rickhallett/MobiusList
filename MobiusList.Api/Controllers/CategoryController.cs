using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MobiusList.Api.Contracts.Request;
using MobiusList.Data.Models;
using MobiusList.Data.Services;

//
namespace MobiusList.Api.Controllers
{
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet(ApiRoutes.Categories.GetAll)]
        public async Task<IActionResult> GetAllCategories()
        {
            var categories = await _categoryService.GetAllCategories();

            return Ok(categories);
        }

        [HttpPost(ApiRoutes.Categories.Create)]
        public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryRequest request)
        {
            if (_categoryService.HasCategory(request.Name))
            {
                return BadRequest("Category already exists");
            }
            
            var newCategory = new Category {Name = request.Name};
            var created = await _categoryService.CreateCategoryAsync(newCategory);

            if (!created)
            {
                return BadRequest();
            }

            return Created("", newCategory);
        }
    }
}