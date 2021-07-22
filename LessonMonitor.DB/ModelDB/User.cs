using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LessonMonitor.DB.ModelDB
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }
}
