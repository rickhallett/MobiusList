namespace MobiusList.Api.Controllers
{
    public static class ApiRoutes
    {
        private const string Root = "api";
        private const string Version = "v1";
        private const string Base = Root + "/" + Version;

        public static class Products
        {
            public const string Create = Base + "/products";
            public const string GetAll = Base + "/products";
            public const string Get = Base + "/products/{productId}";
        }

        public static class Categories
        {
            public const string Create = Base + "/category";
            public const string GetAll = Base + "/category";
        }
        
    }
}