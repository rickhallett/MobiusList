using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MobiusList.Data.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Forename { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Lastname { get; set; }
        
        public ICollection<CustomerAddress> CustomerAddress { get; set; }
    }
}