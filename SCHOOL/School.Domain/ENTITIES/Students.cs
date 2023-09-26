using School.Domain.CORE;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.ENTITIES
{
    public class Students : Person
    {
        public int ID { get; set; }
        public DateTime EnrrolmentDate { get; set; }
    }
}
