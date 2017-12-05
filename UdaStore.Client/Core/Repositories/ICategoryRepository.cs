using System.Collections.Generic;
using UdaStore.Client.Core.Entities;

namespace UdaStore.Client.Core.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        IEnumerable<Category> GetAllRelated(bool includeChild = false);
    }
}
