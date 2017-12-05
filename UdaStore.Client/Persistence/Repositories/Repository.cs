using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using UdaStore.Client.Core.Repositories;

namespace UdaStore.Client.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class 
    {
        private readonly UdaStoreDbContext _context;
        private DbSet<T> _entities;

        public Repository(UdaStoreDbContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable();
        }
        public T Get(long id)
        {
            return _entities.Find(id);
        }
    }
}
