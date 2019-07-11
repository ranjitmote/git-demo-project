using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RBTS.Repository
{
    public class UserRepository : IUserRepository
    {
         rbtsdbContext dbcontext=new rbtsdbContext();
        public  async Task<object> AddUser(User user)
        {
            dbcontext.Add(user);
            dbcontext.SaveChanges();
            return new {Response = "saved"};
        }
        public string display()
        {
            return "save";
        }
        public string DeleteUser(User user)
        {
            dbcontext.Remove(user);
            dbcontext.SaveChanges();
            return "deleted";
        }

        public string EditUser(User user)
        {
          // dbcontext.Update<User>(user);
           dbcontext.Update(user);
           dbcontext.SaveChanges();
           return "done";
        }

        public List<User> GetUsers()
        {
            List<User> lst =dbcontext.User.ToList();
            return lst;
        }

        public User GetUser(int id)
        {
            User user =dbcontext.User.Find(id);
            return user;
        }
    }
}