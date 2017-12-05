using System.Collections.Generic;

namespace UdaStore.Client.Core.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(long id);
    }
}
