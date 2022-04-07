using System;
using System.Collections.Generic;

namespace EducationManager.Data.Models
{
    public partial class Action
    {
        public Action()
        {
            Permissions = new HashSet<Permissions>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Permissions> Permissions { get; set; }
    }
}
