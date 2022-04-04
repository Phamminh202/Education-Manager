using System;
using System.Collections.Generic;
using System.Text;

namespace EducationManager.Data.Entities
{
    public class Application
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Content { set; get; }
        public DateTime Create_Date { set; get; }
    }
}
