using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using UdaStore.Client.Core.Entities;
using UdaStore.Client.Core.Repositories;

namespace UdaStore.Client.Persistence.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IUdaStoreDbContext _context;

        public CategoryRepository(IUdaStoreDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Category> GetAll()
        {
            return _context.Categories.Where(x => x.IsDeleted == false);
        }
        public IEnumerable<Category> GetAllRelated(bool includeChild = false)
        {
            return _context.Categories.Include(x => x.InverseParent).Where(x => x.IsDeleted == false);
        }

        public Category Get(long id)
        {
            return _context.Categories.SingleOrDefault(x => x.Id == id && !x.IsDeleted);
        }
    }
}
