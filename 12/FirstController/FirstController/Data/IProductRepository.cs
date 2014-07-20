using FirstController.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstController.Data
{
    public interface IProductRepository : IRepository<Product>
    {
        IQueryable<Product> GetByCategory(string name);
    }
}