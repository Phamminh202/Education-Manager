﻿using System;
using System.Collections.Generic;

namespace EducationManager.Data.Models
{
    public partial class Parent
    {
        public Parent()
        {
            UserNavigation = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int UserId { get; set; }
        public string Job { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<User> UserNavigation { get; set; }
    }
}
