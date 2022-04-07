using System;
using System.Collections.Generic;

namespace EducationManager.Data.Models
{
    public partial class Role
    {
        public Role()
        {
            Permissions = new HashSet<Permissions>();
            Userrole = new HashSet<Userrole>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Permissions> Permissions { get; set; }
        public virtual ICollection<Userrole> Userrole { get; set; }
    }
}
