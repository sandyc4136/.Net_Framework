using System;
using System.ComponentModel.DataAnnotations;

namespace MyWebApp2.Models
{
	public class Guest
	{
		public int Id { get; set; }

        [Required(ErrorMessage = "Enter your Name")]
        [RegularExpression(pattern:"^[a-zA-Z]+${30}", ErrorMessage ="Name should only have alphabets")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Enter your Address")]
        public String Address { get; set; }

        [Required(ErrorMessage = "Enter your Email")]
        public String Email  { get; set; }

        [Required(ErrorMessage = "Enter your Phone Number")]
        [MinLength(10,ErrorMessage ="Phone numbers should not be less than 10 digits")]
        public String Phone { get; set; }
    }
}

