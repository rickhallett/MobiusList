using System;

namespace MobiusList.Core.Models
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public int OrderNumber { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
        public Product Product { get; set; }
    }
}