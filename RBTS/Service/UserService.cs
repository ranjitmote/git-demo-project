using System.Collections.Generic;
using user= RBTS.Model.User;
using RBTS.Repository;
using System.Threading.Tasks;

namespace RBTS.Service
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<object> AddUser(user user)
        {
             dynamic test=  await _userRepository.AddUser(MappingToRepository(user));
            return "Saved";
        }

        public string DeleteUser(int id)
        {
            User ur=_userRepository.GetUser(id);
            string str = _userRepository.DeleteUser(ur);
            return str;
        }

        public string EditUser(int id, user user)
        {
           User ur=_userRepository.GetUser(id);
           string str=_userRepository.EditUser(MatchModeUserToRepoUser(ur,user));
           return str;
        }

        public List<user> GetUsers()
        {
            var lst=_userRepository.GetUsers();
            List<user> list=new List<user>();
            foreach(User u in lst)
            {
                list.Add(MappingToModel(u));
            }
            return list;
        }

        public user GetUser(int id)
        {
            User u= _userRepository.GetUser(id);
            return MappingToModel(u);
        }
        public user MappingToModel(User repoUser){
            user ur=new user();
            ur.Address=repoUser.Address;
            ur.Dob=repoUser.Dob;
            ur.Email=repoUser.Email;
            ur.MobileNo=repoUser.MobileNo;
            ur.Name=repoUser.Name;
            ur.Password=repoUser.Password;
            ur.Gender=repoUser.Gender;
            ur.Id=repoUser.Id;
            return ur;
        }
         public User MappingToRepository(user modelUser){
            User ur=new User();
            ur.Address=modelUser.Address;
            ur.Dob=modelUser.Dob;
            ur.Email=modelUser.Email;
            ur.MobileNo=modelUser.MobileNo;
            ur.Name=modelUser.Name;
            ur.Password=modelUser.Password;
            ur.Gender=modelUser.Gender;
            ur.Id=modelUser.Id;
            return ur;
        }
        public User MatchModeUserToRepoUser (User repoUser,user modelUser)
        {
           
            repoUser.Address=modelUser.Address;
            repoUser.Dob=modelUser.Dob;
            repoUser.Email=modelUser.Email;
            repoUser.MobileNo=modelUser.MobileNo;
            repoUser.Name=modelUser.Name;
            repoUser.Password=modelUser.Password;
            repoUser.Gender=modelUser.Gender;
            return repoUser;
        }
    }
}