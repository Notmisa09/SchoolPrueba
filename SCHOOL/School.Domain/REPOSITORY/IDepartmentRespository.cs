using School.Domain.ENTITIES;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.REPOSITORY
{
    public interface IDepartmentRespository
    {
        void Save(Department department);
        void Update(Department department);
        void Remove(Department department);
        void GetCourseID(Department department);
        List<Department> GetCourses();
    }
}
