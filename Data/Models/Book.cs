using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftLibrary.Data.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(100)]
        public string BookCode { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(500)]
        public string Title { get; set; }

        [MaxLength(10_000)]
        public string Description { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(150)]
        public string Author { get; set; }

        [Required]
        public int PagesCount { get; set; }

        public ICollection<BookRent> BookRents { get; set; } = new List<BookRent>();
    }
}       
