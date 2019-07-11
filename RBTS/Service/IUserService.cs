using System.Collections.Generic;
using System.Threading.Tasks;
using RBTS.Model;

namespace RBTS.Service
{
    public interface IUserService
    {
        List<User> GetUsers();
        Task<object> AddUser(User user);
        string EditUser(int id,User user);
        string DeleteUser(int id);
        User GetUser(int id);
    }
}