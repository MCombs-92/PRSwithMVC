using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PRSwithMVC.Models;

namespace PRSwithMVC.ViewModels {

    public class ShowPurchaseRequests {

        public User User { get; set; }
        public IEnumerable<PurchaseRequest> Purchaserequest { get; set; }

        public ShowPurchaseRequests() { }
    }
}