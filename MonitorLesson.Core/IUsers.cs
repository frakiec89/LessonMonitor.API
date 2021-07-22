using MonitorLesson.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonitorLesson.Core
{
    public interface IUserService
    {
        void Create(User user);
        User [] Get();
    }
}

    
