using DEMO1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class User : MainDAO<User>
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public int age { get; set; }
        public string classRoom { get; set; }

        public User() : base() { }

        public override void Update(User entity)
        {
            var user = lists.FirstOrDefault(user => user.id == entity.id);
            lists.Remove(user);
            lists.Add(entity);
        }

        public override User getById(int id)
        {
            var user = lists.FirstOrDefault(user => user.id == id);
            return user;
        }

        public override string ToString()
        {
            return $"id = {id}, name = {name}, email = {email}, classRoom = {classRoom}, age = {age}";
        }
    }
}
