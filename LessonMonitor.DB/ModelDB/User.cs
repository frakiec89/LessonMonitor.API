using System;
using System.Collections.Generic;
using System.Text;

namespace LessonMonitor.DB.ModelDB
{
    internal class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public User()
        {
            Random randon = new Random();
            Name = "User" + randon.Next(1, 20);
            Age = randon.Next(18, 50);
        }
    }
}
