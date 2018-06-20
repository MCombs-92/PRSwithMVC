using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PRSwithMVC.Models;

namespace PRSwithMVC.ViewModels {

    public class OrderDetails {

        public PurchaseRequest PurchaseRequest { get; set; }
        public IEnumerable<PurchaseRequestLineItem> LineItem { get; set; }

        public OrderDetails() { }
    }
}