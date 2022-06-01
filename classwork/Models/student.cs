using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace classwork.Models
{
    public class student
    {
        [Required (ErrorMessage ="Enter ID")]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Dob { get; set; }
    }
}