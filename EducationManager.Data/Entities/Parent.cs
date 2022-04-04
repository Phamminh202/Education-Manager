using System;
using System.Collections.Generic;
using System.Text;

namespace EducationManager.Data.Entities
{
    public class Parent
    {        
        public string Name { set; get; }
        public int Phone { set; get; }
        public string Address { set; get; }
        public string Job { set; get; }
        
        public int User_Id { set; get; }

    }
}
