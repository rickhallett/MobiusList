using System;

namespace MobiusList.Core.Models
{
    public class Product
    {
        public int ProductNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
    }
}