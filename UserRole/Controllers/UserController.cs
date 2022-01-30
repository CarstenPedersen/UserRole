using Microsoft.AspNetCore.Mvc;
using Domain;
using Application;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserRole.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService; 

        }
        // GET: api/<UserController>
        [HttpGet]
        [Route("[action]/{id}")]
        public User Get(int id)
        {
            return userService.Get(id);
        }

        // POST api/<UserController>
        [HttpPost]
        [Route("[action]")]

        public void Create([FromBody] User user)
        {
            this.userService.CreateUser(user);
        }

        [HttpPost]
        [Route("[action]")]
        public void Update([FromBody] User user)
        {
            userService.UpdateUser(user);
        }

        [HttpGet]
        [Route("[action]")]
        public List<User> GetAll()
        {
            return userService.GetAll();
        }

        [HttpPost]
        [Route("[action]/userId/roleId")]
        public User AddRole(int userId, int roleId)
        {
            return userService.AddRole(userId, roleId);
        }
    }
}
