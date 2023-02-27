using Sweetshop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sweetshop.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class AddProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("Category")]
        public Category Category { get; set; }

        public decimal Price { get; set; }
    }

    public class ViewProducts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("Category")]
        public Category Category { get; set; }

        public decimal Price { get; set; }
    }



    public class SweetShopContext : DbContext

    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<AddProduct> AddProducts { get; set; }
        public DbSet<ViewProducts> viewProducts { get; set; }
        public DbSet<Registration> Registrations { get; set; }









    }
}

