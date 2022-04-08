using System;
using System.Collections.Generic;

#nullable disable

namespace EducationManager.API.Models
{
    public partial class Funtion
    {
        public Funtion()
        {
            Permissions = new HashSet<Permission>();
        }

        public int Id { get; set; }
        public int Name { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Permission> Permissions { get; set; }
    }
}
