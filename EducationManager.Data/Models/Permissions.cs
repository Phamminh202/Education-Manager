using System;
using System.Collections.Generic;

namespace EducationManager.Data.Models
{
    public partial class Permissions
    {
        public int RoleId { get; set; }
        public int ActionId { get; set; }
        public int FuntionId { get; set; }

        public virtual Action Action { get; set; }
        public virtual Funtion Funtion { get; set; }
        public virtual Role Role { get; set; }
    }
}
