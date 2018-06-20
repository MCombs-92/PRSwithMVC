using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PRSwithMVC.Models;

namespace PRSwithMVC.ViewModels {
    public class ShowProducts {

        public Vendor Vendor { get; set; }
        public IEnumerable<Product> Products { get; set; }

        public ShowProducts() {

        }

    }
}