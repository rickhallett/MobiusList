using System;

namespace MobiusList.Data.Models
{
    public class CustomerAddress
    {
        public Guid PostcodeId { get; set; }
        public string Postcode { get; set; }
        public string Address { get; set; }
    }
}