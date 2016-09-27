using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAmazon.Models
{
    public class Product
    {
        public int Id { get; set; }
        public Category category { get; set; }
        public int CategoryId {get;set;}
        public string ProductName { get; set; }
        //public float Price { get; set; }
    }
}