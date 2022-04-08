using System;
using System.Collections.Generic;

#nullable disable

namespace EducationManager.API.Models
{
    public partial class Application
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
