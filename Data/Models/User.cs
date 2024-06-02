using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftLibrary.Data.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string SirName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public string? Address { get; set; }

        [Required]
        public int Age { get; set; }

        public string? Class {  get; set; }

        public ICollection<BookRent> BookRents { get; set; } = new List<BookRent>(); 
    }
}
