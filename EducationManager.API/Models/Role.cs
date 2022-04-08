using System;
using System.Collections.Generic;

#nullable disable

namespace EducationManager.API.Models
{
    public partial class Role
    {
        public Role()
        {
            Permissions = new HashSet<Permission>();
            Userroles = new HashSet<Userrole>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Permission> Permissions { get; set; }
        public virtual ICollection<Userrole> Userroles { get; set; }
    }
}
