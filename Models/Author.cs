// Author.cs
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}

