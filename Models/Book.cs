// Book.cs
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int LibraryBranchId { get; set; }
    }
}

