using Ganymede.Data;
using Ganymede.Entities;
using Ganymede.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ganymede.Repositories
{
    public class ProductRepository : IProductRepository
    {

        private readonly ProductDbContext _dbContext;

        public ProductRepository(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Product> GetProductById(Guid id)
        {
            Product product = await _dbContext.Products.FirstOrDefaultAsync(product => product.Id == id);
            
            if(product == null)
            {
                throw new Exception($"Product id: {id} not found");
            }

            return product;
        }

        public async Task<List<Product>> GetProducts()
        {
            return await _dbContext.Products.ToListAsync();
        }
    }
}
