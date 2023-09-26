using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.CORE
{
    public abstract class Person : BaseEntitie
    {
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
