using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RBTS.Model;
using RBTS.Service;

namespace RBTS.Controller
{
    [Route("/")]
    [ApiController]
    public class UserController:ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        
        [HttpGet]
        public List<User> GetAllUser()
        {
            List<User> ulist=_userService.GetUsers() ;   
            return ulist;
        }
        [HttpGet("{id}")]
        public User GetUser(int id)
        {
            User user=_userService.GetUser(id);
            return user;
        }
        [HttpPost]
        public  async Task<ObjectResult> AddUser([FromBody] User user)
        {
           dynamic test=  await _userService.AddUser(user);
            
            return  StatusCode(200,"Saved");
        }
        [HttpPut("{id}")]
        public string UpdateUser(int id,[FromBody] User user)
        {
            string str=_userService.EditUser(id, user);
            return str;
        }
        [HttpDelete("{id}")]
        public string RemoveUser(int id)
        {
            string str = _userService.DeleteUser(id);
            return str;
        }
    }
}