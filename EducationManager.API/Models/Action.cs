using System;
using System.Collections.Generic;

#nullable disable

namespace EducationManager.API.Models
{
    public partial class Action
    {
        public Action()
        {
            Permissions = new HashSet<Permission>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Permission> Permissions { get; set; }
    }
}
