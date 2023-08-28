using Ganymede.Entities;

namespace Ganymede.Repositories.Interfaces
{
    public interface IProductRepository
    {
        public Task<List<Product>> GetProducts();
        public Task<Product> GetProductById(Guid id);
    }
}
