using LessonMonitor.DB;
using MonitorLesson.Core;
using MonitorLesson.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LessonMonitor.BL
{
    public class UserService : IUserService
    {
        IUserRepository _IUserRepository;

        public UserService(IUserRepository repository)
        {
            _IUserRepository = repository;
        }


        public User [] Get ()
        {
           return  _IUserRepository.Get();
        }

        public void Create(User user)
        {
            _IUserRepository.Create(user);
        }
    }
}
