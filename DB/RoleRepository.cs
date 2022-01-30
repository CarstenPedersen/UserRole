using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application;
using Domain;

namespace DB
{
    public class RoleRepository: IRoleRepository
    {
        private Dictionary<int,string> roles = new Dictionary<int,string>();

        public RoleRepository()
        {
            roles.Add(1, "Admin");
            roles.Add(2, "User");
            roles.Add(3, "Superadmin");
        }

        public bool Create(Role role)
        {
            if (roles.ContainsKey(role.Id)) throw new Exception("Already exists");

            roles.Add(role.Id, role.Name);
            return true;
        }

        public Role Get(int id)
        {
            if (!roles.ContainsKey(id)) throw new Exception("Doesn't exists");
            return new Role() { Id = id, Name = roles[id] }; 
        }

        public List<Role> GetAll()
        {
            List<Role> result = new List<Role>();
            foreach (int id in roles.Keys)
            {
                result.Add(Get(id));
            }

            return result;
        }

        public bool Update(Role role)
        {
            if (!roles.ContainsKey(role.Id)) throw new Exception("Doesn't exists");

            roles[role.Id] = role.Name;
            return true;
        }
    }
}
