using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace classwork.Models
{
    public class Product
    {
        [Required(ErrorMessage = "Enter Product ID")]
        
        public int Id { get; set; }


        [Required(ErrorMessage = "Enter Product name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Enter Product price")]
        public int Price { get; set; }
    }
}