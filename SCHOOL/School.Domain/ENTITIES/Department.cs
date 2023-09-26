using School.Domain.CORE;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.ENTITIES
{
    public class Department : BaseEntitie
    {
        public int DepartmentID {  get; set; }
        public string? Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StarDate { get; set; }
        public int? Administrator {  get; set; }
    }
}
