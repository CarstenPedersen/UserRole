using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Application
{
    public interface IUserService
    {
        void CreateUser(User user);
     
        User Get(int id);

        void UpdateUser(User user);

        List<User> GetAll();

        User AddRole(int userId,int roleId);
    }
}
