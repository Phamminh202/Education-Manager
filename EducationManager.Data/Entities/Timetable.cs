﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EducationManager.Data.Entities
{
    public class Timetable
    {
        public int Id { set; get; }
        public int Class_Id { set; get; }
        public int Course_Id { set; get; }
    }
}
