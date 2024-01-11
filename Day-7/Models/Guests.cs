using System;
using System.ComponentModel.DataAnnotations;

namespace Day_7.Models
{
	public class Guests
	{
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter your Name")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "Name should have alphabets only")]
        public string Name { get; set; }

        [Required(ErrorMessage = " Enter you Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Enter your email")]
        [EmailAddress(ErrorMessage = "Enter a valid email id")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter your phone number")]
        [MinLength(10, ErrorMessage = "Phone should not be less then 10 digits")]
        [MaxLength(10, ErrorMessage = "Phone should not be greater then 10 digits")]
        public string Phone { get; set; }
    }
}

