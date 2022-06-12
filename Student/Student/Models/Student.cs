using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Student.Models
{
    public class Student
    {

            [Required(ErrorMessage = "Enter ID")]
        [RegularExpression("^[0-9]{2}[-][0-9]{5}[-][1-3]", ErrorMessage = "ID is not valid")]
        public string Id { get; set; }
            [Required]
        [RegularExpression("^[a-zA-Z\\._]*$", ErrorMessage = "Name is not valid")]
        public string Name { get; set; }
            [Required]
            public DateTime Dob { get; set; }

            [Required]
            [StringLength(28, ErrorMessage ="The password should be 8 characters",MinimumLength =7)]
            public string password { get; set; }

            [Required]
        [Compare(nameof(password),ErrorMessage = "Password does not same")]
            public string Cpassword { get; set; }
            [Required]
            [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage ="E-mail is not valid")]
           public string Email { get; set; }


    }
  
}
