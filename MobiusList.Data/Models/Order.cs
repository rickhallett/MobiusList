using System;
using System.ComponentModel.DataAnnotations;

namespace MobiusList.Data.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Quantity { get; set; }
        
        [Required]
        public DateTime Date { get; set; }
        public Product Product { get; set; }
    }
}