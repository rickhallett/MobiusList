using System;

namespace MobiusList.Data.Models
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public string Forename { get; set; }
        public string Lastname { get; set; }
        public CustomerAddress CustomerAddress { get; set; }
    }
}