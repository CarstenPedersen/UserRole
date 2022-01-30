using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Application
{
    public interface IRoleRepository
    {
        Role Get(int id);
        bool Update(Role role);

        bool Create(Role role);

        List<Role> GetAll();
    }
}
