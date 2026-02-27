using DemoProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DemoProject.DataConnection
{
    public class ProductContext:DbContext
    {
        public ProductContext():base("ProductConnection")
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}