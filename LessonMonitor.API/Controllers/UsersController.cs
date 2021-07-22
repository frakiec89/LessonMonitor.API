using LessonMonitor.API.MyReflection;
using LessonMonitor.BL;
using LessonMonitor.DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonitorLesson.Core;
using MonitorLesson.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace LessonMonitor.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;

        public UsersController()
        {
            _userService = new UserService(new UserRepository());  // Инициализация - нужно  будет вынести  за рамки контроллера 
        }

        [HttpGet("GetUser")]
        public   User [] GetUser()
        {
            return  _userService.Get();
        }


        [HttpPost ("AddUser")]
        public void Creat(UserAPI userApi )
        {
            _userService.Create(Maping(userApi));
        }

        private static User Maping(UserAPI userApi)
        {
            var user = new User();
            user.Age = userApi.Age;
            user.Name = userApi.Name;
            return user;
        }
    }
}
