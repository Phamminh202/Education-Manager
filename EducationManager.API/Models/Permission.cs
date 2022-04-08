using System;
using System.Collections.Generic;

#nullable disable

namespace EducationManager.API.Models
{
    public partial class Permission
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int ActionId { get; set; }
        public int FuntionId { get; set; }

        public virtual Action Action { get; set; }
        public virtual Funtion Funtion { get; set; }
        public virtual Role Role { get; set; }
    }
}
