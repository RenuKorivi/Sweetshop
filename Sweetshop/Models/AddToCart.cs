using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sweetshop.Models
{
    public class AddToCart
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
      
        public int quantity { get; set; }
        public decimal Price { get; set; }
        public int bill { get; set; }

    }
}