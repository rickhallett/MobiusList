namespace MobiusList.Api.Resources
{
    public class ProductResource
    {
        public int ProductNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public CategoryResource Category { get; set; }
    }
}