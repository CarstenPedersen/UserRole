using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Application
{
    public interface IRoleService
    {
        void CreateRole(Role role);

        Role Get(int id);

        void UpdateRole(Role Role);

        List<Role> GetAll();
    }
}
