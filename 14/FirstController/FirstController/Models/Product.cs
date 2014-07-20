using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstController.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public IList<Category> Categories { get; set; }
    }
}