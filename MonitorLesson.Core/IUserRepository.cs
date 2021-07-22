using MonitorLesson.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonitorLesson.Core
{
    public interface IUserRepository
    {
        User [] Get();
        void Create(User user);
    }
}
