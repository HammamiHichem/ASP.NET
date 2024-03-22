// FormData.cs
using System;
using System.ComponentModel.DataAnnotations;

namespace Form_Submission.Models
{
    public class FormData
    {
        [Required(ErrorMessage = "The name is required.")]
        [MinLength(2, ErrorMessage = "The name must be at least 2 characters long.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The email address is required.")]
        [EmailAddress(ErrorMessage = "The email address format is invalid.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The date of birth is required.")]
        [PastDate(ErrorMessage = "The date of birth must be in the past.")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "The password is required.")]
        [MinLength(8, ErrorMessage = "The password must be at least 8 characters long.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "The favorite prime number is required.")]
        [PrimeNumber(ErrorMessage = "The favorite prime number must be a prime number.")]
        public int FavoritePrimeNumber { get; set; }
    }
}
