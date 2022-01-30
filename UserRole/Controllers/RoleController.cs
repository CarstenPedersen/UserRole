using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain;
using Application;

namespace UserRole.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        IRoleService roleService;

        public RoleController(IRoleService roleService)
        {
            this.roleService = roleService;

        }
        //
        [HttpGet]
        [Route("[action]/{id}")]
        public Role Get(int id)
        {
            return this.roleService.Get(id);
        }

        // POST api/<UserController>
        [HttpPost]
        [Route("[action]")]

        public void Create([FromBody] Role role)
        {
            this.roleService.CreateRole(role);
        }

        [HttpPost]
        [Route("[action]")]
        public void Update([FromBody] Role role)
        {
            roleService.UpdateRole(role);
        }

        [HttpGet]
        [Route("[action]")]
        public List<Role> GetAll()
        {
            return roleService.GetAll();
        }
    }
}
