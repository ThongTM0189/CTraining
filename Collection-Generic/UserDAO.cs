using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Generic
{
    public class UserDAO : DAO<User>
    {
        public User Get(int id)
        {
            return new User();
        }

        public User Update(User entity)
        {
            return new User();
        }

        public User Delete(int id)
        {
            return new User();
        }

        public IEnumerable<User> GetAll()
        {
            return new List<User>();
        }
    }
}
