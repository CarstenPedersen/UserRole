using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class RoleService : IRoleService
    {
        IRoleRepository roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            this.roleRepository = roleRepository;
        }

        public void CreateRole(Role role)
        {
            roleRepository.Create(role);
        }

        public Role Get(int id)
        {
            return roleRepository.Get(id);
        }

        public List<Role> GetAll()
        {
            return roleRepository.GetAll();
        }

        public void UpdateRole(Role role)
        {
            roleRepository.Update(role);
        }
    }
}
