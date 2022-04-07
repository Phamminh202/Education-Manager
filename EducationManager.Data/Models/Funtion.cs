using System;
using System.Collections.Generic;

namespace EducationManager.Data.Models
{
    public partial class Funtion
    {
        public Funtion()
        {
            Permissions = new HashSet<Permissions>();
        }

        public int Id { get; set; }
        public int Name { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Permissions> Permissions { get; set; }
    }
}
