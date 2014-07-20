using FirstController.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstController.Data
{
    public class ProductRepository : IProductRepository
    {
        private static readonly List<Product> _products;
        static ProductRepository()
        {
            _products = new List<Product>();

            #region Data Population
            _products.Add(new Product
            {
                Id = 1,
                Name = "Totally Awesome CPU",
                Price = 250.0m,
                Categories = new List<Category>() {
                    new Category() { Id = 1, Name = "cpu"}
                }
            });

            _products.Add(new Product
            {
                Id = 2,
                Name = "Awesome Motherboard",
                Price = 250.0m,
                Categories = new List<Category>() {
                    new Category() { Id = 2, Name = "motherboard"}
                }
            });

            _products.Add(new Product
            {
                Id = 3,
                Name = "Decent Motherboard",
                Price = 130.0m,
                Categories = new List<Category>() {
                    new Category() { Id = 2, Name = "motherboard"}
                }
            });

            _products.Add(new Product
            {
                Id = 4,
                Name = "Hi-Speed 16GB RAM",
                Price = 120.0m,
                Categories = new List<Category>() {
                    new Category() { Id = 3, Name = "memory"}
                }
            });

            _products.Add(new Product
            {
                Id = 5,
                Name = "Mainstream CPU",
                Price = 150.0m,
                Categories = new List<Category>() {
                    new Category() { Id = 1, Name = "cpu"}
                }
            });

            _products.Add(new Product
            {
                Id = 6,
                Name = "Mainstream 8GB RAM",
                Price = 60.0m,
                Categories = new List<Category>() {
                    new Category() { Id = 3, Name = "memory"}
                }
            });
            #endregion
        }

        public IQueryable<Product> GetByCategory(string name)
        {
            return _products.Where(p => p.Categories.Any(c => c.Name == name))
                .AsQueryable();
        }

        public IQueryable<Product> All()
        {
            return _products.AsQueryable();
        }

        public bool Any(System.Linq.Expressions.Expression<Func<Product, bool>> predicate)
        {
            return _products.Any(predicate.Compile());
        }

        public int Count
        {
            get { return _products.Count; }
        }

        public Product Create(Product t)
        {
            _products.Add(t);

            return t;
        }

        public int Delete(Product t)
        {
            return _products.Remove(t) ? 1 : 0;
        }

        public Product Find(System.Linq.Expressions.Expression<Func<Product, bool>> predicate)
        {
            return _products.SingleOrDefault(predicate.Compile());
        }

        public IQueryable<Product> FindAll(System.Linq.Expressions.Expression<Func<Product, bool>> predicate)
        {
            return _products.Where(predicate.Compile()).AsQueryable();
        }

        public int Update(Product t)
        {
            var product = _products.SingleOrDefault(p => p.Id == t.Id);

            var success = _products.Remove(product);

            if (success)
            {
                return 0;
            }

            _products.Add(t);

            return 1;
        }
    }
}