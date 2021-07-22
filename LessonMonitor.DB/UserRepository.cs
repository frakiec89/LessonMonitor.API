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

        ModelDB.MyContext myContext;
        public UserRepository()
        {
             myContext = new ModelDB.MyContext();
        }
       

        private User Maping(ModelDB.User userDb)
        {
            User user = new User();
            user.Age = userDb.Age;
            user.Name = userDb.Name;
            return user;
        }

        public void Create (User user)
        {
            try
            {
                ModelDB.User userDB = ReMaping(user);
                myContext.Users.Add(userDB);
                myContext.SaveChanges();
            }
            catch
            {
                throw new ArgumentException("Error DB");
            }

        }

        private static ModelDB.User ReMaping(User user)
        {
            return new ModelDB.User() { Age = user.Age, Name = user.Name };
        }

        public User[] Get()
        {
            List<User> users = new List<User>();
            
            try
            {
                foreach (var item in myContext.Users)
                {
                    users.Add(Maping(item));
                }
                return users.ToArray();
            }
            catch
            {
                throw new ArgumentException("Error DB");
            }
            
        }
    }
}
