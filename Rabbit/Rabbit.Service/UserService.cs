using AspNet.Identity.MongoDB;
using Microsoft.AspNet.Identity;
using MongoDB.Driver;
using Rabbit.Models;

namespace Rabbit.Service
{
    class UserService :IUserService
    {
        private readonly static IMongoCollection<User> _users = new dbContext().Users;
        private readonly static UserStore<User> _userStore = new UserStore<User>(_users);
        private readonly static UserManager<User> _userManager = new UserManager<User>(_userStore);
        
        public UserService()
        {
        }
    }
}
