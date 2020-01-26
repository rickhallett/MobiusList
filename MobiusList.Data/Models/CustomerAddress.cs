using System;
using System.ComponentModel.DataAnnotations;

namespace MobiusList.Data.Models
{
    public class CustomerAddress
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(7)]
        public string Postcode { get; set; }
        
        [Required]
        [MaxLength(200)]
        public string Address { get; set; }
    }
}