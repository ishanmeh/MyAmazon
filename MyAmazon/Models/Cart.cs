using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAmazon.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public Product product { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public float TotalPrice { get; set; }
        public int UserId { get; set; }
        //public bool CheckoutIndicator { get; set; }
    }
}