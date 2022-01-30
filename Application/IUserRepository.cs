using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Application
{
    public interface IUserRepository
    {
        User Get(int id);
        bool Update(User user);

        bool Create(User user);

        List<User> GetAll();

        User AddRole(int userId, Role role);
    }
}
