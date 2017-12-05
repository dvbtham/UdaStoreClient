using System;
using System.Collections.Generic;
using System.Linq;
using CryptoHelper;
using UdaStore.Client.Core.Entities;
using UdaStore.Client.Core.Repositories;

namespace UdaStore.Client.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IUdaStoreDbContext _context;

        public UserRepository(IUdaStoreDbContext context)
        {
            _context = context;
        }
        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User Get(long id)
        {
            return _context.Users.SingleOrDefault(x => x.Id == id);
        }
        
        public User Authenticate(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return null;

            var user = _context.Users.SingleOrDefault(x => x.UserName == username);
            
            if (user == null)
                return null;

            if (!Crypto.VerifyHashedPassword(user.PasswordHash, password))
                return null;

            // authentication successful
            return user;
        }
        
    }
}
