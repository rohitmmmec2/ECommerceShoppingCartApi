using Application.IRepositories;
using Domain.Entities;
using Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext _context;
        public ProductRepository(ProductDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }
        public Product GetProductById(int id)
        {
            return _context.Set<Product>().Find(id);
        }
        public void AddProduct(Product product)
        {
           _context.Products.Add(product);
            //_context.Set<Product>().Add(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            _context.Products.Remove(GetProductById(id));
            _context.SaveChanges();
        }
        public void UpdateProduct(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
