using AdFit.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdFit.Core.Service
{
    public interface IUserService
    {
        List<User> GetAll();
        public User AddUser(User user);
        public User UpdateUser(int id,User user);
        public void DeleteUser(int id);
    }
}
