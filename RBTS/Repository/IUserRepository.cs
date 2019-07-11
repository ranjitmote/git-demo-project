using System.Collections.Generic;
using System.Threading.Tasks;
using RBTS.Model;

namespace RBTS.Repository
{
    public interface IUserRepository
    {
         List<User> GetUsers();
         Task<object> AddUser(User user);
         string EditUser(User user);
         string DeleteUser(User user);
        User GetUser(int id);
    }
}