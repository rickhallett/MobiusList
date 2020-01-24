using System;

namespace MobiusList.Core.Models
{
    public class CustomerAddress
    {
        public Guid PostcodeId { get; set; }
        public string Postcode { get; set; }
        public string Address { get; set; }
    }
}