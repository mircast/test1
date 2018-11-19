using System;
using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class ShoppingItem
    {
        public Guid Id{get;set;}
        [Required]
        public string Name{get;set;}
        public decimal Price{get;set;}
        public string Manufacturer{get;set;}
        
    }
}