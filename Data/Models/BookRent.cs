using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftLibrary.Data.Models
{
    public class BookRent
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string RentCode { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User User { get; set; }

        [Required]
        [ForeignKey(nameof(Book))]
        public int BookId { get; set; }
        public Book Book { get; set; }

        [Required]
        public DateTime PickUpDate { get; set; }

        [Required]
        public DateTime ReturnDate { get; set; }

        [Required]
        public int TotalDays {  get; set; }

        [Required]
        public bool IsBookReturned { get; set; }
    }
}
