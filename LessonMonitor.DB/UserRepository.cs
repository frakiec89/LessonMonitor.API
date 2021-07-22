using MonitorLesson.Core;
using MonitorLesson.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LessonMonitor.DB
{
    public class UserRepository : IUserRepository
    {
        List<User> _users = new List<User>();
        public UserRepository()
        {
            _users = GetStart().ToList();
        }

        private User[] GetStart ()
        {
            List<User> users = new List<User>();

            for (int i = 0; i < 1; i++)
            {
                users.Add(Maping());
            }
            return users.ToArray();
        }

        private User Maping()
        {
            ModelDB.User userDd = new ModelDB.User();

            User user = new User();
            user.Age = userDd.Age;
            user.Name = userDd.Name;
            return user;
        }

        public void Create (User user)
        {
            _users.Add(user);
        }

        public User[] Get()
        {
            return _users.ToArray();
        }
    }
}
