using System;
using MobiusList.Api.Controllers;

namespace MobiusList.Api.Services
{
    public class UriService : IUriService
    {
        private readonly string _baseUri;

        public UriService(string baseUri)
        {
            _baseUri = baseUri;
        }
        
        public Uri GetProductUri(string productId)
        {
            return new Uri(_baseUri + ApiRoutes.Products.Get.Replace("{productId}", productId));
        }
    }
}