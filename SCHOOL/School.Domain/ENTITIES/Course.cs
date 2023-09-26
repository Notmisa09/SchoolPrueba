using School.Domain.CORE;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.ENTITIES
{
    public class Course : BaseEntitie
    {
        public int CourseID { get; set; }
        public string? Tittle { get; set; }
        public int Credits { get; set; }
        public int DepartmentID { get; set; }

    }
}
