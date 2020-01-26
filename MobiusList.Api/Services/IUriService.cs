using System;

namespace MobiusList.Api.Services
{
    public interface IUriService
    {
        Uri GetProductUri(string productId);
    }
}