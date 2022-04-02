using System;
using System.Collections.Generic;
using System.Text;

namespace EducationManager.Data.Entities
{
    public class Courser
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public decimal Fee { set; get; }
        public string Description { set; get; }
    }
}
