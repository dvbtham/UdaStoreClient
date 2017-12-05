using System.Collections.Generic;
using System.Linq;
using UdaStore.Client.Core.Entities;
using UdaStore.Client.Core.Repositories;

namespace UdaStore.Client.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IUdaStoreDbContext _context;

        public ProductRepository(IUdaStoreDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.Where(x => x.IsDeleted == false);
        }

        public Product Get(long id)
        {
            return _context.Products.SingleOrDefault(x => x.Id == id);
        }
        
    }
}
