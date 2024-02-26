// Customer.cs
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}

