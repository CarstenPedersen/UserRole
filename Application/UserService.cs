using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Application
{
    public class UserService : IUserService
    {
        IUserRepository userRepository;
        IRoleRepository roleRepository;

        public UserService(IUserRepository userRepository, IRoleRepository roleRepository)
        {
            this.userRepository = userRepository;  
            this.roleRepository = roleRepository;
        }

        public User AddRole(int userId, int roleId)
        {
            Role role = roleRepository.Get(roleId);

            return userRepository.AddRole(userId, role);
        }

        public void CreateUser(User user)
        {
            userRepository.Create(user);
        }

        public User Get(int id)
        {
            return userRepository.Get(id);   
        }

        public List<User> GetAll()
        {
            return userRepository.GetAll();
        }

        public void UpdateUser(User user)
        {
           userRepository.Update(user);
        }
    }
}
