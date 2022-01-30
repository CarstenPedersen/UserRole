using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application;
using Domain;

namespace DB
{
    public class UserRepository : IUserRepository
    {
        public Dictionary<string,User> Users { get; set; }

        public UserRepository() { 

            Users = new Dictionary<string,User>();

            Users.Add("cj@spectra.dk", new User()
            {
                Email = "cj@spectra.dk",
                Name = "Claus",
                Id = 1,
                Password = "spectra"
            });

        }

        public bool Create(User user)
        {
            if (Users.ContainsKey(user.Email)) throw new Exception("Already exists");
            
            Users.Add(user.Email, user);
            return true;
        }

        public User Get(int id)
        {
            User user = Users.Values.First(User => User.Id == id);

            return user;
        }

        public List<User> GetAll()
        {
            List<User> allUsers = new List<User>(); 
            foreach (User user in Users.Values)
            {
                allUsers.Add(user);
            }
            return allUsers;
        }

        public bool Update(User user)
        {
            if (!Users.ContainsKey(user.Email)) throw new Exception("Doesn't exits");
            Users[user.Email] = user;
            return true;
        }

        public User AddRole(int userId, Role role)
        {
            User user = Get(userId);

            if (user.Roles==null)  user.Roles = new List<Role>();   
            user.Roles.Add(role);

            return user;

        }
    }
}
