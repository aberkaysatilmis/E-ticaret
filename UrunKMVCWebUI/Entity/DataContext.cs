using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UrunKMVCWebUI.Entity
{
    public class DataContext:DbContext
    {
        public DataContext():base("dataConnection")
        {
            Database.SetInitializer(new DataInitializer());
        }
        public  DbSet<Product> Products { get; set; } 
        public DbSet<Category> Categories { get; set; }

<<<<<<< HEAD
=======
        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderLine> OrderLines  { get; set; }
>>>>>>> 19d6c36 (Project Updated v3.0)
    }
    
}