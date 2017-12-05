using UdaStore.Client.Core.Entities;

namespace UdaStore.Client.Core.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        User Authenticate(string username, string password);
    }
}
