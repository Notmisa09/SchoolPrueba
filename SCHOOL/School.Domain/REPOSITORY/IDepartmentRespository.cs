using School.Domain.ENTITIES;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.REPOSITORY
{
    public interface IDepartmentRespository
    {
        void Update(Department student);
        void Remove(Department student);
        List<Department> GetInstructors();
        Department GetInstructor(int Id);
    }
}
