using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PRSwithMVC.Models
{
    public class PRSwithMVCContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public PRSwithMVCContext() : base("name=PRSwithMVCContext")
        {
        }

        public System.Data.Entity.DbSet<PRSwithMVC.Models.User> Users { get; set; }

        public System.Data.Entity.DbSet<PRSwithMVC.Models.Vendor> Vendors { get; set; }

        public System.Data.Entity.DbSet<PRSwithMVC.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<PRSwithMVC.Models.PurchaseRequest> PurchaseRequests { get; set; }

        public System.Data.Entity.DbSet<PRSwithMVC.Models.PurchaseRequestLineItem> PurchaseRequestLineItems { get; set; }
    }
}
